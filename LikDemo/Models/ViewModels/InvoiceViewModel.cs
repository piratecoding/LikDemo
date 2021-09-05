using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikDemo.Models.ViewModels
{
    public class InvoiceViewModel
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string NetAmount { get; set; }
        public string Currency { get; set; }
        public DateTime DueDate { get; set; }
    }
}
