using System.Text.Json.Serialization;

namespace CloudKitchen.Models
{
    public class Kitchen
    {
        public int KitchenId { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}