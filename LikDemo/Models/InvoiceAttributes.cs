using System;

namespace LikDemo.Models
{
    public class InvoiceAttributes
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string ReferenceId { get; set; }
        public string CreditorReference { get; set; }
        public DateTime InvoiceExpirationDate { get; set; }
        public bool InvoiceFoundation { get; set; }
        public string Currency { get; set; }
        public float NetAmount { get; set; }
        public float GrossAmount { get; set; }
        public float Remainder { get; set; }
        public float VatAmount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Date { get; set; }
        public int CloseCode { get; set; }
        public int InvoiceStateOnClose { get; set; }
        public int InvoiceState { get; set; }
        public int InvoiceSource { get; set; }
        public int CloseCodeReason { get; set; }
        public int InvoiceSourceSystemType { get; set; }
        public string ClosesInvoiceMergedReferenceId { get; set; }
        public int InitialCampaignTypeRequest { get; set; }
        public string InvoiceComments { get; set; }
        public string InternalComments { get; set; }
        public int CurrentProduct { get; set; }
    }

}
