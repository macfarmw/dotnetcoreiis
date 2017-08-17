REM "C:\Program Files (x86)\IIS Express\iisexpress.exe"  
REM /config:"C:\TFS\DRILQUIP_2456764.0\Trunk\WebApplication1\.vs\config\applicationhost.config"\
REM /site:"WebApplication1" /apppool:"Clr4IntegratedAppPool"

REM "C:\Program Files\dotnet\dotnet.exe" 
REM exec "C:\TFS\DRILQUIP_2456764.0\Trunk\WebApplication1\WebApplication1\bin\Debug\netcoreapp1.1\WebApplication1.dll"

iisexpress /config:"C:\github\dotnetcoreiis\IIS\applicationhost.config" /site:"dotnetcoreiis" /trace:"info"
ECHO LAUNCHER_PATH: %LAUNCHER_PATH%