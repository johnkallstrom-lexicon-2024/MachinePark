namespace MachinePark.Web.Http
{
    public class Result
    {
        public bool Succeeded { get; set; }

        public static Result Success()
        {
            return new Result
            {
                Succeeded = true,
            };
        }

        public static Result Failure()
        {
            return new Result
            {
                Succeeded = false,
            };
        }
    }

    public class Result<TData>
    {
        public bool Succeeded { get; set; }
        public TData Data { get; set; } = default!;

        public static Result<TData> Success(TData data)
        {
            return new Result<TData>
            {
                Succeeded = true,
                Data = data,
            };
        }

        public static Result<TData> Failure()
        {
            return new Result<TData>
            {
                Succeeded = false,
            };
        }
    }
}
