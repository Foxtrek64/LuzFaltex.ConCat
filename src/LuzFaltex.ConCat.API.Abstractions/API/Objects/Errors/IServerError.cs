using System;

namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Errors
{
    /// <summary>
    /// Defines a server error. Server errors indicate a problem with the ConCat platform
    /// that is not related to the data provided in the request. Usually these will accompany
    /// a 500 - Internal Server Error HTTP status code.
    /// </summary>
    public interface IServerError
    {
        /// <summary>
        /// Gets a base64-encoded hash representing the error.
        /// </summary>
        string Hash { get; }
    }
}
