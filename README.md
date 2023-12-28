# CFAPInventoryView

#### This ASP.NET Core v7 MVC web app with a MS SQL Express DB backend was created for the Columbia Foster and Adoption Program (CFAP) to track their product and iBelong Basket inventory status.

<hr />

# How do I evaluate this repo using Docker?

### Purpose:

Below, I outline the steps required to get a local copy of the project up and running for team collaboration or demonstration purposes.

### Target Audience:

Developers for non-profit organizations.

### Assumptions:

- [Git](https://github.com/git-guides/install-git) is already installed and configured.
- [Docker](https://docs.docker.com/get-docker/) is already installed and configured. Additional Docker command [info](./README.Docker.md).
- _(Optional)_ You already have [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [VS Code](https://code.visualstudio.com/download) installed and configured.

### Steps:

1. Clone the repository:
   - [Clone with preferred shell](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
   - [Clone with Visual Studio](https://learn.microsoft.com/en-us/visualstudio/version-control/git-clone-repository?view=vs-2022)
   - [Clone with VS Code](https://learn.microsoft.com/en-us/azure/developer/javascript/how-to/with-visual-studio-code/clone-github-repository?tabs=create-repo-command-palette%2Cinitialize-repo-activity-bar%2Ccreate-branch-command-palette%2Ccommit-changes-command-palette%2Cpush-command-palette)
2. Open your preferred shell (if not already there) to the folder where you copied the newly downloaded repository and run the command: `git checkout docker`. Alternatively, switch to the docker branch in Visual Studio or VS Code.
3. Create the required .env files at the same directory level as the compose.yaml file:

    - mssql-server.env: You will need three environment variables in this file. You can review the documentation here:  [microsoft-mssql-server](https://hub.docker.com/_/microsoft-mssql-server)

      - `ACCEPT_EULA=Y`
      - `MSSQL_PID=Express`
      - `MSSQL_SA_PASSWORD=`(A strong system administrator (SA) password: At least 8 characters including uppercase, lowercase letters, base-10 digits and/or non-alphanumeric symbols.)

    - cfapinventoryview.env:  You will need nine environment variables in this file.  Here is the documentation

      - `ASPNETCORE_URLS=https://+:443;http://+:80`
      - `ASPNETCORE_Kestrel__Certificates__Default__Password=`(create your own)
      - `ASPNETCORE_Kestrel__Certificates__Default__Path=/https/aspnetapp.pfx`
      - `SQL_CONNECTION_STR_DOCKER="Persist Security Info=False;Server=database;Initial Catalog=CFAPInventory;User Id=SA;Password=`(use the password you created in the mssql-server.env file)`;MultipleActiveResultSets=true;TrustServerCertificate=true;Encrypt=true"`
      - `SendGridKey=`(create your own API key here:  [Twilio SendGrid](https://sendgrid.com/))
      - `RATELIMIT_POLICY_NAME=fixed`
      - `RATELIMIT_POLICY_PERMIT_LIMIT=3`
      - `RATELIMIT_POLICY_WINDOW=60`
      - `RATELIMIT_POLICY_QUEUELIMIT=2`

4. Follow this link to create/re-create a local certificate for [Hosting ASP.NET Core images with Docker Compose over HTTPS](https://learn.microsoft.com/en-us/aspnet/core/security/docker-compose-https?view=aspnetcore-7.0"). Make sure you replace the `$CREDENTIAL_PLACEHOLDER$` portion of the command with the password used in the cfapinventoryview.env file (should be the one after the `ASPNETCORE_Kestrel__Certificates__Default_Password` key).
5. Edit the `EmailSender.cs` file, located in the Services folder, on line 34 and replace the current email `tjmxf@mailsac.com` with the email you used and verified while setting up your SendGrid API key.
6. Start Docker, if not already started
7. Copy the .env files you downloaded from step 2 into the CFAPInventoryView folder _(same folder level as the compose.yaml file)_.
8. Modify line endings in the import-data.sh script by:

   - PowerShell:
     - Ensure you are in the project directory
     - Run the following command: `` ((Get-Content import-data.sh) -join "`n") + "`n" | Set-Content -NoNewline import-data.sh ``
   - If you are using VS Code:
     - Open the import-data.sh file
     - Click on the **CRLF** button at the bottom right corner of the editor window
     - Select **LF** from the dropdown menu
     - Save the file
   - Visual Studio
     - Open the import-data.sh file
     - Click on the **File** menu
     - Select **Save As**
     - In the **Advanced Save Options** dialog box, select Unix under Line endings
     - Click on the **Save** button

9. Run the following command: `docker compose up --build`
10. When the setup completes and the containers are running, the site will be available at: https://localhost:8443
11. When you are done running the site, click in the terminal window used to launch the project and press Ctrl+C. This will gracefully stop the containers, or you can force it by pressing Ctrl+C again _(not recommended, unless absolutely necessary)_.
12. When you are finished, you can tear down the containers with the following command: `docker compose down`

_NOTE: The images and persistent storage volume will remain in Docker. If you add additional records that you want to keep through the site, you will want to leave the storage volume and can delete the images. Otherwise, you can delete both images and the storage volume through the Docker GUI for cleanup when you are finished._
