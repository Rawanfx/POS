namespace POS.Application.Common
{
    public class UnAuthorized:Exception
    {
        public string message { get; }
        public UnAuthorized (string message)
        {
            this.message = message;
        }
    }
}
