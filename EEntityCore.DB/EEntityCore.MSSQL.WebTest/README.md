Add this to your csproject

+ Prevent auto addition of new generated files

  <ItemGroup>
     <None Remove="DBEntities\DatabaseSchema.*" />
     <Compile Remove="DBEntities\DatabaseSchema.*\**" />
     <EmbeddedResource Remove="DBEntities\DatabaseSchema.*\**" />
     <None Remove="DBEntities\DatabaseSchema.*\**" />
  </ItemGroup>



  + Create A [ DBEntities ] or target folder in your app.
  + You can add this ini file if needed for quick generation
  
  + [ DatabaseSchema.ini ]

  <pre>

[GENERAL]
DatabaseClassGeneratedCount=88
CodingLanguage=C#.NETCore
AssemblyName=EWebFrameworkCore.Dev
DestinationFolder=C:\DATA-DRIVE\Repos\github\eaproc\EWebFrameworkCore\EWebFrameworkCore.Dev\DBEntities
SQLServerDatabaseName=SalesSCADWARE
SQLServerName=localhost\SQLSERVER2016
SQLServerAuthenticationType=SQL Server Authentication
SQLServerWebVersion=True
SQLServerUserName=sa
SQLServerUserPassword=
SQLServerPortNumber=

  </pre>


  + Add Nugget Package 
  - Microsoft.Data.SqlClient


