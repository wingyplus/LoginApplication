namespace LoginWebPage.Controllers
{
    public class AuthenticationError 
    {
        public string EMessage { get; }

        public AuthenticationError(string eMessage)
        {
            EMessage = eMessage;
        }

        public AuthenticationError() { }
    }
}