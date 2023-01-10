

namespace Prochef.Core.Dtos.Request.Upsert
{
    public class UpsertRestaurantRequest
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int ChainId { get; set; }
        public int MenuId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
