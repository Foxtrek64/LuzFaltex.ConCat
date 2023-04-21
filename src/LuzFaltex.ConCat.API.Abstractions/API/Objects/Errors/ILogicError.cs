//
//  ILogicError.cs
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

using System.Net;
using JetBrains.Annotations;
using LuzFaltex.ConCat.API.Abstractions.Results;

namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Errors
{
    /// <summary>
    /// Defines a logic error. Logic errors indicate an issue with the data provided
    /// in the request or some other business logic error. Usually these will accompany
    /// a <see cref="HttpStatusCode.BadRequest">400 - Bad Request</see> HTTP Status Code.
    /// </summary>
    [PublicAPI]
    public interface ILogicError
    {
        /// <summary>
        /// Gets a code indicating the specific logic error.
        /// </summary>
        ConCatError Code { get; }

        /// <summary>
        /// Gets a human-readable message describing the error.
        /// </summary>
        string Message { get; }
    }
}
