namespace CloudKitchen.Models
{
    public class FoodItem
    {
        public int FoodItemId { get; set; }
        
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}