namespace MachinePark.Web.Http
{
    public class Result : IResult
    {
        public bool Success { get; set; }

        public static IResult Succeeded()
        {
            return new Result
            {
                Success = true,
            };
        }

        public static IResult Failure()
        {
            return new Result
            {
                Success = false,
            };
        }
    }

    public class Result<TData> : IResult
    {
        public bool Success { get; set; }
        public TData Data { get; set; } = default!;

        public static IResult Succeeded(TData data)
        {
            return new Result<TData>
            {
                Success = true,
                Data = data,
            };
        }

        public static IResult Failure()
        {
            return new Result<TData>
            {
                Success = false,
            };
        }
    }
}
