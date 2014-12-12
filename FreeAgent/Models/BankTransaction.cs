using System.Collections.Generic;

namespace FreeAgent
{
    public class BankTransaction : UpdatableModel
    {
        public string bank_account { get; set; }

        public double amount { get; set; }

        public string dated_on { get; set; }

        public string description { get; set; }

        public double unexplained_amount { get; set; }

        public bool is_manual { get; set; }

    }

    public class BankTransactionWrapper
    {
        public BankTransactionWrapper()
        {

            bank_transaction = null;
        }

        public BankTransaction bank_transaction { get; set; }

    }

    public class BankTransactionsWrapper
    {
        public BankTransactionsWrapper()
        {
            bank_transactions = new List<BankTransaction>();

        }

        public List<BankTransaction> bank_transactions { get; set; }
    }
}