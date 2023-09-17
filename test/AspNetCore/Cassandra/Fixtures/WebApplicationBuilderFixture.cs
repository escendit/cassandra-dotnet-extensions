// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.AspNetCore.Builder.Cassandra.Tests.Fixtures;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Orleans.Runtime;

/// <summary>
/// Web Application Builder Fixture.
/// </summary>
public class WebApplicationBuilderFixture
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebApplicationBuilderFixture"/> class.
    /// </summary>
    public WebApplicationBuilderFixture()
    {
    }

    /// <summary>
    /// Create Web Application Builder.
    /// </summary>
    /// <returns>The web application builder.</returns>
    public WebApplicationBuilder CreateWebApplicationBuilder()
    {
        var webApplicationBuilder = WebApplication.CreateBuilder();
        webApplicationBuilder
            .Services
            .TryAddSingleton(typeof(IKeyedServiceCollection<,>), typeof(KeyedServiceCollection<,>));
        return webApplicationBuilder;
    }

    /// <summary>
    /// Create Service Provider.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>The service provider.</returns>
    public IServiceProvider CreateServiceProvider(string name)
    {
        return CreateWebApplicationBuilder()
            .AddCassandraClient(name, options => options.Endpoints.Add("localhost"))
            .Build()
            .Services;
    }
}
