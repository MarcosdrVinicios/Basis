namespace Application.Common.Exceptions;

using System.Net;

public class UnauthorizedException : CustomException
{
    public UnauthorizedException(string message)
       : base(message, null, HttpStatusCode.Unauthorized)
    {
    }
}