// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.DependencyInjection.Cassandra;

using System.Collections.ObjectModel;
using Escendit.Extensions.Hosting.Cassandra;
using global::Cassandra;
using global::Cassandra.DataStax.Graph;
using global::Cassandra.Serialization;
using Orleans;

/// <summary>
/// Cassandra Client Factory.
/// </summary>
internal static class CassandraClientFactory
{
    /// <summary>
    /// Create.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    /// <param name="name">The name.</param>
    /// <returns>The cluster.</returns>
    public static Cluster Create(IServiceProvider serviceProvider, string name)
    {
        var options = serviceProvider.GetOptionsByName<CassandraClientOptions>(name);
        return Create(options);
    }

    private static Cluster Create(CassandraClientOptions options)
    {
        var cluster = Cluster.Builder();
        cluster.SetEndpoints(options.Endpoints);
        cluster.SetCompressionType(options.CompressionType);
        cluster.SetMaxProtocolVersion(options.MaxProtocolVersion);
        cluster.SetCredentials(options.Credentials);
        cluster.SetMetricOptions(options.MetricOptions);
        cluster.SetPort(options.Port);
        cluster.SetAddressTranslator(options.AddressTranslator);
        cluster.SetApplicationName(options.ApplicationName);
        cluster.SetApplicationVersion(options.ApplicationVersion);
        cluster.SetAuthenticationProvider(options.AuthenticationProvider);
        cluster.SetClusterId(options.ClusterId);
        cluster.SetConnectionString(options.ConnectionString);
        cluster.SetCompressor(options.Compressor);
        cluster.SetDefaultKeyspace(options.DefaultKeyspace);
        cluster.SetExecutionProfileOptionsFactory(options.ExecutionProfileOptionsFactory);
        cluster.SetGraphOptions(options.GraphOptions);
        cluster.SetEnableMonitorReporting(options.EnableMonitorReporting);
        cluster.SetEnableNoCompactMode(options.EnableNoCompactMode);
        cluster.SetPoolingOptions(options.PoolingOptions);
        cluster.SetQueryOptions(options.QueryOptions);
        cluster.SetQueryTimeout(options.QueryTimeout);
        cluster.SetReconnectionPolicy(options.ReconnectionPolicy);
        cluster.SetRetryPolicy(options.RetryPolicy);
        cluster.SetSessionName(options.SessionName);
        cluster.SetSocketOptions(options.SocketOptions);
        cluster.SetTimestampGenerator(options.TimestampGenerator);
        cluster.SetTypeSerializerDefinitions(options.TypeSerializerDefinitions);
        cluster.SetEnableBetaProtocolVersions(options.EnableBetaProtocolVersions);
        cluster.SetLoadBalancingPolicy(options.LoadBalancingPolicy);
        cluster.SetMetadataSyncOptions(options.MetadataSyncOptions);
        cluster.SetEnableRowSetBuffering(options.EnableRowSetBuffering);
        cluster.SetSpeculativeExecutionPolicy(options.SpeculativeExecutionPolicy);
        cluster.SetEnableTransportLayerSecurity(options.EnableTransportLayerSecurity);
        cluster.SetEnableUnresolvedContactPoints(options.EnableUnresolvedContactPoints);
        cluster.SetCloudSecureConnectionBundle(options.CloudSecureConnectionBundle);
        cluster.SetMaxSchemaAgreementWaitSeconds(options.MaxSchemaAgreementWaitSeconds);
        return cluster.Build();
    }

    private static void SetEndpoints(this Builder cluster, Collection<string> endpoints)
    {
        if (endpoints.Any())
        {
            cluster.AddContactPoints(endpoints);
        }
    }

    private static void SetCompressionType(this Builder cluster, CompressionType? compressionType)
    {
        if (compressionType.HasValue)
        {
            cluster.WithCompression(compressionType.Value);
        }
    }

    private static void SetMaxProtocolVersion(this Builder cluster, ProtocolVersion? protocolVersion)
    {
        if (protocolVersion.HasValue)
        {
            cluster.WithMaxProtocolVersion(protocolVersion.Value);
        }
    }

