# :fire: Clean Architecture Implementation Template for .NET apps :white_check_mark:
Pure and simple implementation following the Clean Architecture Principles, decoupled from frameworks and technology details. Use Cases as central organizing component and smaller components developed and tested in isolation.

### :arrow_forward: Running from source

```
<<<<<<< HEAD

## :lemon: Compiling from source

To run Manga from source, clone this repository to your machine, compile and test it:

```sh
git clone https://github.com/ivanpaulovich/clean-architecture-manga.git
cd clean-architecture-manga/manga/build
./build.sh
=======
$ dotnet run --project "source/Manga.WebApi/Manga.WebApi.csproj"
>>>>>>> 82c4eeb... Review
```

### :checkered_flag: Development Environment

* MacOS Catalina :apple:
* Visual Studio Code :heart:
* [.NET Core SDK 2.2](https://www.microsoft.com/net/download/dotnet-core/2.2)
* Docker :whale:
* SQL Server

## :floppy_disk: Setup Database

### Setup SQL Server in Docker

<details><summary>Install SQL Server</summary>
<p>

To spin up a SQL Server in a docker container using the connection string `Server=localhost;User Id=sa;Password=<YourNewStrong!Passw0rd>;` run the following command:

```sh
$ ./source/scripts/sql-docker-up.sh
```

</p>
</details>

<details><summary>Add Migration</summary>
<p>

Run the EF Tool to add a migration to the `Manga.Infrastructure` project.

```sh
$ dotnet ef migrations add "InitialCreate" -o "EntityFrameworkDataAccess/Migrations" --project source/Manga.Infrastructure --startup-project source/Manga.WebApi
```

</p>
</details>

<details><summary>Update the Database</summary>
<p>

Generate tables and seed the database via Entity Framework Tool:

```sh
dotnet ef database update --project source/Manga.Infrastructure --startup-project source/Manga.WebApi
```

</p>
</details>

## :telephone: Support and Issues

I am happy to clarify the decisions I made in this project through the [Issues tab](https://github.com/ivanpaulovich/clean-architecture-manga/issues) so everyone will take benefit from the discussions.
