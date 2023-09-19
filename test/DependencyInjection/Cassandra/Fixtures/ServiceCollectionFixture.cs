// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.DependencyInjection.Cassandra.Tests.Fixtures;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Orleans.Runtime;

/// <summary>
/// Service Collection Fixture.
/// </summary>
public sealed class ServiceCollectionFixture
{
    /// <summary>
    /// Gets the service collection.
    /// </summary>
    /// <returns>The service collection.</returns>
    public IServiceCollection CreateServiceCollection()
    {
        var services = new ServiceCollection();
        services.TryAddSingleton(typeof(IKeyedServiceCollection<,>), typeof(KeyedServiceCollection<,>));
        return services;
    }

    /// <summary>
    /// Create the service provider.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>The service provider.</returns>
    public IServiceProvider CreateServiceProvider(string name)
    {
        var services = CreateServiceCollection();
        services.AddCassandraClient(name, options => options.Endpoints.Add("localhost"));
        return services.BuildServiceProvider();
    }
}
