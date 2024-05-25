using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Bases;
using DataAccess.Enums;
#nullable disable

namespace DataAccess.Entities
{
    public class UserDetail : Record // Kullanıcı Detayı entity'sini Record'dan miras alarak oluşturuyoruz ki ihtiyaç halinde
                                     // kendi repository ve service'lerinde kullanabilelim,
                                     // User ile arasında 2. yöntemden farklı olarak 1'e çoklu ilişki var
    {
        public int UserId { get; set; } // zorunlu, User ile 1 to many ilişki olduğu için User'ın Id'sini buraya UserId foreign key'i olarak taşıdık

        public User User { get; set; } // 1 veya daha çok kullanıcı detayı 1 kullanıyıca ait olmalı

        public Sex Sex { get; set; }

        [Required]
        [StringLength(250)]
        public string Email { get; set; } // zorunlu

        [StringLength(25)]
        public string Phone { get; set; } // zorunlu değil

        [Required]
        [StringLength(750)]
        public string Address { get; set; } // zorunlu

        public int CountryId { get; set; } // ülke id, zorunlu

        public Country Country { get; set; } // Ülke ile Kullanıcı Detayı arasında 1 to many ilişki var, 1 kullanıcı detayının mutlaka 1 ülkesi olmalı

        public int CityId { get; set; } // şehir id, zorunlu

        public City City { get; set; } // Şehir ile Kullanıcı Detayı arasında 1 to many ilişki var, 1 kullanıcı detayının mutlaka 1 şehri olmalı
    }
}
