// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Microsoft.Extensions.DependencyInjection;

using Cassandra;
using Escendit.Extensions.DependencyInjection.Cassandra;
using Escendit.Extensions.Hosting.Cassandra;
using Options;
using Orleans.Runtime;

/// <summary>
/// Service Collection Extensions.
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Add Cassandra Client As Default.
    /// </summary>
    /// <param name="services">The initial service collection.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClientAsDefault(
        this IServiceCollection services,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return services
            .AddCassandraClientOptionsAsDefault(configureOptions)
            .AddSingletonNamedService<ICluster>(CassandraClientOptions.DefaultOptionsKey, CassandraClientFactory.Create);
    }

    /// <summary>
    /// Add Cassandra Client As Default.
    /// </summary>
    /// <param name="services">The initial service collection.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClientAsDefault(
        this IServiceCollection services,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return services
            .AddCassandraClientOptionsAsDefault(configureOptions)
            .AddSingletonNamedService<ICluster>(CassandraClientOptions.DefaultOptionsKey, CassandraClientFactory.Create);
    }

    /// <summary>
    /// Add Cassandra Client.
    /// </summary>
    /// <param name="services">The initial service collection.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClient(
        this IServiceCollection services,
        string name,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return services
            .AddCassandraClientOptions(name, configureOptions)
            .AddSingletonNamedService<ICluster>(name, CassandraClientFactory.Create);
    }

    /// <summary>
    /// Add Cassandra Client.
    /// </summary>
    /// <param name="services">The initial service collection.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClient(
        this IServiceCollection services,
        string name,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return services
            .AddCassandraClientOptions(name, configureOptions)
            .AddSingletonNamedService<ICluster>(name, CassandraClientFactory.Create);
    }

    /// <summary>
    /// Add Cassandra Client From Options As Default..
    /// </summary>
    /// <param name="services">The initial service collection.</param>
    /// <param name="optionsName">The options name.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClientFromOptionsAsDefault(
        this IServiceCollection services,
        string optionsName)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(optionsName);
        return services
            .AddSingletonNamedService<ICluster>(
                CassandraClientOptions.DefaultOptionsKey,
                (serviceProvider, _) =>
                    CassandraClientFactory.Create(serviceProvider, optionsName));
    }

    /// <summary>
    /// Add Cassandra Client From Options.
    /// </summary>
    /// <param name="services">The initial service collection.</param>
    /// <param name="name">The name.</param>
    /// <param name="optionsName">The options name.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClientFromOptions(
        this IServiceCollection services,
        string name,
        string optionsName)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(optionsName);
        return services
            .AddSingletonNamedService<ICluster>(
                name,
                (serviceProvider, _) =>
                    CassandraClientFactory.Create(serviceProvider, optionsName));
    }
}
