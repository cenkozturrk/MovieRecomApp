using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BaseEntity
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        //Kaydı gerçekte silmeyeceğiz. Sadece aktif durumdan pasif duruma çekeceğiz.(Soft Delete)
        public bool IcActive { get; set; }
    }
}
