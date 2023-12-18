# UpgradeAssistant
Automation of .NET Upgrade assistant with windows application and Power shell script

- Install .Net upgrade Assistant before using this tool
- You need to give the upgrade assistant exe path.
  To install
  >dotnet tool install --global upgrade-assistant --version 0.4.421302
  
  To Check version
  >upgrade-assistant --version
  

- Check the permissions of Powershell script execution in your local.
in powershell 
Get-ExecutionPolicy
if it is restricted,
Set-ExecutionPolicy RemoteSigned

.NET SDK- If requires install the versions suggested by upgrade assistant
