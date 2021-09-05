using System;
using System.ComponentModel.DataAnnotations;

namespace LikDemo.Models
{
    public class CreateInvoiceRequest
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public CreateInvoiceDebtorRequest Debtor { get; set; }
        public string ReferenceId { get; set; }
        public string CreditorReference { get; set; }
        public string Currency { get; set; }
        public string Comment { get; set; }
        public int CampaignInitialRequest { get; set; }
        public Line[] Lines { get; set; }
        public DateTime? DebtCollectionWarningDate { get; set; }
        public DateTime? DebtRegisterWarningDate { get; set; }
    }
}
