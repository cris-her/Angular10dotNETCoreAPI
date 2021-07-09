using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class TransactionResult
    {
        //[JsonProperty("vci")]
        public string Vci { get; set; }
        //[JsonProperty("amount")]
        public decimal Amount { get; set; }
        //[JsonProperty("status")]
        public string Status { get; set; }
        //[JsonProperty("buy_order")]
        public string BuyOrder { get; set; }
        //[JsonProperty("session_id")]
        public string SessionId { get; set; }
        //[JsonProperty("card_detail")]
        public CardDetail CardDetail { get; set; }
        //[JsonProperty("accounting_date")]
        public string AccountingDate { get; set; }
        //[JsonProperty("transaction_date")]
        public DateTime TransactionDate { get; set; }
        //[JsonProperty("authorization_code")]
        public string AuthorizationCode { get; set; }
        //[JsonProperty("payment_type_code")]
        public string PaymentTypeCode { get; set; }
        //[JsonProperty("response_code")]
        public int ResponseCode { get; set; }
        //[JsonProperty("installments_amount")]
        public int InstallmentsAmount { get; set; }
        //[JsonProperty("installments_number")]
        public int InstallmentsNumber { get; set; }
        //[JsonProperty("balance")]
        public decimal Balance { get; set; }
    }
}
