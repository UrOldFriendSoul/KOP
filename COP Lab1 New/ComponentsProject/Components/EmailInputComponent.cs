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

namespace COP_Lab1_New.Components
{
    public partial class EmailInputComponent : UserControl
    {
        private event EventHandler textBoxTextChanged;
        private ToolTip t = new ToolTip();

        public string example = "example@gmail.com";
        public void SetToolTip(string example)
        {
            toolTipExamle.SetToolTip(textBox, example);
        }
        public String Pattern { get; set; } = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                                                            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        public String TextElement
        {
            get
            {
                if (Regex.IsMatch(textBox.Text, Pattern))
                {
                    return textBox.Text;
                }
                else
                {
                    throw new Exception("Wrong value");
                }
            }
            set
            {
                if (Regex.IsMatch(value, Pattern))
                {
                    textBox.Text = value;
                }
            }
        }
        public event EventHandler TextBoxTextChanged
        {
            add { textBoxTextChanged += value; }
            remove { textBoxTextChanged -= value; }
        }

        /*Конструктор*/
        public EmailInputComponent()
        {
            InitializeComponent();
        }
    }
}
