using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Utility.Exceptions;
using Utility.Helpers;

namespace API.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _env;

        public ExceptionMiddleware(RequestDelegate next, IWebHostEnvironment env)
        {
            _next = next;
            _env = env;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception e)
            {
                await HandleCustomException(e, context);
            }
        }

        private async Task HandleCustomException(Exception excp, HttpContext context)
        {
            var errCode = HttpStatusCode.InternalServerError;

            var error = new ErrorResponse();
            error.StatusCode = Convert.ToInt32(errCode);
            error.Message = excp.Message;

            if (_env.IsDevelopment())
            {
                error.DeveloperMessage = excp.StackTrace;
            }
            else
            {
                error.DeveloperMessage = excp.Message;
            }            

            switch (excp)
            {
                case ApiExceptions apiExceptions:
                    error.StatusCode = (int)HttpStatusCode.NotFound;
                    break;
                default:
                    break;
            }

            var errResultJson = JsonConvert.SerializeObject(error);
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = error.StatusCode;

            await context.Response.WriteAsync(errResultJson);
        }
    }
}
