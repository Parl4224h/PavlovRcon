namespace PavlovRcon.Exceptions;

/// <summary>
/// Exception thrown when an invalid response is received from the server.
/// </summary>
[Serializable]
public class InvalidResponseException : Exception
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public InvalidResponseException()
    {
    }
    
    /// <summary>
    /// Constructor with a message
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception</param>
    public InvalidResponseException(string message) : base(message)
    {
    }
    
    /// <summary>
    /// Constructor with a message and inner exception
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception</param>
    /// <param name="innerException">The exception that is the cause of the current exception</param>
    public InvalidResponseException(string message, Exception innerException) : base(message, innerException)
    {
    }
}