    private static void SetCredentials(this Builder cluster, Credentials? credentials)
    {
        if (credentials is not null)
        {
            cluster.WithCredentials(credentials.Username, credentials.Password);
        }
    }

    private static void SetMetricOptions(this Builder cluster, MetricOptions? metricOptions)
    {
        if (metricOptions is null)
        {
            return;
        }

        if (metricOptions.DriverMetricsOptions is null)
        {
            cluster.WithMetrics(metricOptions.DriverMetricsProvider);
        }
        else
        {
            cluster.WithMetrics(
                metricOptions.DriverMetricsProvider,
                metricOptions.DriverMetricsOptions);
        }
    }

    private static void SetPort(this Builder cluster, int? port)
    {
        if (port.HasValue)
        {
            cluster.WithPort(port.Value);
        }
    }

    private static void SetAddressTranslator(this Builder cluster, IAddressTranslator? addressTranslator)
    {
        if (addressTranslator is not null)
        {
            cluster.WithAddressTranslator(addressTranslator);
        }
    }

    private static void SetApplicationName(this Builder cluster, string? applicationName)
    {
        if (!string.IsNullOrEmpty(applicationName))
        {
            cluster.WithApplicationName(applicationName);
        }
    }

    private static void SetApplicationVersion(this Builder cluster, string? applicationVersion)
    {
        if (!string.IsNullOrEmpty(applicationVersion))
        {
            cluster.WithApplicationVersion(applicationVersion);
        }
    }

    private static void SetAuthenticationProvider(this Builder cluster, IAuthProvider? authenticationProvider)
    {
        if (authenticationProvider is not null)
        {
            cluster.WithAuthProvider(authenticationProvider);
        }
    }

    private static void SetClusterId(this Builder cluster, Guid? clusterId)
    {
        if (clusterId.HasValue)
        {
            cluster.WithClusterId(clusterId.Value);
        }
    }

    private static void SetConnectionString(this Builder cluster, string? connectionString)
    {
        if (!string.IsNullOrEmpty(connectionString))
        {
            cluster.WithConnectionString(connectionString);
        }
    }

    private static void SetCompressor(this Builder cluster, IFrameCompressor? compressor)
    {
        if (compressor is not null)
        {
            cluster.WithCustomCompressor(compressor);
        }
    }

    private static void SetDefaultKeyspace(this Builder cluster, string? defaultKeyspace)
    {
        if (!string.IsNullOrEmpty(defaultKeyspace))
        {
            cluster.WithDefaultKeyspace(defaultKeyspace);
        }
    }

    private static void SetExecutionProfileOptionsFactory(
        this Builder cluster,
        Action<IExecutionProfileOptions>? executionProfileOptionsFactory)
    {
        if (executionProfileOptionsFactory is not null)
        {
            cluster.WithExecutionProfiles(executionProfileOptionsFactory);
        }
    }

    private static void SetGraphOptions(this Builder cluster, GraphOptions? graphOptions)
    {
        if (graphOptions is not null)
        {
            cluster.WithGraphOptions(graphOptions);
        }
    }

    private static void SetEnableMonitorReporting(this Builder cluster, bool? enableMonitorReporting)
    {
        if (enableMonitorReporting.HasValue)
        {
            cluster.WithMonitorReporting(enableMonitorReporting.Value);
        }
    }

    private static void SetEnableNoCompactMode(this Builder cluster, bool? enableNoCompactMode)
    {
        if (enableNoCompactMode.GetValueOrDefault(false))
        {
            cluster.WithNoCompact();
        }
    }

    private static void SetPoolingOptions(this Builder cluster, PoolingOptions? poolingOptions)
    {
        if (poolingOptions is not null)
        {
            cluster.WithPoolingOptions(poolingOptions);
        }
    }

    private static void SetQueryOptions(this Builder cluster, QueryOptions? queryOptions)
    {
        if (queryOptions is not null)
        {
            cluster.WithQueryOptions(queryOptions);
        }
    }

    private static void SetQueryTimeout(this Builder cluster, int? queryTimeout)
    {
        if (queryTimeout.HasValue)
        {
            cluster.WithQueryTimeout(queryTimeout.Value);
        }
    }

