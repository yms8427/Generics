using BilgeAdam.OOP.GenericTypes.Abstractions;
using BilgeAdam.OOP.GenericTypes.Concretes;
using System;

namespace BilgeAdam.OOP.GenericTypes.Helpers
{
    public class MoneyTransfer<T> where T : IMoneyTransfer
    {
        private readonly IMoneyTransfer payMaster;
        public MoneyTransfer(string to, decimal amount)
        {
            To = to;
            Amount = amount;
            payMaster = Activator.CreateInstance<T>();
        }

        public decimal Amount { get; }
        public string To { get; }
        public void Send()
        {
            var info = new TransferInfo()
            {
                AccountNumber = To,
                Amount = Amount
            };
            payMaster.Transfer(info);
        }

        public void Cancel()
        {

        }
    }
}
