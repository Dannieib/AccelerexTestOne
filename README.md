# AccelerexTestOne
Part 1: How to run

**This a .Net Core API project. Please, 
a. install .net framework/.net bundle or package to your system.
b. Download Visual Studio IDE or after successful step A, open your COMMANDLINE
c. navigate to location where proj is, on the directory bar, type CMD, it'd auto-open CMD with path, Then Copy/Paste "dotnet restore" to help restore all packages
d. Then, type "dotnet run"
e. Once successfull: copy/paste this: https://localhost:5001/swagger/index.html or http://localhost:5000/swagger/index.html... Both works inasmuch a those specified ports are free.**

**if using IDE, ver simple, follow this link :https://www.c-sharpcorner.com/article/creating-web-api-project-asp-net-mvc/**




Part 2: Tell us what do you think about the data format. Is the current JSON structure the best
way to store that kind of data or can you come up with a better version?


Solution: No, not the right way. Atleast, might be ok but not flexible. 

Something like this would be simple and flexible

**public class Days
{
  public string Day {get;set;} //Monday,Tuesday,Wednesday ...
  public int Hours {get;set;}
  public string value {get;set;}
}**

When passing into a function/method, could be:
**public void Type MethodName (List<Days> days)
{
}**
