using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTShop.Model.Model
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }// required: không được null

        public int? DisplayOrder { set; get; }// ?: có thể null hoặc không null


        public int GroupID { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; } // "GroupID" sẽ trỏ đến khóa chính của bảng MenuGroup

        [MaxLength(10)]
        public string Target { set; get; }

        public bool Status { set; get; }
    }
}