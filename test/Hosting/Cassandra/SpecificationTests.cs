// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.Hosting.Cassandra.Tests;

using Collections;
using Fixtures;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Specification Tests.
/// </summary>
[Collection(HostBuilderCollectionFixture.Name)]
public class SpecificationTests
{
    private readonly HostBuilderFixture _hostBuilderFixture;

    /// <summary>
    /// Initializes a new instance of the <see cref="SpecificationTests"/> class.
    /// </summary>
    /// <param name="fixture">The fixture.</param>
    public SpecificationTests(HostBuilderFixture fixture)
    {
        _hostBuilderFixture = fixture;
    }

    /// <summary>
    /// Test Creation of Host Builder.
    /// </summary>
    [Fact]
    public void Spec_CreateHostBuilder()
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        Assert.NotNull(hostBuilder);
    }

    /// <summary>
    /// Test Adding Client Options With Options.
    /// </summary>
    /// <param name="host">The host.</param>
    [Theory]
    [InlineData("test1")]
    [InlineData("test2")]
    public void Spec_AddCassandraClientOptionsAsDefaultWithOptions(string host)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientOptionsAsDefault(options => options.Endpoints.Add(host));
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client Options With OptionsBuilder.
    /// </summary>
    /// <param name="name">The name.</param>
    [Theory]
    [InlineData("test1")]
    [InlineData("test2")]
    public void Spec_AddCassandraClientOptionsAsDefaultWithOptionsBuilder(string name)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientOptionsAsDefault(options => options.BindConfiguration(name));
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client Options With Options.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="host">The host.</param>
    [Theory]
    [InlineData("test", "localhost")]
    [InlineData("abcd", "::1")]
    public void Spec_AddCassandraClientOptionsWithOptions(string name, string host)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientOptions(name, options => options.Endpoints.Add(host));
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client Options With OptionsBuilder.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="binding">The binding.</param>
    [Theory]
    [InlineData("name1", "binding1")]
    [InlineData("name2", "binding2")]
    public void Spec_AddCassandraClientOptionsWithOptionsBuilder(string name, string binding)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientOptions(name, builder => builder.BindConfiguration(binding));
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client With Options.
    /// </summary>
    /// <param name="host">The host.</param>
    [Theory]
    [InlineData("host1")]
    [InlineData("host2")]
    public void Spec_AddCassandraClientAsDefaultWithOptions(string host)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientAsDefault(options => options.Endpoints.Add(host));
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client With OptionsBuilder.
    /// </summary>
    /// <param name="binding">The binding.</param>
    [Theory]
    [InlineData("binding1")]
    [InlineData("binding2")]
    public void Spec_AddCassandraClientAsDefaultWithOptionsBuilder(string binding)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientAsDefault(options => options.BindConfiguration(binding));
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Named Client With Options.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="host">The host.</param>
    [Theory]
    [InlineData("name1", "host1")]
    [InlineData("name2", "host2")]
    public void Spec_AddCassandraClientWithOptions(string name, string host)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClient(name, options => options.Endpoints.Add(host));
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Named Client With OptionsBuilder.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="binding">The building.</param>
    [Theory]
    [InlineData("name1", "binding1")]
    [InlineData("name2", "binding2")]
    public void Spec_AddCassandraClientWithOptionsBuilder(string name, string binding)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClient(name, options => options.BindConfiguration(binding));
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client From Options Name.
    /// </summary>
    /// <param name="host">The host.</param>
    [Theory]
    [InlineData("host1")]
    [InlineData("host2")]
    public void Spec_AddCassandraClientFromOptionsAsDefault(string host)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientAsDefault(options => options.Endpoints.Add(host));
        hostBuilder.AddCassandraClientFromOptionsAsDefault("Default");
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Named Client From Options Name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="option">The options.</param>
    /// <param name="host">The host.</param>
    [Theory]
    [InlineData("name1", "option1", "host1")]
    [InlineData("name2", "option2", "host2")]
    public void Spec_AddCassandraClientFromOptions(string name, string option, string host)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientOptions(option, options => options.Endpoints.Add(host));
        hostBuilder.AddCassandraClientFromOptions(name, option);
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client Options From Configuration As Default.
    /// </summary>
    [Fact]
    public void Spec_AddCassandraClientOptionsFromConfigurationAsDefault()
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientOptionsAsDefault();
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client Options From Configuration.
    /// </summary>
    /// <param name="name">The name.</param>
    [Theory]
    [InlineData("name1")]
    [InlineData("name2")]
    public void Spec_AddCassandraClientOptionsFromConfiguration(string name)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientOptions(name);
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client From Configuration As Default.
    /// </summary>
    [Fact]
    public void Spec_AddCassandraClientFromConfigurationAsDefault()
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClientAsDefault();
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Adding Client From Configuration.
    /// </summary>
    /// <param name="name">The name.</param>
    [Theory]
    [InlineData("name1")]
    [InlineData("name2")]
    public void Spec_AddCassandraClientFromConfiguration(string name)
    {
        var hostBuilder = _hostBuilderFixture.CreateHostBuilder();
        hostBuilder.AddCassandraClient(name);
        var serviceProvider = hostBuilder.Build().Services;
        Assert.NotNull(serviceProvider);
    }

    /// <summary>
    /// Test Getting a Cassandra Client As Default.
    /// </summary>
    [Fact]
    public void Spec_GetRequiredCassandraClientAsDefault()
    {
        var serviceProvider = _hostBuilderFixture.CreateServiceProvider("Default");
        var cluster = serviceProvider.GetRequiredCassandraClient();
        Assert.NotNull(cluster);
    }

    /// <summary>
    /// Test Getting a Cassandra Client.
    /// </summary>
    /// <param name="name">The name.</param>
    [Theory]
    [InlineData("name1")]
    [InlineData("name2")]
    public void Spec_GetRequiredCassandraClient(string name)
    {
        var serviceProvider = _hostBuilderFixture.CreateServiceProvider(name);
        var cluster = serviceProvider.GetRequiredCassandraClient(name);
        Assert.NotNull(cluster);
    }

    /// <summary>
    /// Test Getting a Cassandra Client.
    /// </summary>
    [Fact]
    public void Spec_GetCassandraClientAsDefault()
    {
        var serviceProvider = _hostBuilderFixture.CreateServiceProvider("Default");
        var cluster = serviceProvider.GetCassandraClient();
        Assert.NotNull(cluster);
    }

    /// <summary>
    /// Test Getting a Named Cassandra Client.
    /// </summary>
    /// <param name="name">The name.</param>
    [Theory]
    [InlineData("name1")]
    [InlineData("name2")]
    public void Spec_GetCassandraClient(string name)
    {
        var serviceProvider = _hostBuilderFixture.CreateServiceProvider(name);
        var cluster = serviceProvider.GetCassandraClient(name);
        Assert.NotNull(cluster);
    }
}
