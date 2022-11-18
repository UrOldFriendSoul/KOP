using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStoreDatabaseImplement.Models;
using OnlineStoreDatabaseImplement.Logics;

namespace COP_Lab3.MainPlugin
{
    public partial class FormStatus : Form
    {
        StatusLogic statusLogic = new StatusLogic();
        List<StatusViewModel> list;
        public FormStatus()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                list = statusLogic.Read(null);
                if (list != null)
                {
                    dataGridViewStatus.DataSource = list;
                    dataGridViewStatus.Columns[0].Visible = false;
                    dataGridViewStatus.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormStatus_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridViewStatus_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var typeName = (string)dataGridViewStatus.CurrentRow.Cells[1].Value;
            if (!string.IsNullOrEmpty(typeName))
            {
                if (dataGridViewStatus.CurrentRow.Cells[0].Value != null)
                {
                    statusLogic.Update(new StatusViewModel()
                    {
                        Id = Convert.ToInt32(dataGridViewStatus.CurrentRow.Cells[0].Value),
                        StatusName = (string)dataGridViewStatus.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
                else
                {
                    statusLogic.Create(new StatusViewModel()
                    {
                        StatusName = (string)dataGridViewStatus.CurrentRow.Cells[1].EditedFormattedValue
                    });
                }
            }
            else
            {
                MessageBox.Show("Введена пустая строка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void dataGridViewStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Insert)
            {
                if (dataGridViewStatus.Rows.Count == 0)
                {
                    list.Add(new StatusViewModel());
                    dataGridViewStatus.DataSource = new List<StatusViewModel>(list);
                    dataGridViewStatus.CurrentCell = dataGridViewStatus.Rows[0].Cells[1];
                    return;
                }
                if (dataGridViewStatus.Rows[dataGridViewStatus.Rows.Count - 1].Cells[1].Value != null)
                {
                    list.Add(new StatusViewModel());
                    dataGridViewStatus.DataSource = new List<StatusViewModel>(list);
                    dataGridViewStatus.CurrentCell = dataGridViewStatus.Rows[dataGridViewStatus.Rows.Count - 1].Cells[1];
                    return;
                }
            }
            if (e.KeyData == Keys.Delete)
            {
                if (MessageBox.Show("Удалить выбранный элемент", "Удаление",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    statusLogic.Delete(new StatusViewModel() { Id = (int)dataGridViewStatus.CurrentRow.Cells[0].Value });
                    LoadData();
                }
            }
        }
    }
}
