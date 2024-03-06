using System.Text.Json.Serialization;

namespace CloudKitchen.Models
{
    public class Driver
    {
        public int DriverId { get; set; }

        // public int KitchenId { get; set; }
        
        public string Name { get; set; }

        public string Phone { get; set; }
        
        public string Email { get; set; }
        
        // [JsonIgnore]
        // public Kitchen? Kitchen { get; set; }

        // [JsonIgnore]
        // public ICollection<Order>? Orders { get; set; }
    }
}