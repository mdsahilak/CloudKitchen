using System.Text.Json.Serialization;

namespace CloudKitchen.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string DeliveryName { get; set; }

        public string DeliveryAddress { get; set; }

        public List<int>? OrderedIds { get; set; }

        public int KitchenId { get; set; }
        
        public int DriverId { get; set; }
        
        [JsonIgnore]
        public Kitchen? Kitchen { get; set; }
        
        [JsonIgnore]
        public Driver? Driver { get; set; }
    }
}