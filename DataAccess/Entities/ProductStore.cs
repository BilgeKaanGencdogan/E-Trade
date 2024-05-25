using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Bases;
using static System.Formats.Asn1.AsnWriter;

namespace DataAccess.Entities
{
    public class ProductStore : Record // Ürün Mağaza ara ilişki entity'sini Record'dan miras alarak oluşturuyoruz ki ihtiyaç halinde
                                       // kendi repository ve service'lerinde kullanabilelim
    {
        public int ProductId { get; set; } // Ürün entity'sinden ürün id'yi taşıyoruz ve mağaza id ile birlikte primary key olarak ilk sırada set ediyoruz

        public Product Product { get; set; }

        public int StoreId { get; set; } // Mağaza entity'sinden mağaza id'yi taşıyoruz ve ürün id ile birlikte primary key olarak ikinci sırada set ediyoruz

        public Store Store { get; set; }
    }

}
