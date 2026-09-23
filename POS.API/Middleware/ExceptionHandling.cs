using POS.Application.Common.Exception;

namespace POS.API.Middleware
{
    public class ExceptionHandling : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            { 
                await HandleException(context, ex);

            }
        }
        private async Task HandleException(HttpContext context, Exception exception)
        {
            object statusCode;
            object response;
            (statusCode,response) = exception switch
            {
                UnAuthorized => (StatusCodes.Status401Unauthorized, new { message = exception.Message }),
                _ => (StatusCodes.Status500InternalServerError, new { message = "An unexpected error occurred." })
            };
            context.Response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsJsonAsync(response);
        }
    }
}
