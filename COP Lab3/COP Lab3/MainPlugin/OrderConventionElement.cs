using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using OnlineStoreDatabaseImplement.Models;
using Tools.Plugins;

namespace COP_Lab3.MainPlugin
{
    public class OrderConventionElement : PluginsConventionElement
    {
        public string FIO { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int Summary { get; set; }
    }
}
