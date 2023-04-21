//
//  IMailingAddress.cs
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

using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Users
{
    /// <summary>
    /// Defines a mailing address.
    /// </summary>
    [PublicAPI]
    public interface IMailingAddress
    {
        /// <summary>
        /// Gets the name of the city.
        /// </summary>
        [JsonPropertyName("addressCity")]
        string City { get; }

        /// <summary>
        /// Gets the two-letter country code.
        /// </summary>
        [JsonPropertyName("addressCountry")]
        string Country { get; }

        /// <summary>
        /// Gets the first line of the address.
        /// </summary>
        [JsonPropertyName("addressLine1")]
        string AddressLine1 { get; }

        /// <summary>
        /// Gets the second line of the address, such as the apartment number.
        /// </summary>
        [JsonPropertyName("addressLine2")]
        string? AddressLine2 { get; }

        /// <summary>
        /// Gets the state or province.
        /// </summary>
        [JsonPropertyName("addressState")]
        string State { get; }

        /// <summary>
        /// Gets the ZIP or postal code.
        /// </summary>
        [JsonPropertyName("addressZipcode")]
        string PostalCode { get; }
    }
}
