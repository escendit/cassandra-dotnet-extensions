// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

#if NET7_0

namespace System;

using Cassandra;
using Escendit.Extensions.Hosting.Cassandra;
using Orleans.Runtime;

/// <summary>
/// Service Provider Extensions.
/// </summary>
public static class ServiceProviderExtensions
{
    /// <summary>
    /// Get Cassandra Client.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    /// <returns>The cassandra client.</returns>
    public static ICluster GetCassandraClient(this IServiceProvider serviceProvider)
    {
        return serviceProvider
            .GetServiceByName<ICluster>(CassandraClientOptions.DefaultOptionsKey);
    }

    /// <summary>
    /// Get Cassandra Client.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    /// <param name="name">The name.</param>
    /// <returns>The cassandra client.</returns>
    public static ICluster GetCassandraClient(this IServiceProvider serviceProvider, string name)
    {
        return serviceProvider
            .GetServiceByName<ICluster>(name);
    }

    /// <summary>
    /// Get Required Cassandra Client.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    /// <returns>The cassandra client.</returns>
    public static ICluster GetRequiredCassandraClient(this IServiceProvider serviceProvider)
    {
        return serviceProvider
            .GetRequiredServiceByName<ICluster>(CassandraClientOptions.DefaultOptionsKey);
    }

    /// <summary>
    /// Get Required Cassandra Client.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    /// <param name="name">The name.</param>
    /// <returns>The required cassandra client.</returns>
    public static ICluster GetRequiredCassandraClient(this IServiceProvider serviceProvider, string name)
    {
        return serviceProvider
            .GetRequiredServiceByName<ICluster>(name);
    }
}

#endif
