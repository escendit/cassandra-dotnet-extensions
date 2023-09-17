// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.Hosting.Cassandra.Tests.Fixtures;

using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Orleans.Runtime;

/// <summary>
/// Host Builder Fixture.
/// </summary>
public sealed class HostBuilderFixture
{
    /// <summary>
    /// Initializes a new instance of the <see cref="HostBuilderFixture"/> class.
    /// </summary>
    public HostBuilderFixture()
    {
    }

    /// <summary>
    /// Create Host Builder.
    /// </summary>
    /// <returns>The host builder.</returns>
    public IHostBuilder CreateHostBuilder()
    {
        return Host
            .CreateDefaultBuilder()
            .ConfigureServices(services => services
                .TryAddSingleton(typeof(IKeyedServiceCollection<,>), typeof(KeyedServiceCollection<,>)));
    }

    /// <summary>
    /// Create Service Provider.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>The service provider.</returns>
    public IServiceProvider CreateServiceProvider(string name)
    {
        return CreateHostBuilder()
            .AddCassandraClient(name, options => options.Endpoints.Add("localhost"))
            .Build()
            .Services;
    }
}
