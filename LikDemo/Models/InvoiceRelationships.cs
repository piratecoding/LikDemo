namespace LikDemo.Models
{
    public class InvoiceRelationships
    {
        public Debtor Debtor { get; set; }
        public Creditor Creditor { get; set; }
        public InvoiceLine[] InvoiceLines { get; set; }
    }

}
