//
//  IUser.cs
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

namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Users
{
    /// <summary>
    /// Defines a ConCat user.
    /// </summary>
    [PublicAPI]
    public interface IUser
    {
        /// <summary>
        /// Gets the unique identifier of the user.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets the email address of the user.
        /// </summary>
        // email
        string EmailAddress { get; }

        /// <summary>
        /// Gets the preferred name of the user.
        /// </summary>
        /// <remarks>
        /// If provided, this should be used instead of the first and last name,
        /// except where legally required.
        /// </remarks>
        string? PreferredName { get; }

        /// <summary>
        /// Gets the first name of the user.
        /// </summary>
        string FirstName { get; }

        /// <summary>
        /// Gets the last name of the user.
        /// </summary>
        string LastName { get; }

        /// <summary>
        /// Gets the username of the user.
        /// </summary>
        string Username { get; }

        /// <summary>
        /// Gets a value indicating whether the user has verified their email address.
        /// </summary>
        bool Verified { get; }

        /// <summary>
        /// Gets the user's phone number in E.164 format.
        /// </summary>
        string PhoneNumber { get; }

        /// <summary>
        /// Gets the address of the user.
        /// </summary>
        /// <remarks>
        /// If PII is not required to register, the <see cref="MailingAddress"/> will be null.
        /// </remarks>
        IMailingAddress? MailingAddress { get; }
    }
}
