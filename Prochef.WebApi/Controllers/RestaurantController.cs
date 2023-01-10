using System;
using Microsoft.AspNetCore.Mvc;
using Prochef.Application.Interfaces;
using Prochef.Core.Dtos.Request.Chains;
using Prochef.Core.Dtos.Request.Upsert;

namespace Prochef.WebApi.Controllers
{

    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restService;

        public RestaurantController(IRestaurantService restService)
        {
            _restService = restService;
        }

        [HttpGet("restaurants")]
        public IActionResult GetAllRestaurants()
        {
            return Json(_restService.GetAllRestaurants());
        }

        [HttpPost("restaurants/add")]
        public IActionResult AddRestaurant(UpsertRestaurantRequest restRequest)
        {
            try
            {
                _restService.CreateRestaurant(restRequest);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("restaurants/update")]
        public IActionResult UpdateRestaurant(UpsertRestaurantRequest restRequest, int restId)
        {
            try
            {
                _restService.UpdateRestaurant(restRequest, restId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("restaurants/delete")]
        public IActionResult DeleteRestaurant(int restId)
        {
            try
            {
                _restService.DeleteRestaurant(restId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
