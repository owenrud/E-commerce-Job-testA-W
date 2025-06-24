using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TestInterviewApp.Models
{
    public class Cart
    {
        [Key]
        public int Cart_Id { get; set; }
        public int Id_product { get; set; }
        public string nama { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }

        [ForeignKey("Id_product")]
        public Products Products { get; set; }
    }
}
