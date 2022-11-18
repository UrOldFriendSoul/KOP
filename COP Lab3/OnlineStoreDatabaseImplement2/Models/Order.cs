using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStoreDatabaseImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string FIO { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Status{ get; set; }
        public int? Summary { get; set; }
    }
}
