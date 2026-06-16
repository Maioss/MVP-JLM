namespace BarberiaJLM.Application.Common
{
    public class Result<T>
    {
        public bool IsSuccess { get; }
        public T? Value { get; }
        public string? Error { get; }
        public ErrorType ErrorType { get; }

        private Result(bool isSuccess, T? value, string? error, ErrorType errorType)
        {
            IsSuccess = isSuccess;
            Value = value;
            Error = error;
            ErrorType = errorType;
        }

        public static Result<T> Success(T value) =>
            new(true, value, null, ErrorType.None);

        public static Result<T> Failure(string error, ErrorType type) =>
            new(false, default, error, type);

        public static Result<T> NotFound(string error) =>
            Failure(error, ErrorType.NotFound);

        public static Result<T> Validation(string error) =>
            Failure(error, ErrorType.Validation);

        public static Result<T> Conflict(string error) =>
            Failure(error, ErrorType.Conflict);

        public static Result<T> Unauthorized(string error) =>
            Failure(error, ErrorType.Unauthorized);

        public static Result<T> Forbidden(string error) =>
            Failure(error, ErrorType.Forbidden);
    }
}
