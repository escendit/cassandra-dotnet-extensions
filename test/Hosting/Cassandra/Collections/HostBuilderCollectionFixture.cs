// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.Hosting.Cassandra.Tests.Collections;

using Fixtures;

/// <summary>
/// Host Builder Collection Fixture.
/// </summary>
[CollectionDefinition(Name)]
public sealed class HostBuilderCollectionFixture : ICollectionFixture<HostBuilderFixture>
{
    /// <summary>
    /// Host Builder Name.
    /// </summary>
    public const string Name = "HostBuilder";
}
