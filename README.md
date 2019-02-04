# AspNetEntityFrameworkPostgresDocker
This sample project demonstrate how to build ASP.Net Web API Core application with Entity Framework Core & PostgreSQL using Docker Compose. Web API and PostgreSQL runs in Docker container.

# Projects
**AspNetEFCorePostgresDocker**
 - Provides web interface to get Blogs from the database. Uses
 - Npgsql.EntityFrameworkCore.PostgreSQL nuget package to connect to   
 - PostgresSQL Contains sql script to intialize the postgresql database
 
 **docker-compose.yml**
 - Creates containers for WebAPI and PostgresSQL 
 - Populates database with sample data

# Build and Test
In VS2017, run the application using **Docker Compose**. 
In the browser navigate to "http://localhost:5000/swagger/index.html", using **SwaggerUI** we can get Blogs from the PostgreSQL.
