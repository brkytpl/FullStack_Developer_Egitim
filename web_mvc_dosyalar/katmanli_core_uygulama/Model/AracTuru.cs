using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class AracTuru
    {
        [Key]
        public int Id { get; set; }
        public string AracTur {  get; set; }
        public string MotorGucu { get; set; }
        
        public ICollection<Araclar> araclar { get; set; }
    }
}
