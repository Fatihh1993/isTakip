using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kurtProje.ToDo.Web.Models
{
    public class KullaniciKayitViewModel
    {
        [Required]
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }
}
