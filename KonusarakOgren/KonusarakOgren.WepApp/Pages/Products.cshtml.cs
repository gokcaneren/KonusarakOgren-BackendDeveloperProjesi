using KonusarakOgren.WepApp.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;

namespace KonusarakOgren.WepApp.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly IHttpClientFactory httpClientFactory;
        [BindProperty]
        public List<ProductDto> Products { get; set; }
        public ProductsModel(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task OnGetAsync()
        {
            var httpClient = httpClientFactory.CreateClient("MyWebAPI");
            Products = await httpClient.GetFromJsonAsync<List<ProductDto>>("Products");
        }
    }
}
