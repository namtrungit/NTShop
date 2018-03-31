using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTShop.Model.Model
{
    [Table("Footers")] //Tên bảng sẽ dc ren ra trong MsSQL
    public class Footer
    {
        [Key]//Thuộc tính
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]//Thuộc tính
        public string Content { set; get; }
    }
}