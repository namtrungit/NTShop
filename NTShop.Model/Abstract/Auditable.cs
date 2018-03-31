using System;
using System.ComponentModel.DataAnnotations;

namespace NTShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]//Độ dài trong database
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        public bool Status { set; get; }
    }
}