namespace ASP_Bank.Models
{
    public class ServiceProvider
    {
        public int Id { get; set; }

        // KCell, ASTEL
        public string Name { get; set; }

        public ServiceType ServiceType { get; set; }
    }
}