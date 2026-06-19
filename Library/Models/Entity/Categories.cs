using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DemoMVC.Models.Entity
{
    public class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên thể loại không được để trống")]
        public string TenTheLoai { get; set; } = string.Empty;

        public string? Mota { get; set; }
    }
}