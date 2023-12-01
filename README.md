# CFAPInventoryView

### This containerized ASP.NET MVC web app with a SQL Express database backend was created for the Columbia Foster and Adoption Program to track their product and iBelong Basket inventory.

<p>This is a University of Missouri - Columbia (Mizzou) Capstone project for the following members:</p>
<ol>
  <li>Travis Jenkins</li>
  <li>Travis Kelley</li>
  <li>Nathan Kammerich</li>
  <li>Jeremiah Gantt</li>
  <li>Geno Dutzy</li>
</ol>

<hr />

# How do I get a local copy of this repo up and running?
By:  Travis Jenkins

### Purpose:

Below, I outline the steps required to get a local copy of the project up and running for collaboration and demonstration purposes. 


### Target Audience:

Team members and Capstone instructors/participants.

### Assumptions:

- [Git](https://github.com/git-guides/install-git) is already installed and configured.
- [Docker](https://docs.docker.com/get-docker/) is already installed and configured.
- (*Optional*) You already have Visual Studio or VS Code installed.

### Steps:

- Clone the repository:
  - [Clone with preferred shell](https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
  - [Clone with Visual Studio](https://learn.microsoft.com/en-us/visualstudio/version-control/git-clone-repository?view=vs-2022)
  - [Clone with VS Code](https://learn.microsoft.com/en-us/azure/developer/javascript/how-to/with-visual-studio-code/clone-github-repository?tabs=create-repo-command-palette%2Cinitialize-repo-activity-bar%2Ccreate-branch-command-palette%2Ccommit-changes-command-palette%2Cpush-command-palette)
- Ensure you have already created a local certificate for [Hosting ASP.NET Core images with Docker Compose over HTTPS](https://learn.microsoft.com/en-us/aspnet/core/security/docker-compose-https?view=aspnetcore-7.0").  If you don't remember the password you used then start by verifying the certificate is located at the required path with the same name listed on the site, then launch the site with Docker following the steps provided here and using the default values provided.  If that doesn't work, try creating another certificate with the repository name instead of the default aspnetapp.pfx shown on the site (i.e., cfapinventoryview.pfx) and modifying the required variables listed in the steps below.  (I didn't know the password and just ran the steps here with the password I created in the file, and it worked)
  - If necessary from the step above, modify the cfapinventoryview.env file's ASPNETCORE_Kestrel__Certificates__Default__Password variable to match the password you used for your certificate.  If you changed the certificate name you will also need to update the ASPNETCORE_Kestrel__Certificates__Default__Path variable to match the name of the certificate you created.
- Obtain the required .env files [located here](https://mailmissouri-my.sharepoint.com/:f:/g/personal/tjmxf_umsystem_edu/EilDUU-lfZNKk3zPOGMImuEB4Q2TGN3c15Ta9ylyGTbn1w). *Only accessible by team members and Professor Gillian Maurer.*
- Start Docker, if not already started
- Open your preferred shell to the folder where you copied the repository.
- Run the following command:  `docker compose up --build`
- When the setup completes and the containers are running, the site will be available at:  https://localhost:8443