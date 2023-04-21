//
//  IRestError.cs
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

using JetBrains.Annotations;
using Remora.Rest.Core;

namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Errors
{
    /// <summary>
    /// Represents an error returned by the REST API.
    /// </summary>
    [PublicAPI]
    public interface IRestError
    {
        /// <summary>
        /// Gets the server error, if present.
        /// </summary>
        Optional<IServerError> Server { get; }

        /// <summary>
        /// Gets the access error, if present.
        /// </summary>
        Optional<IAccessError> Access { get; }

        /// <summary>
        /// Gets the logic error, if present.
        /// </summary>
        Optional<ILogicError> Logic { get; }

        // TODO: Add remaining error types: resource, usage, authentication, validation, rate limit, internal.
        // These types are not yet defined in the docs and it is unclear if they are provided in production.
    }
}
