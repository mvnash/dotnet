-Microsoft.EntityFrameworkCore

-Microsoft.EntityFrameworkCore.Design

-Microsoft.EntityFrameworkCore.Tools

-Microsoft.EntityFrameworkCore.SqlServer

-Microsoft.EntityFrameworkCore.Proxies

Scaffold-DbContext -OutputDir Models 'Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind' Microsoft.EntityFrameworkCore.SqlServer


```
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind").UseLazyLoadingProxies();
```
