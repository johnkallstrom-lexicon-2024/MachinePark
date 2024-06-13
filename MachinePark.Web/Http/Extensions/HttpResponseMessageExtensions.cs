namespace MachinePark.Web.Http.Extensions
{
    public static class HttpResponseMessageExtensions
    {
        public static Dictionary<string, string> ExtractInformation(this HttpResponseMessage response)
        {
            var information = new Dictionary<string, string>
            {
                { "Method", $"{response.RequestMessage?.Method.Method}" },
                { "Uri", $"{response.RequestMessage?.RequestUri?.AbsoluteUri}" },
                { "StatusCode", $"{(int)response.StatusCode}" }
            };

            return information;
        }
    }
}
