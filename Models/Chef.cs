namespace CloudKitchen.Models
{
    public class Chef
    {
        public int ChefId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public List<Order>? Orders { get; set; }
    }
}