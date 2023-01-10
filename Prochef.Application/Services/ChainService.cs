
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Prochef.Application.Interfaces;
using Prochef.Core.Entities;
using Prochef.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Localization;
using Prochef.Application.Exceptions;
using Prochef.Core.Dtos.Request.Chains;
using Prochef.Core.Dtos.Response;

namespace Prochef.Application.Services
{
    public class ChainService : IChainService
    {
        private readonly IRepository<Chain> _chainRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly Func<IQueryable<Chain>, IIncludableQueryable<Chain, object>> _includes;
        private readonly IStringLocalizer _localizer; 

        public ChainService(IUnitOfWork uow, IMapper mapper, IStringLocalizer localizer)
        {
            _uow = uow;
            _mapper = mapper;
            _chainRepository = uow.GetRepository<Chain>();
            _includes = chains => chains.Include(chain => chain.Restaurants);
            _localizer = localizer;
        }

        public IEnumerable<ChainResponse> GetAllChains()
        {
            var chainDtos = _chainRepository.GetAll(_includes)
                                                        .Select(chainEntity => _mapper.Map<ChainResponse>(chainEntity))
                                                        .ToList();
            return chainDtos;
        }

        public int CreateChain(UpsertChainRequest chainRequest)
        {
            var chainEntity = _chainRepository.FindWithDeleted(chain => chain.Name == chainRequest.Name)
                .FirstOrDefault();
            if (chainEntity != null)
            {
                throw new AlreadyExistsException<Chain>(_localizer["Chain with such name already exists."]);
            }

            chainEntity = _mapper.Map<Chain>(chainRequest);
            _chainRepository.Create(chainEntity);
            _uow.Save();

            return chainEntity.Id;
        }

        public int UpdateChain(UpsertChainRequest chainRequest, int chainId)
        {
            var chainEntity = _chainRepository.FindWithDeleted(chain => chain.Id == chainId)
                                              .FirstOrDefault();
            _ = chainEntity ?? throw new NotFoundException<Chain>(_localizer["Chain with id was not found"]);

            chainEntity = _mapper.Map<Chain>(chainRequest);
            chainEntity.Id = chainId;
            _chainRepository.Update(chainEntity);
            _uow.Save();

            return chainEntity.Id;
        }

        public void DeleteChain(int chainId)
        {
            _ = _chainRepository.FindWithDeleted(ch => ch.Id == chainId).FirstOrDefault() ??
                throw new NotFoundException<Chain>(_localizer["Chain with id was not found."]);

            _chainRepository.SoftDelete(chainId);
            _uow.Save();
        }
    }
}
