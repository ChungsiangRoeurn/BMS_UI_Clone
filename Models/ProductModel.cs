
namespace BMS_Clone.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";

        public string Description { get; set; } = "";

        public string Category { get; set; } = "";

        public string Brand { get; set; } = "";

        public decimal Price { get; set; }

        public double Rating { get; set; }

        public int Stock { get; set; }

        public string Thumbnail { get; set; } = "";
    }
}
