using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository ?? 
                throw new ArgumentNullException(nameof(productRepository));

            _mapper = mapper;
        }

        public async Task Create(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.CreateAsync(productEntity);
        }

        public async Task<ProductDTO> GetProductById(int? id)
        {
            var productEntity = await _productRepository.GetProductByIdAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<ProductDTO> GetProductCategoryById(int? id)
        {
            var productEntity = await _productRepository.GetProductCategoryByIdAsync(id);
            return _mapper.Map<ProductDTO>(productEntity);
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            var productsEntity = await _productRepository.GetProductsAsync();
            return _mapper.Map<IEnumerable<ProductDTO>>(productsEntity);
        }

        public async Task Remove(int? id)
        {
            var productEntity = _productRepository.GetProductByIdAsync(id).Result;
            await _productRepository.RemoveAsync(productEntity);
        }

        public async Task Update(ProductDTO productDTO)
        {
            var productEntity = _mapper.Map<Product>(productDTO);
            await _productRepository.UpdateAsync(productEntity);
        }
    }
}
