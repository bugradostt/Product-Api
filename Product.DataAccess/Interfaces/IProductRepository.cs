using Product.DataAccess.Dtos.Product;
using Product.DataAccess.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Interfaces
{
    public interface IProductRepository
    {
        Task<ResponseDto<List<GetProductDto>>> GetProductAsync();
        Task<ResponseDto<GetProductDto>> GetByProductIdAsync(long productStatusId);
        Task<ResponseDto<NoDataDto>> AddProductAsync(AddProductDto product);
        Task<ResponseDto<NoDataDto>> UpdateProductAsync(UpdateProductDto product);
        Task<ResponseDto<NoDataDto>> DeleteProductAsync(long productStatusId);

    }
}
