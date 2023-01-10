
using System.Collections.Generic;
using Prochef.Core.Dtos.Request.Products;
using Prochef.Core.Dtos.Response;

namespace Prochef.Application.Interfaces
{
    public interface IProductService
    {
        int AddProduct(UpsertProductRequest product);
        int UpdateProduct(UpsertProductRequest product, int productId);
        void DeleteProduct(int productId);
        IEnumerable<ProductResponse> GetAllProducts();
        IEnumerable<ProductResponse> GetProductsByPlace(string placeName);
        IEnumerable<ProductResponse> GetProductsByState(string state);
        IEnumerable<ProductResponse> GetProductsByCategory(string categoryName);
    }
}
