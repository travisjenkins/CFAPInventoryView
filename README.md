# CFAPInventoryView

### This containerized ASP.NET Core v7 MVC web app with a MSSQL Express database backend was created for the Columbia Foster and Adoption Program to track their product and iBelong Basket inventory status.

<p>This is a University of Missouri - Columbia (Mizzou) Capstone project for the following members:</p>
<ol>
  <li>Travis Jenkins</li>
  <li>Travis Kelley</li>
  <li>Nathan Kammerich</li>
  <li>Jeremiah Gantt</li>
</ol>

<hr />

# How do I get a local copy of this repo up and running?

By: Travis Jenkins

### Purpose:

Below, I outline the steps required to get a local copy of the project up and running for collaboration and demonstration purposes.

### Target Audience:

Team members and Capstone instructors/participants.

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
3. Obtain the required .env files [located here](https://mailmissouri-my.sharepoint.com/:f:/g/personal/tjmxf_umsystem_edu/EilDUU-lfZNKk3zPOGMImuEB4Q2TGN3c15Ta9ylyGTbn1w). _Only accessible by team members and Professor Gillian Maurer. If you require access to these files please contact Travis Jenkins or Professor Maurer._
4. Follow this link to create/re-create a local certificate for [Hosting ASP.NET Core images with Docker Compose over HTTPS](https://learn.microsoft.com/en-us/aspnet/core/security/docker-compose-https?view=aspnetcore-7.0"). Make sure you replace the `$CREDENTIAL_PLACEHOLDER$` portion of the command with the password provided in the cfapinventoryview.env file (downloaded in step 2 above, should be the one after the ASPNETCORE_Kestrel**Certificates**Default\_\_Password key).
5. Start Docker, if not already started
6. Copy the .env files you downloaded from step 2 into the CFAPInventoryView folder _(same folder level as the compose.yaml file)_.
7. Run the following command: `docker compose up --build`
8. When the setup completes and the containers are running, the site will be available at: https://localhost:8443
9. When you are done running the site, click in the terminal window used to launch the project and press Ctrl+C. This will gracefully stop the containers, or you can force it by pressing Ctrl+C again _(not recommended, unless absolutely necessary)_.
10. When you are finished, you can tear down the containers with the following command: `docker compose down`

_NOTE: The images and persistent storage volume will remain in Docker. If you add additional records that you want to keep through the site, you will want to leave the storage volume and can delete the images. Otherwise, you can delete both images and the storage volume through the Docker GUI for cleanup when you are finished._
