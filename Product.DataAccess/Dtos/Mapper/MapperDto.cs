using AutoMapper;
using Product.DataAccess.Dtos.Product;
using Product.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Dtos.Mapper
{
    public class MapperDto : Profile
    {
        public MapperDto()
        {
            CreateMap<GetProductDto, ProductEntity>().ReverseMap();
            CreateMap<AddProductDto, ProductEntity>().ReverseMap();
        }
    }
}
