//
//  IServerError.cs
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

namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Errors
{
    /// <summary>
    /// Defines a server error. Server errors indicate a problem with the ConCat platform
    /// that is not related to the data provided in the request. Usually these will accompany
    /// a <see cref="System.Net.HttpStatusCode.InternalServerError">500 - Internal Server Error</see> HTTP status code.
    /// </summary>
    [PublicAPI]
    public interface IServerError
    {
        /// <summary>
        /// Gets a base64-encoded hash representing the error.
        /// </summary>
        string Hash { get; }
    }
}
