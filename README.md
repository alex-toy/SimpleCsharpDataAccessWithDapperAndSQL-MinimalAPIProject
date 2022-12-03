# Simple Csharp Data Access With Dapper And SQL - Minimal API Project

Minimal APIs are now the default in .NET 6. In this project, we will cover setting up a SQL database and configuring Dapper for easy data access. We will set up a simple but full CRUD data layer so that when we build our minimal API, we can concentrate on the API itself and not the setup. 


## Create project

<img src="/pictures/create_project.png" title="create project"  width="400">


## Create sql server

<img src="/pictures/create_sql_server.png" title="create sql server"  width="400"> 


## Add Table

<img src="/pictures/sql.png" title="sql"  width="600"> 


## Add Stored Procedures

<img src="/pictures/stored_procedure1.png" title="stored procedure"  width="600">
<img src="/pictures/stored_procedure2.png" title="stored procedure"  width="600">
<img src="/pictures/stored_procedure3.png" title="stored procedure"  width="600">
<img src="/pictures/stored_procedure4.png" title="stored procedure"  width="600">
<img src="/pictures/stored_procedure5.png" title="stored procedure"  width="600">


## Add Post-Deployment Script 

<img src="/pictures/post_deployment_script.png" title="post deployment script"  width="600">
<img src="/pictures/post_deployment_script2.png" title="post deployment script"  width="600">

Then click *Save Profile As*. That should create a *publish.xml* file. Double click on it to publish again.

<img src="/pictures/post_deployment_script4.png" title="post deployment script"  width="600">

## Create a SQL Server Object Explorer

<img src="/pictures/sql_server_object_explorer.png" title="sql server object explorer"  width="500">
<img src="/pictures/sql_server_object_explorer2.png" title="sql server object explorer"  width="400">

## Add editor config

<img src="/pictures/editor_config.png" title="editor config"  width="500">

## Add Nuget Packages
```
Install-Package Dapper
Install-Package System.Data.SqlClient
Install-Package Microsoft.Extensions.Configuration.Abstraction
```

## Get connection string

Copy it from the properties :
<img src="/pictures/connection_string.png" title="connection string"  width="800">


