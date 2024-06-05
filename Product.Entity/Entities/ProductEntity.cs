using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Entity.Entities
{
    public class ProductEntity
    {
        [Key]
        public long ProductStatusId { get; set; } // Ürün Durum Id
        public string ProductStatusName { get; set; } = string.Empty; // Ürün Durum Adı
        public string ProductUrl { get; set; } = string.Empty; // Ürün Url
        public string Title { get; set; } = string.Empty; // Başlık
        public string TitleDomestic { get; set; } = string.Empty; // Yerel Başlık
        public string DescriptionDomestic { get; set; } = string.Empty; // Yerel Açıklama
        public string Sku { get; set; } = string.Empty; // Stok Kodu
        public string Barcode { get; set; } = string.Empty; // Barkod
        public string OtherCode { get; set; } = string.Empty; // Diğer Kod
        public int Stock { get; set; } // Stok
        public string CurrencyName { get; set; } = string.Empty; // Para Birimi Adı
        public decimal Price { get; set; } // Fiyat
        public decimal PriceDiscountedDomestic { get; set; } // Yerel İndirimli Fiyat
        public decimal PriceDiscounted { get; set; } // İndirimli Fiyat
        public bool IsFeatured { get; set; } // Öne Çıkan mı
        public bool IsElonkyFeatured { get; set; } // Elonky Öne Çıkan mı
        public bool HasVideo { get; set; } // Video Var mı
        public bool HasPersonalization { get; set; } // Kişiselleştirme Var mı
        public bool IsTaxable { get; set; } // Vergiye Tabi mi
        public string WhenMade { get; set; } = string.Empty; // Yapıldığı Zaman
        public string WhoMade { get; set; } = string.Empty; // Kim Yaptı
        public string PersonalizationDescription { get; set; } = string.Empty; // Kişiselleştirme Açıklaması
        public bool? IsDigital { get; set; } // Dijital mi

    }
}
