namespace Application.Common.Exceptions;

using System.Net;

public class ConflictException : CustomException
{
    public ConflictException(string message)
        : base(message, null, HttpStatusCode.Conflict)
    {
    }
}