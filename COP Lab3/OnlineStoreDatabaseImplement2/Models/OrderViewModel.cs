using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace OnlineStoreDatabaseImplement.Models
{
    public class OrderViewModel
    {
        [DisplayName ("Идентификатор")]
        public int? Id { get; set; }
        [DisplayName("ФИО заказчика")]
        public string FIO { get; set; }
        [DisplayName("Описание")]
        public string Description { get; set; }
        [DisplayName("Статус заказа")]
        public string Status { get; set; }
        [DisplayName("Итоговая цена")]
        public int? Summary { get; set; }
    }
}
