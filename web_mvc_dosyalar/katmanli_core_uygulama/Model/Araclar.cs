using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Araclar
    {
        [Key]
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model {  get; set; }
        public decimal Fiyat { get; set; }
        [ForeignKey("AracTuru")]
        public int TurId {  get; set; }
        public AracTuru AracTuru { get; set; }
    }
}
