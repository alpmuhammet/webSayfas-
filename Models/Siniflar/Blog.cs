using System.ComponentModel.DataAnnotations;

namespace Web_Ödevii.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int id { get; set; }
        public string baslik { get; set; }
        public string kategori { get; set; }
        public string aciklama { get; set; }
        public string yazar { get; set; }
        public string imagefile { get; set; }

    }
}