using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebUygulamaProje1.Models
{
    public class KitapTuru
    {
        [Key]  //primary key
        public int Id { get; set; }
        [Required(ErrorMessage ="Kitap Tür Adı Boş Bırakılamaz")]  //NOT-NULL
        [MaxLength(25)]
        [DisplayName("kitap Türü Adı")]
        public string Ad { get; set; }
    }
}
