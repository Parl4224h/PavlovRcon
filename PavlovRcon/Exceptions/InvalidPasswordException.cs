namespace PavlovRcon.Exceptions;

/// <summary>
/// Exception thrown when the provided password is invalid.
/// </summary>
public class InvalidPasswordException : Exception
{
    /// <summary>
    /// Default constructor
    /// </summary>
    public InvalidPasswordException()
    {
    }
    
    /// <summary>
    /// Constructor with a message
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception</param>
    public InvalidPasswordException(string message) : base(message)
    {
    }
    
    /// <summary>
    /// Constructor with a message and inner exception
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception</param>
    /// <param name="innerException">The exception that is the cause of the current exception</param>
    public InvalidPasswordException(string message, Exception innerException) : base(message, innerException)
    {
    }
}