namespace Prochef.Infrastructure.Entities
{
    public class RestaurantMenu 
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
