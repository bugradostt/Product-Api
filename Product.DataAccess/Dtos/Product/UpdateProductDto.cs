using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataAccess.Dtos.Product
{
    public class UpdateProductDto
    {
        public long ProductStatusId { get; set; } // Ürün Durum Id
        public string ProductStatusName { get; set; } = string.Empty; // Ürün Durum Adı
        public string ProductUrl { get; set; } = string.Empty; // Ürün Url
        public string Title { get; set; } = string.Empty; // Başlık
        public string Sku { get; set; } = string.Empty; // Stok Kodu
        public string TitleDomestic { get; set; } = string.Empty; // Yerel Başlık
        public bool HasVideo { get; set; } // Video Var mı
        public int Stock { get; set; } // Stok
        public string CurrencyName { get; set; } = string.Empty; // Para Birimi Adı
        public decimal Price { get; set; } // Fiyat
        public decimal PriceDiscountedDomestic { get; set; } // Yerel İndirimli Fiyat
        public decimal PriceDiscounted { get; set; } // İndirimli Fiyat
        public bool IsFeatured { get; set; } // Öne Çıkan mı
        public bool IsElonkyFeatured { get; set; } // Elonky Öne Çıkan mı
        public bool HasPersonalization { get; set; } // Kişiselleştirme Var mı
        public bool IsTaxable { get; set; } // Vergiye Tabi mi
        public bool? IsDigital { get; set; } // Dijital mi
    }
}
