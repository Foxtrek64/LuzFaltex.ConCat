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
