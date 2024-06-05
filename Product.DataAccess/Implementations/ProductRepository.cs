using AutoMapper;
using Product.DataAccess.Context;
using Product.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
