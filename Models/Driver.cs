namespace CloudKitchen.Models
{
    public class Driver
    {
        public int DriverId { get; set; }
        
        public string Name { get; set; }

        public string Phone { get; set; }
        
        public string Email { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}