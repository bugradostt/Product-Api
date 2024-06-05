using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Product.DataAccess.Context;
using Product.DataAccess.Dtos.Product;
using Product.DataAccess.Dtos.Response;
using Product.DataAccess.Extensions;
using Product.DataAccess.Interfaces;
using Product.Entity.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Product.DataAccess.Implementations
{
    public class ProductRepository : IProductRepository
    {
        readonly IMapper _mapper;
        readonly AppDbContext _context;
        public ProductRepository(AppDbContext context, IMapper mapper)
        {

            _context = context;
            _mapper = mapper;
        }

        public async Task<ResponseDto<NoDataDto>> AddProductAsync(AddProductDto product)
        {
            try
            {
                var productMapper = _mapper.Map<ProductEntity>(product);
                //productMapper.ProductStatusName = StringExtensions.Encrypt(product);
                _context.Products.Add(productMapper);
                await _context.SaveChangesAsync();
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
                if (productStatusId == null)
                {
                    return ResponseDto<NoDataDto>.Fail("Product id cannot be empty!", 400, true);
                }

                var foundProduct = await _context.Products
                .Where(x => x.ProductStatusId == productStatusId)
                .FirstOrDefaultAsync();

                _context.Remove(foundProduct.ProductStatusId);
                await _context.SaveChangesAsync();

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
                var foundProduct = await _context.Products
                 .Where(x => x.ProductStatusId == productStatusId)
                 .FirstOrDefaultAsync();

                if (foundProduct == null)
                {
                    return ResponseDto<GetProductDto>.Fail("Record not found.", 404, true);
                }

             

                var mapperProduct = _mapper.Map<GetProductDto>(foundProduct);


                return ResponseDto<GetProductDto>.Success(mapperProduct, 200);


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

                var productList = await _context.Products
                .ToListAsync();

                var mapperProductList = _mapper.Map<List<GetProductDto>>(productList);


                foreach (var i in mapperProductList)
                {

                    //i. = StringExtensions.Decrypt(i.Name);

                }
                return ResponseDto<List<GetProductDto>>.Success(mapperProductList, 200);


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
               
                var foundProduct = await _context.Products
                .Where(x => x.ProductStatusId == product.ProductStatusId)
                .FirstOrDefaultAsync();

                if (foundProduct == null)
                {
                    return ResponseDto<NoDataDto>.Fail("Record not found.", 404, true);
                }

                //foundProduct.Name = StringExtensions.Encrypt(product.Name);


                _context.Products.Update(foundProduct);
                await _context.SaveChangesAsync();

                return ResponseDto<NoDataDto>.Success(200);
            }
            catch (Exception ex)
            {
                return ResponseDto<NoDataDto>.Fail(ex.Message, 500, true);
            }
        }
    }
}
