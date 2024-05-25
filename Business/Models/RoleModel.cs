using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Bases;
#nullable disable

namespace Business.Models
{
    public class RoleModel : Record
    {
        #region Entity'den Kopyalanan Özellikler
        [DisplayName("Role")]
        public string Name { get; set; }
        #endregion
    }
}
