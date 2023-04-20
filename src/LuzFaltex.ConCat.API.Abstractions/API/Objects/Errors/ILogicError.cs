using LuzFaltex.ConCat.API.Abstractions.Results;

namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Errors
{
    /// <summary>
    /// Defines a logic error. Logic errors indicate an issue wit hthe data provided
    /// in the request or some other business logic error. Usually these will accompany
    /// a <see cref="HttpStatusCode.400"/> Bad Request HTTP Status Code.
    /// </summary>
    public interface ILogicError
    {
        /// <summary>
        /// Gets a code indicating the specific logic error.
        /// </summary>
        ConCatError Code { get; }

        /// <summary>
        /// A human-readable message describing the error.
        /// </summary>
        string Message { get; }
    }
}
