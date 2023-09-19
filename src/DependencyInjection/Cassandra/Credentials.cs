// Copyright (c) Escendit Ltd. All Rights Reserved.
// Licensed under the MIT. See LICENSE.txt file in the solution root for full license information.

namespace Escendit.Extensions.DependencyInjection.Cassandra;

/// <summary>
/// Cassandra Credentials.
/// </summary>
public class Credentials
{
    /// <summary>
    /// Gets or sets the username.
    /// </summary>
    /// <value>The username.</value>
    public string Username { get; set; } = default!;

    /// <summary>
    /// Gets or sets the password.
    /// </summary>
    /// <value>The password.</value>
    public string Password { get; set; } = default!;
}
