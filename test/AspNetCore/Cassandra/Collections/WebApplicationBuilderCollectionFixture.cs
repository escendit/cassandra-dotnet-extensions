// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.AspNetCore.Builder.Cassandra.Tests.Collections;

using Fixtures;

/// <summary>
/// Web Application Builder Collection Fixture.
/// </summary>
[CollectionDefinition(Name)]
public class WebApplicationBuilderCollectionFixture : ICollectionFixture<WebApplicationBuilderFixture>
{
    /// <summary>
    /// Web Application Builder.
    /// </summary>
    public const string Name = "WebApplicationBuilder";
}
