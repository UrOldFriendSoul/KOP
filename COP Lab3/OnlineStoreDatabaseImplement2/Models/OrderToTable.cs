using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreDatabaseImplement.Models
{
    public class OrderToTable
    {
        public int? Id { get; set; }
        public string FIO { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
    }
}

