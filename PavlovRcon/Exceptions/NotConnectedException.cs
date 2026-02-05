namespace PavlovRcon.Exceptions;

/// <summary>
/// Exception thrown when the client is not connected to the server.
/// </summary>
[Serializable]
public class NotConnectedException : Exception
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public NotConnectedException()
    {
    }

    /// <summary>
    /// Constructor with a message
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception</param>
    public NotConnectedException(string message) : base(message)
    {
    }

    /// <summary>
    /// Constructor with a message and inner exception
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception</param>
    /// <param name="innerException">The exception that is the cause of the current exception</param>
    public NotConnectedException(string message, Exception innerException) : base(message, innerException)
    {
    }
}