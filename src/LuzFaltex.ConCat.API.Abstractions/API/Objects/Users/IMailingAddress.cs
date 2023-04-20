namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Users
{
    public interface IMailingAddress
    {
        /// <summary>
        /// The name of the city.
        /// </summary>
        [JsonAttributeName("addressCity")]
        string City { get; }

        /// <summary>
        /// The two-letter country code.
        /// </summary>
        [JsonAttributeName("addressCountry")]
        string Country { get; }

        /// <summary>
        /// The first line of the address.
        /// </summary>
        [JsonAttributeName("addressLine1")]
        string AddressLine1 { get; }

        /// <summary>
        /// The second line of the address, such as the apartment number.
        /// </summary>
        [JsonAttributeName("addressLine2")]
        string? AddressLine2 { get; }

        /// <summary>
        /// The state or province.
        /// </summary>
        [JsonAttributeName("addressState")]
        string State { get; }

        /// <summary>
        /// The ZIP or postal code.
        /// </summary>
        [JsonAttributeName("addressZipcode")]
        string PostalCode { get; }
    }
}
