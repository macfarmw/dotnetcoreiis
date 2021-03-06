# dotnetcoreiis
A sample project to try running and debugging a dotnet core app with IIS Express in VS Code. I am trying to match what Visual Studio 2017 does.

## Giving up on IIS and dotnet core with VS Code.
It turns out to be a bad idea to try and run/debug with IIS and dotnet core. Visual Studio 2017 can do it but that product has a complex setup that makes it work. It's better to run debug with Kestral and use IIS only on the web server. Rick's blog was excellent for how to set this up.

[Publishing and Running ASP.NET Core Applications with IIS](https://weblog.west-wind.com/posts/2016/Jun/06/Publishing-and-Running-ASPNET-Core-Applications-with-IIS) - Rick Strahl

## To Do
I got as far as running IIS Express and pointing the Web.Config at the dll for this application.
When I attempt to run it the AspNetCoreModule fails with Bad Gateway. 
Clue: Most examples appear to publish the core app and then run it behind IIS.

## Other links found along the way
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/aspnet-core-module?tabs=aspnetcore1x

http://odetocode.com/blogs/scott/archive/2016/10/25/asp-net-core-and-the-enterprise-part-2-hosting.aspx

A Web.config file is needed to launch an ASP.NET core app behind IIS Express.
https://docs.microsoft.com/en-us/aspnet/core/hosting/aspnet-core-module

More details about setting up the web server to host ASP.NET core applications.
https://docs.microsoft.com/en-us/aspnet/core/publishing/iis

