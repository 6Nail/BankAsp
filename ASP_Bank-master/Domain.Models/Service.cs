namespace WebApplication2.Entities
{
    public class Service
    {
        public int Id { get; set; }

        public int ServiceProviderId { get; set; }
        public ServiceProvider ServiceProvider { get; set; }


        public int BankCardId { get; set; }
        public BankCard BankCard { get; set; }
        

        public decimal Amount { get; set; }

    }
}