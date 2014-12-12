using System.Collections.Generic;

namespace FreeAgent
{
    /// <summary>
    /// TODO: Attachments
    /// </summary
    public class BankTransactionExplanation : UpdatableModel
    {
        public string bank_account { get; set; }
        
        public string bank_transaction{ get; set; }

        public double manual_sales_tax_amount { get; set; }

        public string dated_on { get; set; }

        public string description { get; set; }

        public double gross_value { get; set; }
        
        public double foreign_currency_value { get; set; }

        public string paid_invoice { get; set; }

        public string paid_bill { get; set; }

        public string paid_user { get; set; }

//        public string transfer_bank_account { get; set; }

        public int asset_life_years { get; set; }

    }

    public class BankTransactionExplanationWrapper
    {
        public BankTransactionExplanationWrapper()
        {
            bank_transaction_explanation = null;
        }

        public BankTransactionExplanation bank_transaction_explanation { get; set; }

    }

    public class BankTransactionExplanationsWrapper
    {
        public BankTransactionExplanationsWrapper()
        {
            bank_transaction_explanations = new List<BankTransactionExplanation>();
        }

        public List<BankTransactionExplanation> bank_transaction_explanations { get; set; }
    }
}