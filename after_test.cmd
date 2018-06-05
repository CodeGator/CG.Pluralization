%userprofile%\.nuget\packages\OpenCover\4.6.519\tools\OpenCover.Console.exe -register:user -filter:"+[*]* -[Moq*]* -[System*]*" -target:"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\MSTest.exe" -targetargs:"/testcontainer:.\CG.Pluralization.Tests\bin\Debug\net461\CG.Pluralization.Tests.dll" -output:coverage.xml

%userprofile%\.nuget\packages\coveralls.io\1.4.2\tools\coveralls.net.exe --opencover coverage.xml -r %COVERALLS_REPO_TOKEN%
