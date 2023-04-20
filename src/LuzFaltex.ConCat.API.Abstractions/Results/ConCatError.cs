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
        CannotChangeDealerStatus = 2
    }
}
