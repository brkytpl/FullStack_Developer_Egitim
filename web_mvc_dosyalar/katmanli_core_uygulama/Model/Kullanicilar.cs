using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Kullanicilar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string kullaniciAd { get; set; }
        [Required]
        public string sifre {  get; set; }
        public string rol { get;set; }
    }
}
