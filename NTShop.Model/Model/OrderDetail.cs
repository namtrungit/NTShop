using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NTShop.Model.Model
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [Key]
        public int ProductID { set; get; }

        public int Quanlity { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }


        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}