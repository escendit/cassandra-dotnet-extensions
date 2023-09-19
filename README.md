# Cassandra Extensions

Cassandra &amp; ScyllaDB Client Extensions for .NET and Orleans allow you to easily configure
and manage Cassandra &amp; ScyllaDB connections withing your .NET and Orleans projects.

## Installation

Choose from three different type of installations:

### [ServiceCollection][service-collection] based

To install `Escendit.Extensions.DependencyInjection.Cassandra`, run the following command in the Package Manager Console:

```powershell
Install-Package Escendit.Extensions.DependencyInjection.Cassandra
```

### [HostBuilder][host-builder] based

To install `Escendit.Extensions.Hosting.Cassandra`, run the following command in the Package Manager Console:

```powershell
Install-Package Escendit.Extensions.Hosting.Cassandra
```

### [WebApplicationBuilder][web-application-builder] based

To install `Escendit.AspNetCore.Builder.Cassandra`, run the following command in the Package Manager Console:

```powershell
Install-Package Escendit.AspNetCore.Builder.Cassandra
```

## Contributing

If you'd like to contribute to [`cassandra-dotnet-extensions`][self],
please fork the repository and make changes as you'd like.
Pull requests are warmly welcome.

[self]: https://github.com/escendit/cassandra-dotnet-extensions
[service-collection]: src/DependencyInjection/Cassandra
[host-builder]: src/Hosting/Cassandra
[web-application-builder]: src/AspNetCore/Cassandra
