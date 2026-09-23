namespace POS.Application.Common.Exception
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
