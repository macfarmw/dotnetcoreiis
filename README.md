# dotnetcoreiis

## To Do
I got as far as running IIS Express and pointing the Web.Config at the dll for this application.
When I attempt to run it the AspNetCoreModule fails with Bad Gateway. 
Clue: Most examples appear to publish the core app and then run it behind IIS.

## Setting up IIS Express and ASP.Net Core
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/servers/aspnet-core-module?tabs=aspnetcore1x

http://odetocode.com/blogs/scott/archive/2016/10/25/asp-net-core-and-the-enterprise-part-2-hosting.aspx

A Web.config file is needed to launch an ASP.NET core app behind IIS Express.
https://docs.microsoft.com/en-us/aspnet/core/hosting/aspnet-core-module

More details about setting up the web server to host ASP.NET core applications.
https://docs.microsoft.com/en-us/aspnet/core/publishing/iis

Rick Strahl blog
https://weblog.west-wind.com/posts/2016/Jun/06/Publishing-and-Running-ASPNET-Core-Applications-with-IIS
