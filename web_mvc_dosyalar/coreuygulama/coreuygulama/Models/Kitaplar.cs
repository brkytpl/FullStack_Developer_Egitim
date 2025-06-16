using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreuygulama.Models
{
    public class Kitaplar
    {
        [Key]// primary key etribütü
        public int id {  get; set; }

        [StringLength(100),Required(ErrorMessage ="Boş geçilemez")]//karakter uzunluğu etribütü ve hata mesajı
        public string kitapadi { get; set; }

        [Range(1900,2025,ErrorMessage ="1900 ile 2025 arası değerler")]
        public int basimyili { get; set; }

        [ForeignKey("Turler")]
        public int turid {  get; set; }
        public Turler turler { get; set; }//birebir ilişki, birebir ilişki primary key ile yapılır
                                          //public ICollection<Turler> turlers { get; set; }//çoka çok

        [ForeignKey("Yazarlar")]
        public int YazarId { get; set; }
        public Yazarlar yazar { get; set; }
    }
}
