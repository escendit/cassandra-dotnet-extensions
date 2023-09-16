// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.DependencyInjection.Cassandra;

using global::Cassandra.Metrics;
using global::Cassandra.Metrics.Abstractions;

/// <summary>
/// Metric Options.
/// </summary>
public class MetricOptions
{
    /// <summary>
    /// Gets or sets the driver metrics provider.
    /// </summary>
    /// <value>The driver metrics provider.</value>
    public IDriverMetricsProvider? DriverMetricsProvider { get; set; }

    /// <summary>
    /// Gets or sets the driver metrics options.
    /// </summary>
    /// <value>The driver metrics options.</value>
    public DriverMetricsOptions? DriverMetricsOptions { get; set; }
}
