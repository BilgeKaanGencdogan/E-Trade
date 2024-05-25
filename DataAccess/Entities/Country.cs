using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Bases;
#nullable disable

namespace DataAccess.Entities
{
    public class Country : Record
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } // zorunlu

        public List<City> Cities { get; set; } // zorunlu, 1 to many ilişki, 1 ülkenin 0 veya daha çok şehri olabilir

        public List<UserDetail> UserDetails { get; set; } // 1 ülkenin 0 veya daha çok kullanıcı detayı (1'e 1 ilişki olduğu için kullanıcısı) olabilir
    }
}
