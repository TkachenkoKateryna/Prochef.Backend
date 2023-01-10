
namespace Prochef.Core.Dtos.Request.Chains
{
    public class UpsertChainRequest
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool IsDeleted { get; set; }
    }
}
