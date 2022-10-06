using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP_Lab1_New.Components
{
    /**Выпадающий список.
        Список заполняется
        через метод,
        передающий
        список строк

        Заполнить список можно через
        метод FillList (List<String> list)
        и списка строк
    */
    public partial class DropDownListControl : UserControl
    {
        public string ChoosenLine
        {
            set
            {
                int index = comboBox.Items.IndexOf(value);
                if (index != -1)
                {
                    comboBox.SelectedIndex = comboBox.Items.IndexOf(value);
                }
                else
                {
                    comboBox.SelectedIndex = -1;
                }
            }
            get
            {
                if (comboBox.SelectedIndex != -1)
                {
                    return (String)comboBox.SelectedItem;
                }
                else
                {
                    return String.Empty;
                }
            }
        }

        private event EventHandler _notify;
        public event EventHandler Notify
        {
            add { _notify += value; }
            remove { _notify -= value; }
        }

        public DropDownListControl()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            comboBox.SelectedValueChanged += _notify;
        }

        public void FillList(List<String> strs)
        {
            foreach (var str in strs)
            {
                comboBox.Items.Add(str);
            }
        }

        public void ClearList()
        {
            comboBox.Items.Clear();
        }
    }
}
