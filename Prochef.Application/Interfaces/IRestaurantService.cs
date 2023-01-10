using System;
using System.Collections.Generic;
using System.Text;
using Prochef.Core.Dtos.Request.Chains;
using Prochef.Core.Dtos.Request.Upsert;
using Prochef.Core.Dtos.Response;

namespace Prochef.Application.Interfaces
{
    public interface IRestaurantService
    {
        IEnumerable<RestaurantResponse> GetAllRestaurants();
        int CreateRestaurant(UpsertRestaurantRequest restRequest);
        int UpdateRestaurant(UpsertRestaurantRequest restRequest, int restId);
        void DeleteRestaurant(int restId);
    }
}
