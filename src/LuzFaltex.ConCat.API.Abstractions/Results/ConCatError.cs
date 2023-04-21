//
//  ConCatError.cs
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
using JetBrains.Annotations;

namespace LuzFaltex.ConCat.API.Abstractions.Results
{
    /// <summary>
    /// Enumerates the ConCat <see href="https://concat.app/docs/api/errors/logicerrorcodes">Error Codes</see>.
    /// </summary>
    [PublicAPI]
    public enum ConCatError
    {
        /// <summary>
        /// The record you're trying to delete has other dependent records.
        /// </summary>
        RecordIsReferenced = 1,

        /// <summary>
        /// The vendor has already paid, so cannot be changed to a different status.
        /// Refund the vendor's payment before changing the status.
        /// </summary>
        CannotChangeDealerStatus = 2,

        /// <summary>
        /// Target user is already associated with the target record. You can't add
        /// the same user to the same record twice.
        /// </summary>
        UserWasAlreadyAdded = 3,

        /// <summary>
        /// The vendor has already paid, so cannot be deleted. Refund the vendor's
        /// payment before deleting the application.
        /// </summary>
        CannotDeleteApplication = 4,

        /// <summary>
        /// The payment was declined by the credit card processor.
        /// </summary>
        CardDeclined = 5,

        /// <summary>
        /// The email address is already in use.
        /// </summary>
        EmailAlreadyInUse = 6,

        /// <summary>
        /// You cannot add compensation to your own user.
        /// </summary>
        [Obsolete("Removed in V0")]
        CannotAddCompensationToOwn = 7
    }
}
