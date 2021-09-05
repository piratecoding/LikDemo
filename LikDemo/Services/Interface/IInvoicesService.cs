using LikDemo.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace LikDemo.Services.Implementation
{
    public interface IInvoicesService
    {
        Task<ListInvoicesResponse> GetAll();
        Task<HttpResponseMessage> CreateInvoice(CreateInvoiceRequest model);
    }
}