using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Localization;
using Prochef.Application.Exceptions;
using Prochef.Application.Interfaces;
using Prochef.Core.Dtos.Request.Chains;
using Prochef.Core.Dtos.Request.Upsert;
using Prochef.Core.Dtos.Response;
using Prochef.Core.Entities;
using Prochef.Core.Interfaces.Repositories;

namespace Prochef.Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRepository<Restaurant> _restRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer _localizer;
        private readonly Func<IQueryable<Restaurant>, IIncludableQueryable<Restaurant, object>> _includes;

        public RestaurantService(IUnitOfWork uow, IMapper mapper, IStringLocalizer localizer)
        {
            _uow = uow;
            _mapper = mapper;
            _restRepository = uow.GetRepository<Restaurant>();
            _localizer = localizer;
            _includes = restaurants => restaurants.Include(rest => rest.Chain);
        }

        public IEnumerable<RestaurantResponse> GetAllRestaurants()
        {
            return _restRepository.GetAll(_includes)
                                  .Select(restEntity => _mapper.Map<RestaurantResponse>(restEntity))
                                  .ToList(); ;
        }

        public int CreateRestaurant(UpsertRestaurantRequest restRequest)
        {
            var restEntity = _restRepository.FindWithDeleted(rest => rest.Name == restRequest.Name && rest.Address == restRequest.Address)
                .FirstOrDefault();
            if (restEntity != null)
            {
                throw new AlreadyExistsException<Restaurant>(_localizer["Restaurant with such name and address already exists."]);
            }

            restEntity = _mapper.Map<Restaurant>(restRequest);
            _restRepository.Create(restEntity);
            _uow.Save();

            return restEntity.Id;
        }

        public int UpdateRestaurant(UpsertRestaurantRequest restRequest, int restId)
        {
            var restEntity = _restRepository.FindWithDeleted(rest => rest.Id == restId)
                                              .FirstOrDefault();
            _ = restEntity ?? throw new NotFoundException<Chain>(_localizer["Restaurants with id was not found."]);

            restEntity = _mapper.Map<Restaurant>(restRequest);
            restEntity.Id = restId;
            _restRepository.Update(restEntity);
            _uow.Save();

            return restEntity.Id;
        }

        public void DeleteRestaurant(int restId)
        {
            _ = _restRepository.FindWithDeleted(r => r.Id == restId).FirstOrDefault() ??
                throw new NotFoundException<Chain>(_localizer["Restaurants with id was not found."]);

            _restRepository.SoftDelete(restId);
            _uow.Save();
        }
    }
}
