using System;

namespace ASP_Bank.Models
{
    public class BankCard
    {
        public int Id { get; set; }

        // 16 значный номер
        public string Number { get; set; }

        // годен до
        public DateTime ValidTill { get; set; }

        // Фамилия Имя держателя
        public string CardHolder { get; set; }

        // CVC код
        public int Cvc { get; set; }

        public decimal Amount { get; set; }

        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}