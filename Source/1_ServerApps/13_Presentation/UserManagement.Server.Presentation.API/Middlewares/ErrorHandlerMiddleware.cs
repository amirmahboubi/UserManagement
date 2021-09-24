using System.Net;
using System.Text.Json;
using UserManagement.Server.Core.Application.Exceptions;
using UserManagement.Shared.Models.ServicesDTOs._Shared;

namespace UserManagement.Server.Presentation.API.Middlewares
{
	public class ErrorHandlerMiddleware
	{
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                HttpResponse response = context.Response;
                response.ContentType = "application/json";

                Response responseModel = new Response() 
                { 
                    Header = new ResponseHeader() { Succeeded = false, Message = error?.Message }
                };

                switch (error)
                {
                    case ApiException e:
                        // custom application error
                        responseModel.Header.StatusCode = HttpStatusCode.BadRequest;
                        break;
                    case KeyNotFoundException e:
                        // not found error
                        responseModel.Header.StatusCode = HttpStatusCode.NotFound;
                        break;
                    default:
                        // unhandled error
                        responseModel.Header.StatusCode = HttpStatusCode.InternalServerError;
                        break;
                }

                response.StatusCode = (int)responseModel.Header.StatusCode;

                string result = JsonSerializer.Serialize(responseModel);

                await response.WriteAsync(result);
            }
        }
    }
}
