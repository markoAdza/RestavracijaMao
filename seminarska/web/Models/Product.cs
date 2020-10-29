using System.Text.Json;
using System.Text.Json.Serialization;

namespace web.Models
{

    public class Product
    {
        public string Id { get; set; }

        public string img { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int[] Ratings { get; set; }

        public Product()
        {

        }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }

    }

}