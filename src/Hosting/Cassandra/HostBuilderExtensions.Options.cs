// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Microsoft.Extensions.Hosting;

using DependencyInjection;
using Escendit.Extensions.Hosting.Cassandra;
using Options;

/// <summary>
/// Host Builder Extensions.
/// </summary>
public static partial class HostBuilderExtensions
{
    /// <summary>
    /// Add Cassandra Client Options As Default.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientOptionsAsDefault(
        this IHostBuilder hostBuilder,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClientOptionsAsDefault(configureOptions));
    }

    /// <summary>
    /// Add Cassandra Client Options As Default.
    /// </summary>
    /// <param name="hostBuilder">The host builder.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientOptionsAsDefault(
        this IHostBuilder hostBuilder,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClientOptionsAsDefault(configureOptions));
    }

    /// <summary>
    /// Add Cassandra Client Options As Default.
    /// </summary>
    /// <param name="hostBuilder">The host builder.</param>
    /// <param name="configSectionPrefix">The config section prefix.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientOptionsAsDefault(
        this IHostBuilder hostBuilder,
        string configSectionPrefix = OptionsDefaults.ClientKey)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(configSectionPrefix);
        return hostBuilder
            .AddCassandraClientOptionsAsDefault(options => options
                .BindConfiguration($"{configSectionPrefix}:{options.Name}"));
    }

    /// <summary>
    /// Add Cassandra Client Options.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientOptions(
        this IHostBuilder hostBuilder,
        string name,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClientOptions(name, configureOptions));
    }

    /// <summary>
    /// Add Cassandra Client Options.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientOptions(
        this IHostBuilder hostBuilder,
        string name,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClientOptions(name, configureOptions));
    }

    /// <summary>
    /// Add Cassandra Client Options.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configSectionPrefix">The config section prefix.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientOptions(
        this IHostBuilder hostBuilder,
        string name,
        string configSectionPrefix = OptionsDefaults.ClientKey)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configSectionPrefix);
        return hostBuilder
            .AddCassandraClient(name, options => options
                .BindConfiguration($"{configSectionPrefix}:{options.Name}"));
    }
}
