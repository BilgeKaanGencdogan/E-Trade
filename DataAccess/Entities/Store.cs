using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

using DataAccess.Bases;
namespace DataAccess.Entities
{
    public class Store : Record // Mağaza
    {
        [Required]
        [StringLength(150)]
        [DisplayName("Store Name")]
        public string Name { get; set; }

        [DisplayName("Virtual")]
        public bool IsVirtual { get; set; }

        public List<ProductStore> ProductStores { get; set; } // many to many ilişki için ürün mağaza kolleksiyon referansı
    }
}
