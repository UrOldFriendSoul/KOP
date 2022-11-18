using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OnlineStoreDatabaseImplement.Models
{
    public class StatusViewModel
    {
        public int? Id { get; set; }
        [DisplayName("Статус заказа")]
        public string StatusName { get; set; }
    }
}
