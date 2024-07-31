using System.ComponentModel.DataAnnotations;

namespace Web_Ödevii.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
    }
}