using System.Text.Json.Serialization;

namespace CloudKitchen.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime Time { get; set; }
        
        public int CustomerId { get; set; }

        public int ChefId { get; set; }
        
        public int DriverId { get; set; }

        public List<FoodItem>? OrderedItems { get; set; }

        [JsonIgnore]
        public Customer? Customer { get; set; }

        [JsonIgnore]
        public Chef? Chef { get; set; }

        [JsonIgnore]
        public Driver? Driver { get; set; }
    }
}