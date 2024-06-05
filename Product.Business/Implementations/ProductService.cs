using Product.Business.Interfaces;
using Product.DataAccess.Dtos.Product;
using Product.DataAccess.Dtos.Response;
using Product.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Product.Business.Implementations
{
    public class ProductService : IProductService
    {
        readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ResponseDto<NoDataDto>> AddProductAsync(AddProductDto product)
        {
            try
            {
                var response = await _productRepository.AddProductAsync(product);

                if (!response.IsSuccessful)
                {
                    // Birden fazla hata mesajını birleştirerek tek bir hata mesajı dizesine dönüştürün
                    string errorMessage = response.errors != null && response.errors.Errors.Count > 0
                        ? string.Join(Environment.NewLine, response.errors.Errors)
                        : "An error occurred";

                    return ResponseDto<NoDataDto>.Fail(errorMessage, 400, true);
                }

                return ResponseDto<NoDataDto>.Success(200);
            }
            catch (Exception ex)
            {
                return ResponseDto<NoDataDto>.Fail(ex.Message, 500, true);
            }
        }

        public async Task<ResponseDto<NoDataDto>> DeleteProductAsync(long productStatusId)
        {
            try
            {
                var response = await _productRepository.DeleteProductAsync(productStatusId);

                if (!response.IsSuccessful)
                {
                    // Birden fazla hata mesajını birleştirerek tek bir hata mesajı dizesine dönüştürün
                    string errorMessage = response.errors != null && response.errors.Errors.Count > 0
                        ? string.Join(Environment.NewLine, response.errors.Errors)
                        : "An error occurred";

                    return ResponseDto<NoDataDto>.Fail(errorMessage, 400, true);
                }

                return ResponseDto<NoDataDto>.Success(200);
            }
            catch (Exception ex)
            {
                return ResponseDto<NoDataDto>.Fail(ex.Message, 500, true);
            }
        }

        public async Task<ResponseDto<GetProductDto>> GetByProductIdAsync(long productStatusId)
        {
            try
            {
                var response = await _productRepository.GetByProductIdAsync(productStatusId);

                if (!response.IsSuccessful)
                {
                    // Birden fazla hata mesajını birleştirerek tek bir hata mesajı dizesine dönüştürün
                    string errorMessage = response.errors != null && response.errors.Errors.Count > 0
                        ? string.Join(Environment.NewLine, response.errors.Errors)
                        : "An error occurred";

                    return ResponseDto<GetProductDto>.Fail(errorMessage, 400, true);
                }

                return ResponseDto<GetProductDto>.Success(response.Data, 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<GetProductDto>.Fail(ex.Message, 500, true);
            }
        }

        public async Task<ResponseDto<List<GetProductDto>>> GetProductAsync()
        {
            try
            {
                var response = await _productRepository.GetProductAsync();

                if (!response.IsSuccessful)
                {
                    // Birden fazla hata mesajını birleştirerek tek bir hata mesajı dizesine dönüştürün
                    string errorMessage = response.errors != null && response.errors.Errors.Count > 0
                        ? string.Join(Environment.NewLine, response.errors.Errors)
                        : "An error occurred";

                    return ResponseDto<List<GetProductDto>>.Fail(errorMessage, 400, true);
                }

                return ResponseDto<List<GetProductDto>>.Success(response.Data, 200);
            }
            catch (Exception ex)
            {
                return ResponseDto<List<GetProductDto>>.Fail(ex.Message, 500, true);
            }
        }

        public async Task<ResponseDto<NoDataDto>> UpdateProductAsync(UpdateProductDto product)
        {
            try
            {
                var response = await _productRepository.UpdateProductAsync(product);

                if (!response.IsSuccessful)
                {
                    // Birden fazla hata mesajını birleştirerek tek bir hata mesajı dizesine dönüştürün
                    string errorMessage = response.errors != null && response.errors.Errors.Count > 0
                        ? string.Join(Environment.NewLine, response.errors.Errors)
                        : "An error occurred";

                    return ResponseDto<NoDataDto>.Fail(errorMessage, 400, true);
                }

                return ResponseDto<NoDataDto>.Success(200);
            }
            catch (Exception ex)
            {
                return ResponseDto<NoDataDto>.Fail(ex.Message, 500, true);
            }
        }
    }
}
