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
    /// Add Cassandra Client As Default.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientAsDefault(
        this IHostBuilder hostBuilder,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClientAsDefault(configureOptions));
    }

    /// <summary>
    /// Add Cassandra Client As Default.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientAsDefault(
        this IHostBuilder hostBuilder,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClientAsDefault(configureOptions));
    }

    /// <summary>
    /// Add Cassandra Client As Default.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="configSectionPrefix">The config section prefix.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientAsDefault(
        this IHostBuilder hostBuilder,
        string configSectionPrefix = OptionsDefaults.ClientKey)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(configSectionPrefix);
        return hostBuilder
            .AddCassandraClientAsDefault(options => options
                .BindConfiguration($"{configSectionPrefix}:{options.Name}"));
    }

    /// <summary>
    /// Add Cassandra Client.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClient(
        this IHostBuilder hostBuilder,
        string name,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClient(name, configureOptions));
    }

    /// <summary>
    /// Add Cassandra Client.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClient(
        this IHostBuilder hostBuilder,
        string name,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClient(name, configureOptions));
    }

    /// <summary>
    /// Add Cassandra Client.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configSectionPrefix">The config section prefix.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClient(
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

    /// <summary>
    /// Add Cassandra Client From Options As Default..
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="optionsName">The options name.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientFromOptionsAsDefault(
        this IHostBuilder hostBuilder,
        string optionsName)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(optionsName);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClientFromOptionsAsDefault(optionsName));
    }

    /// <summary>
    /// Add Cassandra Client From Options.
    /// </summary>
    /// <param name="hostBuilder">The initial host builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="optionsName">The options name.</param>
    /// <returns>The updated host builder.</returns>
    public static IHostBuilder AddCassandraClientFromOptions(
        this IHostBuilder hostBuilder,
        string name,
        string optionsName)
    {
        ArgumentNullException.ThrowIfNull(hostBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(optionsName);
        return hostBuilder
            .ConfigureServices(services => services
                .AddCassandraClientFromOptions(name, optionsName));
    }
}
