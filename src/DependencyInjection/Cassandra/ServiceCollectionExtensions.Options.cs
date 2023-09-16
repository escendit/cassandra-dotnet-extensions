// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Microsoft.Extensions.DependencyInjection;

using Escendit.Extensions.Hosting.Cassandra;
using Options;

/// <summary>
/// Service Collection Extensions.
/// </summary>
public static partial class ServiceCollectionExtensions
{
    /// <summary>
    /// Add Cassandra Client Options As Default.
    /// </summary>
    /// <param name="services">The initial services.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClientOptionsAsDefault(
        this IServiceCollection services,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configureOptions);
        services
            .AddOptions<CassandraClientOptions>(CassandraClientOptions.DefaultOptionsKey)
            .Configure(configureOptions);
        return services;
    }

    /// <summary>
    /// Add Cassandra Client Options As Default.
    /// </summary>
    /// <param name="services">The initial services.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClientOptionsAsDefault(
        this IServiceCollection services,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configureOptions);
        configureOptions
            .Invoke(services
                .AddOptions<CassandraClientOptions>(CassandraClientOptions.DefaultOptionsKey));
        return services;
    }

    /// <summary>
    /// Add Cassandra Client Options.
    /// </summary>
    /// <param name="services">The initial service collection.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClientOptions(
        this IServiceCollection services,
        string name,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        services
            .AddOptions<CassandraClientOptions>(name)
            .Configure(configureOptions);
        return services;
    }

    /// <summary>
    /// Add Cassandra Client Options.
    /// </summary>
    /// <param name="services">The initial service collection.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated service collection.</returns>
    public static IServiceCollection AddCassandraClientOptions(
        this IServiceCollection services,
        string name,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        configureOptions
            .Invoke(services
                .AddOptions<CassandraClientOptions>(name));
        return services;
    }
}
