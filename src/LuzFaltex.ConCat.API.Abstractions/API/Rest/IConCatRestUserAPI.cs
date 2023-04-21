//
//  IConCatRestUserAPI.cs
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

using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using LuzFaltex.ConCat.API.Abstractions.API.Objects.Users;
using Remora.Results;

namespace LuzFaltex.ConCat.API.Abstractions.API.Rest
{
    /// <summary>
    /// Defines the ConCat User API.
    /// </summary>
    [PublicAPI]
    public interface IConCatRestUserAPI
    {
        /// <summary>
        /// Gets the user with the specified <paramref name="userId"/>.
        /// </summary>
        /// <param name="userId">The id of the user.</param>
        /// <param name="cancellationToken">The cancellation token for this operation.</param>
        /// <returns>A retrieval result which may or may not have succeeded.</returns>
        Task<Result<IUser>> GetUserAsync(string userId, CancellationToken cancellationToken = default);
    }
}
