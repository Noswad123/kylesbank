using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class BankAccount
    {
        private int Balance { get; set; }
        private string accountHolder { get; set; }
        private int accountIdNumber { get; set; }
        private bool isMember { get; set; }
        protected TransactionQueue BankTransactions;

        public void applyTransaction(Transactions trans)
        {
            Balance += trans.amount;
        }
    }
    public class SavingsAccount : BankAccount
    {
        public int interestRate { get; set; }

        public void interestCharge(int amount, int id, string company)
        {
            Transactions interestCharge = new Transactions(amount, id, company);
            BankTransactions.request(interestCharge);
        }
    }
    public class CheckingAccount : BankAccount
    {
        public int serviceFee { get; set; }

        public void yearlyFee(int amount, int id, string company)
        {
            Transactions yearlyCharge = new Transactions(amount, id, company);
            BankTransactions.request(yearlyCharge);
        }
    }
    public class Transactions 
    {
        public int amount { get; set; }
        public int transactionId { get; set; }
        public string nameOfCompany { get; set; }

        public Transactions(int amount, int id, string company)
        {
            this.amount = amount;
            this.transactionId = id;
            this.nameOfCompany = company;
        }
    }

    public class TransactionQueue 
    {
        List<Transactions> tranny;

        public Transactions request(string r)
        {
            return tranny[0];
        }
        public void request(Transactions tranny)
        {
            enqueue(tranny);
        }
        private void enqueue(Transactions newItem)
        {
            tranny.Add(newItem);
        }
        private void dequeue()
        {
            tranny.RemoveAt(0);
        }
    }   
}
