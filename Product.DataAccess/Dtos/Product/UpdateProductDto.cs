﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Dtos.Product
{
    public class UpdateProductDto
    {
        public long ProductStatusId { get; set; } // Ürün Durum Id
        public string Title { get; set; } = string.Empty; // Başlık
        public string Sku { get; set; } = string.Empty; // Stok Kodu
        public string TitleDomestic { get; set; } = string.Empty; // Yerel Başlık
        public bool HasVideo { get; set; } // Video Var mı
        public int Stock { get; set; } // Stok
        public string CurrencyName { get; set; } = string.Empty; // Para Birimi Adı
    }
}
