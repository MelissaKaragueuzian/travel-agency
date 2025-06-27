using System;

namespace TravelAgency_Desktop.DbClasses
{
    public class CurrencyExchange
    {
        public int CurrencyExchangeID { get; set; }

        public int FromCurrencyID { get; set; }
        public Currency FromCurrency { get; set; }

        public int ToCurrencyID { get; set; }
        public Currency ToCurrency { get; set; }

        public float Amount { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime DateTo { get; set; }

        public int UserCreatedID { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DateCreated { get; set; }

        public int UserModifiedID { get; set; }
        public User ModifiedBy { get; set; }

        public DateTime DateModified { get; set; }
    }
}
