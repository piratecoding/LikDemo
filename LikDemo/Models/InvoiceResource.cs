namespace LikDemo.Models
{
    public class InvoiceResource
    {
        public string Type { get; set; }
        public InvoiceAttributes Attributes { get; set; }
        public InvoiceRelationships Relationships { get; set; }
        public Identification[] Included { get; set; }
        public string Id { get; set; }
    }

}
