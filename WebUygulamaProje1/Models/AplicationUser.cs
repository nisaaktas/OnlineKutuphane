using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebUygulamaProje1.Models
{
    public class AplicationUser :IdentityUser
    {
        [Required]
        public int OgrenciNo { get; set; }
        public string? Adres { get; set; }
        public string? Fakulte { get; set; }
        public string? Bolum { get; set; }

    }
}
