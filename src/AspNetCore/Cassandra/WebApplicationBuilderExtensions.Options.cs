// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Microsoft.AspNetCore.Builder;

using Escendit.Extensions.Hosting.Cassandra;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

/// <summary>
/// Web Application Builder Extensions.
/// </summary>
public static partial class WebApplicationBuilderExtensions
{
/// <summary>
    /// Add Cassandra Client Options As Default.
    /// </summary>
    /// <param name="webApplicationBuilder">The initial web application builder.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated web application builder.</returns>
    public static WebApplicationBuilder AddCassandraClientOptionsAsDefault(
        this WebApplicationBuilder webApplicationBuilder,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(webApplicationBuilder);
        ArgumentNullException.ThrowIfNull(configureOptions);
        webApplicationBuilder
            .Host
            .AddCassandraClientOptionsAsDefault(configureOptions);
        return webApplicationBuilder;
    }

    /// <summary>
    /// Add Cassandra Client Options As Default.
    /// </summary>
    /// <param name="webApplicationBuilder">The web application builder.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated web application builder.</returns>
    public static WebApplicationBuilder AddCassandraClientOptionsAsDefault(
        this WebApplicationBuilder webApplicationBuilder,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(webApplicationBuilder);
        ArgumentNullException.ThrowIfNull(configureOptions);
        webApplicationBuilder
            .Host
            .AddCassandraClientOptionsAsDefault(configureOptions);
        return webApplicationBuilder;
    }

    /// <summary>
    /// Add Cassandra Client Options As Default.
    /// </summary>
    /// <param name="webApplicationBuilder">The web application builder.</param>
    /// <param name="configSectionPrefix">The config section prefix.</param>
    /// <returns>The updated web application builder.</returns>
    public static WebApplicationBuilder AddCassandraClientOptionsAsDefault(
        this WebApplicationBuilder webApplicationBuilder,
        string configSectionPrefix = OptionsDefaults.ClientKey)
    {
        ArgumentNullException.ThrowIfNull(webApplicationBuilder);
        ArgumentNullException.ThrowIfNull(configSectionPrefix);
        webApplicationBuilder
            .Host
            .AddCassandraClientOptionsAsDefault(configSectionPrefix);
        return webApplicationBuilder;
    }

    /// <summary>
    /// Add Cassandra Client Options.
    /// </summary>
    /// <param name="webApplicationBuilder">The initial web application builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated web application builder.</returns>
    public static WebApplicationBuilder AddCassandraClientOptions(
        this WebApplicationBuilder webApplicationBuilder,
        string name,
        Action<CassandraClientOptions> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(webApplicationBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        webApplicationBuilder
            .Host
            .AddCassandraClientOptions(name, configureOptions);
        return webApplicationBuilder;
    }

    /// <summary>
    /// Add Cassandra Client Options.
    /// </summary>
    /// <param name="webApplicationBuilder">The initial web application builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configureOptions">The configure options.</param>
    /// <returns>The updated web application builder.</returns>
    public static WebApplicationBuilder AddCassandraClientOptions(
        this WebApplicationBuilder webApplicationBuilder,
        string name,
        Action<OptionsBuilder<CassandraClientOptions>> configureOptions)
    {
        ArgumentNullException.ThrowIfNull(webApplicationBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configureOptions);
        webApplicationBuilder
            .Host
            .AddCassandraClientOptions(name, configureOptions);
        return webApplicationBuilder;
    }

    /// <summary>
    /// Add Cassandra Client Options.
    /// </summary>
    /// <param name="webApplicationBuilder">The initial web application builder.</param>
    /// <param name="name">The name.</param>
    /// <param name="configSectionPrefix">The config section prefix.</param>
    /// <returns>The updated web application builder.</returns>
    public static WebApplicationBuilder AddCassandraClientOptions(
        this WebApplicationBuilder webApplicationBuilder,
        string name,
        string configSectionPrefix = OptionsDefaults.ClientKey)
    {
        ArgumentNullException.ThrowIfNull(webApplicationBuilder);
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(configSectionPrefix);
        webApplicationBuilder
            .Host
            .AddCassandraClientOptions(name, configSectionPrefix);
        return webApplicationBuilder;
    }
}
