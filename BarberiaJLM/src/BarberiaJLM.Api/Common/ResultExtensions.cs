using BarberiaJLM.Application.Common;
using Microsoft.AspNetCore.Mvc;

namespace BarberiaJLM.Api.Common
{
    public static class ResultExtensions
    {
        public static IActionResult ToActionResult<T>(this Result<T> result) =>
            result.IsSuccess
                ? new OkObjectResult(ApiResponse<T>.Ok(result.Value!))
                : result.ErrorType switch
                {
                    ErrorType.NotFound     => new NotFoundObjectResult(ApiResponse<T>.Fail(result.Error!)),
                    ErrorType.Validation   => new BadRequestObjectResult(ApiResponse<T>.Fail(result.Error!)),
                    ErrorType.Conflict     => new ConflictObjectResult(ApiResponse<T>.Fail(result.Error!)),
                    ErrorType.Unauthorized => new UnauthorizedObjectResult(ApiResponse<T>.Fail(result.Error!)),
                    ErrorType.Forbidden    => new ObjectResult(ApiResponse<T>.Fail(result.Error!)) { StatusCode = 403 },
                    _                      => new ObjectResult(ApiResponse<T>.Fail(result.Error!)) { StatusCode = 500 }
                };
    }
}
