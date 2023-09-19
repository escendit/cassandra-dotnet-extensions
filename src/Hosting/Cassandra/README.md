# Escendit.Extensions.Hosting.Cassandra

`Escendit.Extensions.Hosting.Cassandra` is a NuGet package that provides the ability to register
`ICluster`. This package is suitable for host builder type registrations. For .NET Workers &amp; Orleans Silos.

## Installation

To install `Escendit.Extensions.Hosting.Cassandra`, run the following command in the Package Manager Console:

```powershell
Install-Package Escendit.Extensions.Hosting.Cassandra
```

## Usage

### Register Options

#### Default
```csharp
Host
    .CreateDefaultBuilder()
    .AddCassandraClientOptionsAsDefault(...);
```

#### Named

```csharp
Host
    .CreateDefaultBuilder()
    .AddCassandraClientOptions("name", ...);
```

### Register Client

#### Default

```csharp
Host
    .CreateDefaultBuilder()
    .AddCassandraClientAsDefault(...);
```

#### Default From Options

```csharp
Host
    .CreateDefaultBuilder()
    .AddCassandraClientFromOptionsAsDefault("options name");
```

#### Named

```csharp
Host
    .CreateDefaultBuilder()
    .AddCassandraClient("name", ...);
```

#### From Options

```csharp
Host
    .CreateDefaultBuilder()
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
