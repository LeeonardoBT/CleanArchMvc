using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById(int? id);
        Task<ProductDTO> GetProductCategoryById(int? id);

        Task Create(ProductDTO productDTO);
        Task Update(ProductDTO productDTO);
        Task Remove(int? IDproductDTO);
    }
}
