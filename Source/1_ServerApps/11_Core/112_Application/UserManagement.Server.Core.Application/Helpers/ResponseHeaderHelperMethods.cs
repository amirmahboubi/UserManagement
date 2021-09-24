using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Shared.Models.ServicesDTOs._Shared;

namespace UserManagement.Server.Core.Application.Helpers
{
	internal static class ResponseHeaderHelperMethods
	{
		public static ResponseHeader SuccessResponse()
		{
			return new ResponseHeader()
			{
				StatusCode = HttpStatusCode.OK,
				Succeeded = true,
				Message = "OK"
			};
		}

		public static ResponseHeader UnsuccessResponse(string message, HttpStatusCode statusCode = HttpStatusCode.InternalServerError)
		{
			return new ResponseHeader()
			{
				StatusCode = statusCode,
				Succeeded = false,
				Message = message
			};
		}

		public static ResponseHeader ExceptionResponse(Exception exception)
		{
			string innerException = exception.InnerException != null ? $" - InnerException: {exception.InnerException.Message}" : "";
			return UnsuccessResponse(message: exception.Message + innerException);
		}
	}
}
