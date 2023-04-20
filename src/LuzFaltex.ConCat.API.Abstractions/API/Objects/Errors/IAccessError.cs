namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Errors
{
    /// <summary>
    /// Defines an access error. Access errors indicate an API authentication or permission restriction
    /// preventing the request. Usually these will accompany a <see cref="HttpStatusCode.403">Forbidden</see>
    /// HTTP status code.
    /// </summary>
    public interface IAccessError
    {
        /// <summary>
        /// Gets a human-readable message describing the error.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets a list of permissions that are required to access the resource. May be empty or not provided
        /// if the error is not related to permissions.
        /// </summary>
        public IOptional<IReadOnlyList<IPermission>> Permissions { get; }
    }
}
