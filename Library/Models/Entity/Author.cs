using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models.Entity
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên tác giả không được để trống")]
        public string TenTacGia { get; set; } = string.Empty;

        public int NamSinh { get; set; }
        public string? QuocTich { get; set; }

        public string? Mota { get; set; }
    }
}