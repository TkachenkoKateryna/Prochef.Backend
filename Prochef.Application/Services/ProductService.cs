using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Localization;
using Microsoft.OpenApi.Extensions;
using Prochef.Application.Exceptions;
using Prochef.Application.Interfaces;
using Prochef.Core.Constants;
using Prochef.Core.Dtos.Request.Products;
using Prochef.Core.Dtos.Response;
using Prochef.Core.Entities;
using Prochef.Core.Interfaces.Repositories;

namespace Prochef.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _uow;
        private readonly IRepository<Product> _productRepository;
        private readonly Func<IQueryable<Product>, IIncludableQueryable<Product, object>> _includes;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer _localizer;

        public ProductService(IUnitOfWork uow, IMapper mapper, IStringLocalizer localizer)
        {
            _uow = uow;
            _productRepository = _uow.GetRepository<Product>();
            _includes = products => products.Include(p => p.Place)
                .Include(p => p.Category);
            _mapper = mapper;
            _localizer = localizer;
        }

        public IEnumerable<ProductResponse> GetAllProducts()
        {
            var products = _productRepository.GetAll(_includes)
                .Select(productEntity => _mapper.Map<ProductResponse>(productEntity))
                .ToList();

            return products;
        }

        public IEnumerable<ProductResponse> GetProductsByPlace(string placeName)
        {
            var products = _productRepository.GetAll(_includes)
                .Where(product => product.Place.Name == placeName)
                .Select(productEntity => _mapper.Map<ProductResponse>(productEntity))
                .ToList();

            return products;
        }

        public IEnumerable<ProductResponse> GetProductsByCategory(string categoryName)
        {
            var products = _productRepository.GetAll(_includes)
                .Where(product => product.Category.Name == categoryName)
                .Select(productEntity => _mapper.Map<ProductResponse>(productEntity))
                .ToList();

            return products;
        }

        public IEnumerable<ProductResponse> GetProductsByState(string state)
        {
            var products = _productRepository.GetAll(_includes)
                .Where(product => product.State.GetDisplayName() == state)
                .Select(productEntity => _mapper.Map<ProductResponse>(productEntity))
                .ToList();

            return products;
        }

        public int AddProduct(UpsertProductRequest productRequest)
        {
            var productEntity = _productRepository.FindWithDeleted(pr => pr.Name == productRequest.Name)
                .FirstOrDefault();
            if (productEntity != null)
            {
                throw new AlreadyExistsException<Product>(_localizer["Product with such name already exists."]);
            }

            productEntity = _mapper.Map<Product>(productRequest);
            if (productRequest.DeliveryDate == default(DateTime))
            {
                productEntity.DeliveryDate = DateTime.Now;
            }

            _productRepository.Create(productEntity);
            _uow.Save();

            return productEntity.Id;
        }

        public int UpdateProduct(UpsertProductRequest productRequest, int productId)
        {
            var productEntity = _productRepository.FindWithDeleted(pr => pr.Id == productId)
                .FirstOrDefault();
            _ = productEntity ?? throw new NotFoundException<Chain>(_localizer["Product with id was not found."]);

            productEntity = _mapper.Map<Product>(productRequest);
            productEntity.Id = productId;
            _productRepository.Update(productEntity);
            _uow.Save();

            return productEntity.Id;
        }

        public void DeleteProduct(int productId)
        {
            var productEntity = _productRepository.FindWithDeleted(pr => pr.Id == productId)
                .FirstOrDefault();
            _ = productEntity ?? throw new NotFoundException<Chain>(_localizer["Product with id was not found."]);

            _productRepository.SoftDelete(productId);
            _uow.Save();
        }
    }
}
