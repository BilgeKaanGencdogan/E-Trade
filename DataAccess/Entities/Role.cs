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
    public class Role : Record // Rol
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public List<User> Users { get; set; } // 1 to many ilişkili başka entity kolleksiyonuna referans, 1 rolün 0 veya daha çok kullanıcısı olabilir
    }
}
