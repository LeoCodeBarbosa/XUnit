using MediatR;

namespace Features.Clients
{
    public class ClientEmailNotification : INotification
    {
        public string Source { get; private set; }
        public string Destiny { get; private set; }
        public string Subject { get; private set; }
        public string Message { get; private set; }

        public ClientEmailNotification(string source, string destiny, string subject, string message)
        {
            Source = source;
            Destiny = destiny;
            Subject  = subject;
            Message = message;
        }
    }
}