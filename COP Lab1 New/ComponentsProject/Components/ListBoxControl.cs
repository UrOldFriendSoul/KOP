using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;

namespace COP_Lab1_New.Components
{
    public partial class ListBoxControl : UserControl
    {
        private List<string> layoutFields;

        private bool isField;

        // Символ начала шаблона свойства
        public char startSign;

        // Символ конца шаблона свойства
        public char endSign;

        // Макетная строка
        public string layout;

        public void AddTemplate(string layout, char startSign, char endSign)
        {
            string string2 = layout;
            this.startSign = startSign;
            this.endSign = endSign;
            while (string2.Contains(startSign))
            {
                    int startIndex = string2.IndexOf(startSign) + 1;
                    int endIndex = string2.IndexOf(endSign);
                    string field = string2.Substring(startIndex, endIndex - startIndex);
                    layoutFields.Add(field);
                string2 = string2.Substring(endIndex + 1);
            }
                isField = true;
            this.layout = layout;
        }

        [Category("Спецификация"), Description("CurrentIndex")]
        public int SelectedIndex
        {
            get
            {
                return listBox1.SelectedIndex;
            }
            set
            {
                listBox1.SelectedIndex = value;
            }
        }

        public T GetItem<T>() where T : new()
        {
            if (listBox1.SelectedIndex != -1)
            {
                string item = listBox1.SelectedItem.ToString();
                T t = new T();

                List<string> itemFields = new List<string>();
                while (item != "")
                {
                    int startIndex = item.IndexOf(startSign)+1;
                    int endIndex = item.IndexOf(endSign);
                    string field = item.Substring(startIndex, endIndex - startIndex);
                    itemFields.Add(field);
                    item = item.Substring(endIndex+1);
                }
                
                Type type = t.GetType();
                FieldInfo[] fields = type.GetFields();

                foreach (var f in fields)
                {
                    foreach (var lf in layoutFields)
                    {
                        foreach (var itemf in itemFields)
                        {
                            if (f.Name.Equals(lf))
                            {
                                Type fieldsType = type.GetField(lf).FieldType;
                                var replaceField = Convert.ChangeType(itemf, fieldsType);
                                type.GetField(lf).SetValue(t, replaceField);
                            }
                        }
         
                    }
                }
                return t;
            }
            return new T();
        }

        public void Add<T>(List<T> obj)
        {
            if (!isField)
            {
                throw new Exception("Поля не заполнены");
            }
            foreach (string field in layoutFields)
            {
                if (field.Equals(String.Empty))
                {
                    throw new Exception("Поля не заполнены");
                }
            }
            List<string> values = new List<string>();

            if (obj.Count == 0)
            {
                return;
            }

            Type type = obj[0].GetType();
            FieldInfo[] fields = type.GetFields();

            foreach (T o in obj)
            {
                values.Clear();
                foreach (var f in fields)
                {
                    foreach (var lf in layoutFields)
                    {
                        if (f.Name.Equals(lf))
                        {
                            values.Add(f.GetValue(o).ToString());
                        }
                    }
                }
                string str = layout;
                for (int i = 0; i < values.Count; i++)
                {
                    str = str.Replace(startSign + layoutFields[i] + endSign, values[i]);
                }
                listBox1.Items.Add(str);
                str = layout;
            }
        }
        public ListBoxControl()
        {
            InitializeComponent();
            layoutFields = new List<string>();
        }
    }
}
