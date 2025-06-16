using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace coreuygulama.Models
{
    public class Turler
    {
        [Key]
        public int id {  get; set; }

        [StringLength(100),Required,DisplayName("Kitabın Türü")]
        public string kitapturu { get; set; }
        
        //public Kitaplar kitaplar { get; set; }
        public ICollection<Kitaplar> kitaplar { get; set; }//bire çok ilişki

        
    }
}
