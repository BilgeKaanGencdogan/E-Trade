﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Bases;
#nullable disable

namespace DataAccess.Entities
{
    public class User : Record // Kullanıcı
    {
        [Required]
        [StringLength(15)]
        public string UserName { get; set; } // zorunlu

        [Required]
        [StringLength(10)]
        public string Password { get; set; } // zorunlu

        public bool IsActive { get; set; } // zorunlu, sadece aktif kullanıcıların (IsActive = true) uygulamaya giriş yapmasını sağlamak için bu özellik kullanılır,
                                           // kullanıcının uygulama üzerinden aktifliği kaldırıldığında (IsActive = false) artık uygulamaya giriş yapamayacaktır

        public int RoleId { get; set; } // zorunlu, 1 to many ilişki (1 kullanıcının mutlaka 1 rolü olmalı)

        public Role Role { get; set; }



        // 1. yöntem: UserDetail entity'sindeki 1. yönteme göre
        public List<UserDetail> UserDetails { get; set; } // 1 kullanıcının 0, 1 veya daha çok ilişkili kullanıcı detayı olabilir

        // 2. yöntem: UserDetail entity'sindeki 2. yönteme göre
        //public UserDetail UserDetail { get; set; } // 1 kullanıcının 0 veya 1 ilişkili kullanıcı detayı olabilir
    }
}
