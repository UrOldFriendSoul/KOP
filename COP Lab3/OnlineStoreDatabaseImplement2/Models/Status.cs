using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStoreDatabaseImplement.Models
{
    public class Status
    {
        public int Id { get; set; }
        [Required]
        public string StatusName { get; set; }
    }
}
