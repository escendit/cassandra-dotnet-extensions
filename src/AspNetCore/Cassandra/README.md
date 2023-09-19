# Escendit.AspNetCore.Builder.Cassandra

`Escendit.AspNetCore.Builder.Cassandra` is a NuGet package that provides the ability to register
`ICluster`. This package is suitable for web application builder type registrations. For ASP.NET Core Web Applications.

## Installation

To install `Escendit.AspNetCore.Builder.Cassandra`, run the following command in the Package Manager Console:

```powershell
Install-Package Escendit.AspNetCore.Builder.Cassandra
```

## Usage

### Register Options

#### Default
```csharp
WebApplication
    .CreateBuilder()
    .AddCassandraClientOptionsAsDefault(...);
```

#### Named

```csharp
WebApplication
    .CreateBuilder()
    .AddCassandraClientOptions("name", ...);
```

### Register Client

#### Default

```csharp
WebApplication
    .CreateBuilder()
    .AddCassandraClientAsDefault(...);
```

#### Default From Options

```csharp
WebApplication
    .CreateBuilder()
    .AddCassandraClientFromOptionsAsDefault("options name");
```

#### Named

```csharp
WebApplication
    .CreateBuilder()
    .AddCassandraClient("name", ...);
```

#### From Options

```csharp
WebApplication
    .CreateBuilder()
    .AddCassandraClientFromOptions("name", "options name");
```

### Consume Client

You can consume service with `IServiceProvider`, required variant exists as-well.

#### Default

```csharp
serviceProvider
    .GetCassandraClient();
```

#### Named

```csharp
serviceProvider
    .GetCassandraClient("name");
```

## Contributing

If you'd like to contribute to [`cassandra-dotnet-extensions`][self],
please fork the repository and make changes as you'd like.
Pull requests are warmly welcome.

[self]: https://github.com/escendit/cassandra-dotnet-extensions
