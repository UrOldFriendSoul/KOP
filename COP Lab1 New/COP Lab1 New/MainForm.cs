using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotVisualComponents2;
using NotVisualComponents2.HelperModels;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace COP_Lab1_New
{
    public partial class MainForm : Form
    {
        List<String> list = new List<string> {
            "Katyonok","Andrey","Zhenuya"
        };
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void fillComboBox_Click_1(object sender, EventArgs e)
{
   dropDownListControl.FillList(list);
}

private void clearComboBox_Click(object sender, EventArgs e)
{
   dropDownListControl.ClearList();
}

private void setEmail_Click(object sender, EventArgs e)
{
   String txtemail = "example@gmail.com";
   emailInputComponent1.TextElement = txtemail;
}

private void getEmail_Click(object sender, EventArgs e)
{
   try
   {
       if (emailInputComponent1.TextElement != null)
       {
           MessageBox.Show("Your email is " + emailInputComponent1.TextElement.ToString());
       }
       if (emailInputComponent1.TextElement == null)
       {
           MessageBox.Show("Your number is null");
       }
   }
   catch (Exception ex)
   {
       MessageBox.Show(ex.Message);
   }
}

private void fillList_Click(object sender, EventArgs e)
{
   List<FillObj> list = new List<FillObj>();
   list.Add(new FillObj { Name = "Andew", Surname = "Kutygin", Age = 10 });
   list.Add(new FillObj { Name = "Kate", Surname = "Belyaeva", Age = 11 });
   list.Add(new FillObj { Name = "Eugeniy", Surname = "Sergeev", Age = 12 });
   listBoxControl.Add(list);
}

private void button5_Click(object sender, EventArgs e)
{
   if (!String.IsNullOrEmpty(textBox1.Text))
   {
       listBoxControl.AddTemplate(textBox1.Text, '{', '}');
   }
}

        private void clearTemplate_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void clearList_Click(object sender, EventArgs e)
        {
            listBoxControl.GetItem<FillObj>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordComponentBigText wcb = new WordComponentBigText();
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Заполните заголовок", "Ошибка", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                return;
            }
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        List<string> list = new List<string>();
                        list.Add("Andrew123");
                        list.Add("12355");
                        list.Add("Eugeniy");
                        wcb.Report(fileName: dialog.FileName, title: textBox2.Text, list);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WordComponentTable2Rows t2r = new WordComponentTable2Rows();
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Заполните заголовок", "Ошибка", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                return;
            }
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {

                        List<WordTitleColumn> titleColumn = new List<WordTitleColumn>();
                        List<WordMergedTitleColumn> mergedTitleColumns = new List<WordMergedTitleColumn>();
                        List<Object> objects = new List<Object>();

                        FillObj c = new FillObj { Id = 1, Name = "Andrew", Surname = "Kutygin" };
                        objects.Add(c);
                        objects.Add(new FillObj { Id = 2, Name = "Kate", Surname = "Belyaeva" });
                        objects.Add(new FillObj { Id = 3, Name = "Zhenya", Surname = "Sergeev" });
                        Type type = c.GetType();
                        titleColumn.Add(new WordTitleColumn { Name = "Id", Width = 26, FieldInfo = type.GetField("Id") });
                        titleColumn.Add(new WordTitleColumn { Name = "Name", Width = 26, FieldInfo = type.GetField("Name") });
                        titleColumn.Add(new WordTitleColumn { Name = "Surname", Width = 40, FieldInfo = type.GetField("Surname") });
                        titleColumn.Add(new WordTitleColumn { Name = "Age", Width = 22, FieldInfo = type.GetField("Age") });

                        mergedTitleColumns.Add(new WordMergedTitleColumn
                        {
                            Columns = new int[] { 0, 1, 2 },
                            Title = "Common"
                        });
                        t2r.Report(fileName: dialog.FileName, title: textBox2.Text, titleColumn, mergedTitleColumns, objects);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Xceed.Words.NET.Licenser.LicenseKey = "WDNXX-XXXXX-XXXXX-XXXX";
            WordComponentLinearDiagram linearDiagram = new WordComponentLinearDiagram();
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Заполните заголовок", "Ошибка", MessageBoxButtons.OK,
                          MessageBoxIcon.Error);
                return;
            }
            using (var dialog = new SaveFileDialog { Filter = "docx|*.docx" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        List<Test> data = new List<Test>();
                        data.Add(new Test { name = "Построил", value = 1 });
                        data.Add(new Test { name = "диаграмму", value = 51 });
                        data.Add(new Test { name = "для", value = 11 });
                        data.Add(new Test { name = "3", value = 43 });
                        data.Add(new Test { name = "Лабы", value = 32 });
                        linearDiagram.Report(fileName: dialog.FileName, title: textBox2.Text, nameDiagram: "Diagram", ChartLegendPosition.Left, data);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonSetToolTip_Click(object sender, EventArgs e)
        {
            string example = "example@gmail.com";
            emailInputComponent1.SetToolTip(example);
        }
    }
}
