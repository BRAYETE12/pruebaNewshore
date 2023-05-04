namespace BackPrueba.Infrastructure.Dtos
{
    public class Response
    {
        public int StatusCode { get; set; } = StatusCodes.Status200OK;
        public string Message { get; set; }
        public object Object { get; set; }
    }
}
