using System.ComponentModel.DataAnnotations;

namespace coreuygulama.Models
{
    public class Yazarlar
    {
        [Key]
        public int Id {  get; set; }

        [Required(ErrorMessage ="boş geçilemez"),StringLength(100)]
        public string YazarId {  get; set; }

        public string YazarBilgi { get; set; }

        public ICollection<Kitaplar> Kitaplar { get; set; }
    }
}
