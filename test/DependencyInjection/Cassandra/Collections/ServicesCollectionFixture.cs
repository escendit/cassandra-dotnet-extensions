// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.DependencyInjection.Cassandra.Tests.Collections;

using Fixtures;
using Xunit;

/// <summary>
/// Services Collection Fixture.
/// </summary>
[CollectionDefinition(Name)]
public class ServicesCollectionFixture : ICollectionFixture<ServiceCollectionFixture>
{
    /// <summary>
    /// Services Collection Fixture Name.
    /// </summary>
    public const string Name = "ServicesCollectionFixture";
}
