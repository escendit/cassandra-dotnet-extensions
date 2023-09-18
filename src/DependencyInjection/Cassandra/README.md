# Escendit.Extensions.DependencyInjection.Cassandra

`Escendit.Extensions.DependencyInjection.Cassandra` is a NuGet package that provides the ability to register
`ICluster`. This package is suitable for service collection type registrations.

## Installation

To install `Escendit.Extensions.DependencyInjection.Cassandra`, run the following command in the Package Manager Console:

```powershell
Install-Package Escendit.Extensions.DependencyInjection.Cassandra
```

## Usage

### Register Options

#### Default
```csharp
new ServiceCollection()
    .AddCassandraClientOptionsAsDefault(...);
```

#### Named

```csharp
new ServiceCollection()
    .AddCassandraClientOptions("name", ...);
```

### Register Client

#### Default

```csharp
new ServiceCollection()
    .AddCassandraClientAsDefault(...);
```

#### Default From Options

```csharp
new ServiceCollection()
    .AddCassandraClientFromOptionsAsDefault("options name");
```

#### Named

```csharp
new ServiceCollection()
    .AddCassandraClient("name", ...);
```

#### From Options

```csharp
new ServiceCollection()
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
