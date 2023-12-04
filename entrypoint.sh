# Start SQL Server, start the script to create the DB and import the test seed data
# The order is reversed on purpose to prevent the container from shutting down when
# the script finishes. The script will run in the background when the server is running.
/usr/src/app/import-data.sh & /opt/mssql/bin/sqlservr