using LikDemo.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace LikDemo.Services.Implementation
{
    public class InvoicesService : IInvoicesService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public InvoicesService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<ListInvoicesResponse> GetAll()
        {
            var client = _httpClientFactory.CreateClient("API");
            var response = await client.GetFromJsonAsync<ListInvoicesResponse>("Invoices");

            return response;
        }

        public async Task<HttpResponseMessage> CreateInvoice(CreateInvoiceRequest model)
        {
            var client = _httpClientFactory.CreateClient("API");
            var response = await client.PostAsJsonAsync("Invoices", model);

            return response;
        }
    }
}
