Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.SqlServer
EntityFrameworkCore.Proxies

Scaffold-DbContext -OutputDir Models 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind' Microsoft.EntityFrameworkCore.SqlServer
