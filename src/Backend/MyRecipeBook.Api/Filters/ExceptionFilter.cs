using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MyRecipeBook.Communication;
using MyRecipeBook.Exception;
using MyRecipeBook.Exception.ExceptionsBase;

namespace MyRecipeBook.Api;

public class ExceptionFilter : IExceptionFilter
{
  public void OnException(ExceptionContext context)
  {
    if (context.Exception is ErrorValidationException errorValidationException)
    {
      context.HttpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
      context.Result = new BadRequestObjectResult(new ResponseErroJson(errorValidationException.GetErrorMessages()));
    }
    else
    {
      context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
      context.Result = new ObjectResult(new ResponseErroJson(ResourceMessagesException.UNKNOWN_ERROR));
    }
  }
}
