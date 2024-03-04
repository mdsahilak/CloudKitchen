namespace CloudKitchen.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public DateTime Time { get; set; }
        
        public int CustomerId  { get; set; }

        public int ChefId  { get; set; }
        
        public int DriverId  { get; set; }

        public List<int>? OrderedItems { get; set; }
    }
}