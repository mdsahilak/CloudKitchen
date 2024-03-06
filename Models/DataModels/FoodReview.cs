using System.Text.Json.Serialization;

namespace CloudKitchen.Models
{
    public class FoodReview
    {
        public int FoodReviewId { get; set; }

        // public int FoodItemId { get; set; }
        
        public int Rating { get; set; }

        public string Remarks { get; set; }

        // [JsonIgnore]
        // public FoodItem? FoodItem { get; set; }
    }
}