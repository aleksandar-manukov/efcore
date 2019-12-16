// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections;

namespace Microsoft.EntityFrameworkCore.Query
{
    /// <summary>
    ///     <para>
    ///         Interface that can be implemented by a database provider's <see cref="IEnumerable" /> implementation to
    ///         provide the query string for debugging purposes.
    ///     </para>
    ///     <para>
    ///         This method is typically used by database providers (and other extensions). It is generally
    ///         not used in application code.
    ///     </para>
    /// </summary>
    public interface IQueryingEnumerable
    {
        /// <summary>
        ///     A string representation of the query used. This string may not be suitable for direct execution is intended only
        ///     for use in debugging.
        /// </summary>
        /// <returns> The query string. </returns>
        string ToQueryString();
    }
}
