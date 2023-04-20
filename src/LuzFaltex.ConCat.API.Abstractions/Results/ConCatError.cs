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
