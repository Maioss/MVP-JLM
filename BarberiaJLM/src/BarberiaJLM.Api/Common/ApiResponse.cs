namespace BarberiaJLM.Api.Common
{
    public record ApiResponse<T>(bool Success, T? Data, string? Message)
    {
        public static ApiResponse<T> Ok(T data) => new(true, data, null);
        public static ApiResponse<T> Fail(string message) => new(false, default, message);
    }
}
