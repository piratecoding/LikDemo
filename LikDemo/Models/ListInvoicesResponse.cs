namespace LikDemo.Models
{
    public class ListInvoicesResponse
    {
        public InvoiceResource[] Data { get; set; }
        public Error[] Errors { get; set; } 
    }
}