    private static void SetReconnectionPolicy(this Builder cluster, IReconnectionPolicy? reconnectionPolicy)
    {
        if (reconnectionPolicy is not null)
        {
            cluster.WithReconnectionPolicy(reconnectionPolicy);
        }
    }

    private static void SetRetryPolicy(this Builder cluster, IRetryPolicy? retryPolicy)
    {
        if (retryPolicy is not null)
        {
            cluster.WithRetryPolicy(retryPolicy);
        }
    }

    private static void SetSessionName(this Builder cluster, string? sessionName)
    {
        if (!string.IsNullOrEmpty(sessionName))
        {
            cluster.WithSessionName(sessionName);
        }
    }

    private static void SetSocketOptions(this Builder cluster, SocketOptions? socketOptions)
    {
        if (socketOptions is not null)
        {
            cluster.WithSocketOptions(socketOptions);
        }
    }

    private static void SetTimestampGenerator(this Builder cluster, ITimestampGenerator? timestampGenerator)
    {
        if (timestampGenerator is not null)
        {
            cluster.WithTimestampGenerator(timestampGenerator);
        }
    }

    private static void SetTypeSerializerDefinitions(
        this Builder cluster,
        TypeSerializerDefinitions? typeSerializerDefinitions)
    {
        if (typeSerializerDefinitions is not null)
        {
            cluster.WithTypeSerializers(typeSerializerDefinitions);
        }
    }

    private static void SetEnableBetaProtocolVersions(this Builder cluster, bool? enableBetaProtocolVersions)
    {
        if (enableBetaProtocolVersions.GetValueOrDefault(false))
        {
            cluster.WithBetaProtocolVersions();
        }
    }

    private static void SetLoadBalancingPolicy(this Builder cluster, ILoadBalancingPolicy? loadBalancingPolicy)
    {
        if (loadBalancingPolicy is not null)
        {
            cluster.WithLoadBalancingPolicy(loadBalancingPolicy);
        }
    }

    private static void SetMetadataSyncOptions(this Builder cluster, MetadataSyncOptions? metadataSyncOptions)
    {
        if (metadataSyncOptions is not null)
        {
            cluster.WithMetadataSyncOptions(metadataSyncOptions);
        }
    }

    private static void SetEnableRowSetBuffering(this Builder cluster, bool? enableRowSetBuffering)
    {
        if (!enableRowSetBuffering.GetValueOrDefault(false))
        {
            cluster.WithoutRowSetBuffering();
        }
    }

    private static void SetSpeculativeExecutionPolicy(
        this Builder cluster,
        ISpeculativeExecutionPolicy? speculativeExecutionPolicy)
    {
        if (speculativeExecutionPolicy is not null)
        {
            cluster.WithSpeculativeExecutionPolicy(speculativeExecutionPolicy);
        }
    }

    private static void SetEnableTransportLayerSecurity(this Builder cluster, bool? enableTransportLayerSecurity)
    {
        if (enableTransportLayerSecurity.GetValueOrDefault(false))
        {
            cluster.WithSSL();
        }
    }

    private static void SetEnableUnresolvedContactPoints(this Builder cluster, bool? enableUnresolvedContactPoints)
    {
        if (enableUnresolvedContactPoints.HasValue)
        {
            cluster.WithUnresolvedContactPoints(enableUnresolvedContactPoints.Value);
        }
    }

    private static void SetCloudSecureConnectionBundle(this Builder cluster, string? cloudSecureConnectionBundle)
    {
        if (!string.IsNullOrEmpty(cloudSecureConnectionBundle))
        {
            cluster.WithCloudSecureConnectionBundle(cloudSecureConnectionBundle);
        }
    }

    private static void SetMaxSchemaAgreementWaitSeconds(this Builder cluster, int? maxSchemaAgreementWaitSeconds)
    {
        if (maxSchemaAgreementWaitSeconds.HasValue)
        {
            cluster.WithMaxSchemaAgreementWaitSeconds(maxSchemaAgreementWaitSeconds.Value);
        }
    }
}
