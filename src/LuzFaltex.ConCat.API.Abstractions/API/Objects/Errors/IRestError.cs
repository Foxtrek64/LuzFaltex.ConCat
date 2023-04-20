namespace LuzFaltex.ConCat.API.Abstractions.API.Objects.Errors
{
    /// <summary>
    /// Represents an error returned by the REST API.
    /// </summary>
    [PublicAPI]
    public interface IRestError
    {
        IOptional<IServerError> Server { get; }
        IOptional<IAccessError> Access { get; }
        IOptional<ILogicError> Logic { get; }
    }
}
