
namespace POS.Application.Common.Models
{
    public class Response<T> 
    {
        public string Message { get; set; } = string.Empty;
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
    }
}
