﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace NotVisualComponents2.HelperModels
{
    public class WordTitleColumn
    {
        public string Name { get; set; }
        public decimal Width { get; set; }
        public PropertyInfo PropertyInfo { get; set; }
        public FieldInfo FieldInfo { get; set; }
    }
}