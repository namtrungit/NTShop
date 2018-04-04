using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTShop.Model.Model
{
    public class Error
    {

        public int ID { set; get; }
        public string Message { set; get; }
        public string StackTrace { set; get;}
        public DateTime CreatedDate { set; get; }
    }
}
