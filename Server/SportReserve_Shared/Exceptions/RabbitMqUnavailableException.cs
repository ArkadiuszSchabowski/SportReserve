namespace SportReserve_Shared.Exceptions
{
    public class RabbitMqUnavailableException : Exception
    {
        public RabbitMqUnavailableException(string message) : base(message)
        {
            
        }
    }
}
