namespace KonusarakOgren.WepApp.DTOs
{
    public class ProductDto
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }
    }
}
