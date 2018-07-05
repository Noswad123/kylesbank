using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class bankAccount
        {
            public int Balance { get; set; }
            public string accountHolder { get; set; }
            public int accountIdNumber { get; set; }
            public bool isMember { get; set; }

            public void transaction(int trans)
            {

            }
        }
        public class savingsAccount : bankAccount
        {
            public int interestRate { get; set; }

            public void interestCharge()
            {
                var interest = Balance * interestRate;
                transaction(interest);
            }
        }
        public class checkingAccount : bankAccount
        {
            public int serviceFee { get; set; }

            public void yearlyFee()
            {
                var yearlyCharge = 100;
                transaction(yearlyCharge);
            }
        }
        public class transactions :bankAccount
        {
            public int amount { get; set; }
            public int transactionId { get; set; }
            public string nameOfCompany { get; set; }

        }
        
        public class que :bankAccount
        {
            List<transactions> tranny;

            public void request(string r)
            {
            }
            public void request(transactions tranny)
            {
            }
            private void enque(transactions newItem)
            {
            }
            private void Deque()
            {
            }
        }

    }
}
