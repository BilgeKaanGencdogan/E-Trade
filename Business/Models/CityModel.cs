using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Bases;
#nullable disable

namespace Business.Models
{
    public class CityModel : Record
    {
        #region Entity'den Kopyalanan Özellikler
        [Required(ErrorMessage = "{0} is required!")]
        [StringLength(150, ErrorMessage = "{0} must be maximum {1} characters!")]
        [DisplayName("City Name")]
        public string Name { get; set; }

        [DisplayName("Country")]
        public int CountryId { get; set; }
        #endregion
    }
}
