using OnlineStoreDatabaseImplement.Logics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsControlLibraryKutygin;

namespace COP_Lab3.MainPlug
{
    public partial class FormOrder : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private OrderLogic orderLogic = new OrderLogic();
        private StatusLogic statusLogic = new StatusLogic();
        private bool flagChanges = false;

        public FormOrder()
        {
            InitializeComponent();
            var statuses = statusLogic.Read(null);
            var strStatuses = new List<string>();
            foreach (var status in statuses)
            {
                strStatuses.Add(status.StatusName);
            }
            dropDownListControl.FillList(strStatuses);
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = orderLogic.Read(new OnlineStoreDatabaseImplement.Models.OrderViewModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxFIO.Text = view.FIO;
                        textBoxDescription.Text = view.Description;
                        dropDownListControl.ChoosenLine = view.Status;
                        inputComponent.Number = view.Summary;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void SmthChanged(object sender, EventArgs e)
        {
            flagChanges = true;
        }
        private void FormOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flagChanges)
            {
                if (MessageBox.Show("Сохранить изменения перед закрытием?", "Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Save();
                }
            }
        }
        private void Save()
        {
            if (textBoxFIO.Text != "" && dropDownListControl.ChoosenLine != "")
            {
                flagChanges = false;
                if (id != null)
                {
                    orderLogic.Update(new OnlineStoreDatabaseImplement.Models.OrderViewModel()
                    {
                        Id = id,
                        FIO = textBoxFIO.Text,
                        Description = textBoxDescription.Text,
                        Status = dropDownListControl.ChoosenLine,
                        Summary = inputComponent.Number
                    });
                }
                else
                {
                    orderLogic.Create(new OnlineStoreDatabaseImplement.Models.OrderViewModel()
                    {
                        FIO = textBoxFIO.Text,
                        Description = textBoxDescription.Text,
                        Status = dropDownListControl.ChoosenLine,
                        Summary = inputComponent.Number
                    });
                }
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Все поля обязательны к заполнению");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
