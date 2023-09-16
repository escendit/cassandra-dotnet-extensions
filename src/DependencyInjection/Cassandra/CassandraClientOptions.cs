// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.Hosting.Cassandra;

using System.Collections.ObjectModel;
using Escendit.Extensions.DependencyInjection.Cassandra;
using global::Cassandra;
using global::Cassandra.DataStax.Graph;
using global::Cassandra.Serialization;

/// <summary>
/// Cassandra Options.
/// </summary>
public record CassandraClientOptions
{
    /// <summary>
    /// Default Options Key.
    /// </summary>
    public const string DefaultOptionsKey = "Default";

    /// <summary>
    /// Gets the endpoints.
    /// </summary>
    /// <value>The endpoints.</value>
    public Collection<string> Endpoints { get; } = new();

    /// <summary>
    /// Gets or sets the compression type.
    /// </summary>
    /// <value>The compression type.</value>
    public CompressionType? CompressionType { get; set; }

    /// <summary>
    /// Gets or sets the protocol version.
    /// </summary>
    /// <value>The protocol version.</value>
    public ProtocolVersion? MaxProtocolVersion { get; set; }

    /// <summary>
    /// Gets or sets the credentials.
    /// </summary>
    /// <value>The credentials.</value>
    public Credentials? Credentials { get; set; }

    /// <summary>
    /// Gets or sets the metric options.
    /// </summary>
    /// <value>The metric options.</value>
    public MetricOptions? MetricOptions { get; set; }

    /// <summary>
    /// Gets or sets the port.
    /// </summary>
    /// <value>The port.</value>
    public int? Port { get; set; }

    /// <summary>
    /// Gets or sets the address translator.
    /// </summary>
    /// <value>The address translator.</value>
    public IAddressTranslator? AddressTranslator { get; set; }

    /// <summary>
    /// Gets or sets the application name.
    /// </summary>
    /// <value>The application name.</value>
    public string? ApplicationName { get; set; }

    /// <summary>
    /// Gets or sets the application version.
    /// </summary>
    /// <value>The application version.</value>
    public string? ApplicationVersion { get; set; }

    /// <summary>
    /// Gets or sets the authentication provider.
    /// </summary>
    /// <value>The authentication provider.</value>
    public IAuthProvider? AuthenticationProvider { get; set; }

    /// <summary>
    /// Gets or sets the cluster id.
    /// </summary>
    /// <value>The cluster id.</value>
    public Guid? ClusterId { get; set; }

    /// <summary>
    /// Gets or sets the connection string.
    /// </summary>
    /// <value>The connection string.</value>
    public string? ConnectionString { get; set; }

    /// <summary>
    /// Gets or sets the frame compressor.
    /// </summary>
    /// <value>The frame compressor.</value>
    public IFrameCompressor? Compressor { get; set; }

    /// <summary>
    /// Gets or sets the default keyspace.
    /// </summary>
    /// <value>The default keyspace.</value>
    public string? DefaultKeyspace { get; set; }

    /// <summary>
    /// Gets or sets the execution profile options builder.
    /// </summary>
    /// <value>The execution profile options builder.</value>
    public Action<IExecutionProfileOptions>? ExecutionProfileOptionsFactory { get; set; }

    /// <summary>
    /// Gets or sets the graph options.
    /// </summary>
    /// <value>The graph options.</value>
    public GraphOptions? GraphOptions { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether enable monitor reporting.
    /// </summary>
    /// <value>The flag to enable monitor reporting.</value>
    public bool? EnableMonitorReporting { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether enable no compact mode.
    /// </summary>
    /// <value>The flag to enable no compact mode.</value>
    public bool? EnableNoCompactMode { get; set; }

    /// <summary>
    /// Gets or sets the pooling options.
    /// </summary>
    /// <value>The pooling options.</value>
    public PoolingOptions? PoolingOptions { get; set; }

    /// <summary>
    /// Gets or sets the query options.
    /// </summary>
    /// <value>The query options.</value>
    public QueryOptions? QueryOptions { get; set; }

    /// <summary>
    /// Gets or sets the query timeout.
    /// </summary>
    /// <value>The query timeout.</value>
    public int? QueryTimeout { get; set; }

    /// <summary>
    /// Gets or sets the reconnection policy.
    /// </summary>
    /// <value>The reconnection policy.</value>
    public IReconnectionPolicy? ReconnectionPolicy { get; set; }

    /// <summary>
    /// Gets or sets the retry policy.
    /// </summary>
    /// <value>The retry policy.</value>
    public IRetryPolicy? RetryPolicy { get; set; }

    /// <summary>
    /// Gets or sets the session name.
    /// </summary>
    /// <value>The session name.</value>
    public string? SessionName { get; set; }

    /// <summary>
    /// Gets or sets the socket options.
    /// </summary>
    /// <value>The socket options.</value>
    public SocketOptions? SocketOptions { get; set; }

    /// <summary>
    /// Gets or sets the timestamp generator.
    /// </summary>
    /// <value>The timestamp generator.</value>
    public ITimestampGenerator? TimestampGenerator { get; set; }

    /// <summary>
    /// Gets or sets the type serializer definitions.
    /// </summary>
    /// <value>The type serializer definitions.</value>
    public TypeSerializerDefinitions? TypeSerializerDefinitions { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether enable beta protocol versions.
    /// </summary>
    /// <value>The flag to enable beta protocol versions.</value>
    public bool? EnableBetaProtocolVersions { get; set; }

    /// <summary>
    /// Gets or sets the load balancing policy.
    /// </summary>
    /// <value>The load balancing policy.</value>
    public ILoadBalancingPolicy? LoadBalancingPolicy { get; set; }

    /// <summary>
    /// Gets or sets the metadata sync options.
    /// </summary>
    /// <value>The metadata sync options.</value>
    public MetadataSyncOptions? MetadataSyncOptions { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether enable row set buffering.
    /// </summary>
    /// <value>The flag to enable row set buffering.</value>
    public bool? EnableRowSetBuffering { get; set; }

    /// <summary>
    /// Gets or sets the speculative execution policy.
    /// </summary>
    /// <value>The speculative execution policy.</value>
    public ISpeculativeExecutionPolicy? SpeculativeExecutionPolicy { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether enable ssl/tls.
    /// </summary>
    /// <value>The flag to enable ssl/tls.</value>
    public bool? EnableTransportLayerSecurity { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether enable unresolved contact points.
    /// </summary>
    /// <value>The flag to enable unresolved contact points.</value>
    public bool? EnableUnresolvedContactPoints { get; set; }

    /// <summary>
    /// Gets or sets the cloud secure connection bundle.
    /// </summary>
    /// <value>The cloud secure connection bundle.</value>
    public string? CloudSecureConnectionBundle { get; set; }

    /// <summary>
    /// Gets or sets the max schema agreement wait seconds.
    /// </summary>
    /// <value>The max schema agreement wait seconds.</value>
    public int? MaxSchemaAgreementWaitSeconds { get; set; }
}
