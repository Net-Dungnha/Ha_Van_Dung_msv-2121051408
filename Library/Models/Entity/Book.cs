using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models.Entity
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sách không được để trống")]
        public string TenSach { get; set; } = string.Empty;

        public string? ISBN { get; set; }

        public int NamXuatBan { get; set; }
        public string? NhaXuatBan { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        [ForeignKey("Categories")]
        public int CategoriesId { get; set; }
        public Categories? Categories { get; set; }

        public string? Mota { get; set; }
    }
}