# syntax=docker/dockerfile:1

# Comments are provided throughout this file to help you get started.
# If you need more help, visit the Dockerfile reference guide at
# https://docs.docker.com/engine/reference/builder/

################################################################################
FROM mcr.microsoft.com/mssql/server:2022-latest AS sqlserver

# Switch to root user for intial setup
USER root
# Create the directory to copy the setup files to
RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app
# Copy the setup files to the directory
COPY initial_db_create.sql entrypoint.sh import-data.sh /usr/src/app/
# Grant permissions for the import-data script to be executable
RUN chmod +x /usr/src/app/import-data.sh
# Switch back to mssql user and run the entrypoint script
USER mssql

ENTRYPOINT ["/bin/bash", "./entrypoint.sh"]

# Learn about building .NET container images:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md

# Create a stage for building the application.
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
ARG TARGETARCH

COPY . /source

WORKDIR /source/CFAPInventoryView

# Build the application.
# Leverage a cache mount to /root/.nuget/packages so that subsequent builds don't have to re-download packages.
# If TARGETARCH is "amd64", replace it with "x64" - "x64" is .NET's canonical name for this and "amd64" doesn't
#   work in .NET 6.0.
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages \
    dotnet publish -a ${TARGETARCH/amd64/x64} --use-current-runtime --self-contained false -o /app

################################################################################
# Create a new stage for running the application that contains the minimal
# runtime dependencies for the application. This often uses a different base
# image from the build stage where the necessary files are copied from the build
# stage.
#
# The example below uses an aspnet alpine image as the foundation for running the app.
# It will also use whatever happens to be the most recent version of that tag when you
# build your Dockerfile. If reproducability is important, consider using a more specific
# version (e.g., aspnet:7.0.10-alpine-3.18),
# or SHA (e.g., mcr.microsoft.com/dotnet/aspnet@sha256:f3d99f54d504a21d38e4cc2f13ff47d67235efeeb85c109d3d1ff1808b38d034).
FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine AS final
WORKDIR /app

# Copy everything needed to run the app from the "build" stage.
COPY --from=build /app .
# Add and configure ICU for globalization support
# See https://github.com/dotnet/dotnet-docker/blob/main/samples/enable-globalization.md
ENV \
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false \
    LC_ALL=en_US.UTF-8 \
    LANG=en_US.UTF-8 
# Add required libraries for globalization and set sensitive environment variables from filesystem
RUN apk add --no-cache \
    icu-data-full \
    icu-libs
# Create a non-privileged user that the app will run under.
# See https://docs.docker.com/go/dockerfile-user-best-practices/
ARG UID=10001
RUN adduser \
    --disabled-password \
    --gecos "" \
    --home "/nonexistent" \
    --shell "/sbin/nologin" \
    --no-create-home \
    --uid "${UID}" \
    appuser
USER appuser

ENTRYPOINT ["dotnet", "CFAPInventoryView.dll"]
