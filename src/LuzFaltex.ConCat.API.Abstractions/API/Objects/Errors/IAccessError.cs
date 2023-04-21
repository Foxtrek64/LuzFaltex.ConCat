//
//  IAccessError.cs
//
//  Author:
//       LuzFaltex Contributors <support@luzfaltex.com>
//
//  Copyright (c) LuzFaltex 2023. All rights reserved.
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System.Collections.Generic;
using JetBrains.Annotations;
using Remora.Rest.Core;

namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Errors
{
    /// <summary>
    /// Defines an access error. Access errors indicate an API authentication or permission restriction
    /// preventing the request. Usually these will accompany a <see cref="System.Net.HttpStatusCode.Forbidden">403 - Forbidden</see>
    /// HTTP status code.
    /// </summary>
    [PublicAPI]
    public interface IAccessError
    {
        /// <summary>
        /// Gets a human-readable message describing the error.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// Gets a list of permissions that are required to access the resource. May be empty or not provided
        /// if the error is not related to permissions.
        /// </summary>
        Optional<IReadOnlyList<IPermission>> Permissions { get; }
    }
}
