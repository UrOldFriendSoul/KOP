using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineStoreDatabaseImplement.Logics;
using OnlineStoreDatabaseImplement.Models;
using Tools.Plugins;
using WindowsFormsControlLibrary;
using WinFormsControlLibrarySergeev.VisualControls;
using WindowsFormsControlLibraryKutygin;
using lab1COP;
using lab1COP.NonVisualComponents;
using lab1COP.NonVisualComponents.HelperModels;
using System.ComponentModel.Composition;
using COP_Lab3.MainPlugin;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Components;
using System.Xml.Linq;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using ComponentsLibraryFramework48;
using ComponentsLibraryFramework48.DocumentWithTable;
using ComponentsLibraryFramework48.Models;
using ComponentsLibraryFramework48.Core;
using ComponentsLibraryFramework48.Heplers;

namespace COP_Lab3.MainPlug
{
    [Export(typeof(IPluginsConvention))]
    public class MainPluginConvention : IPluginsConvention
    {

        private TreeCustom tree = new TreeCustom();
        List<string> orderList;
        
        List<string> config;
        private OrderLogic orderLogic;
        private StatusLogic statusLogic;
        public MainPluginConvention()   
        {
            orderLogic = new OrderLogic();
            var menu = new ContextMenuStrip();
            var status = new ToolStripMenuItem("Статусы");
            menu.Items.Add(status);
            status.Click += (sender, e) =>
            {
                var formProduct = new FormStatus();
                formProduct.ShowDialog();
            };
            tree.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            tree.Dock = DockStyle.Fill;
            tree.ContextMenuStrip = menu;
            ReloadData();
        }
        public string PluginName
        {
            get
            {
                return "Заказы";
            }
        }
        public UserControl GetControl
        {
            get
            {
                return tree;
            }
        }

        public PluginsConventionElement GetElement
        {
            get
            {
                return tree.GetSelectedNode<PluginsConventionElement>();
            }
        }
        public bool DeleteElement(PluginsConventionElement element)
        {
            try
            {
                orderLogic.Delete(new OrderViewModel() { Id = element.Id });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public void ReloadData()
        {
            tree.Clear();
            var list = orderLogic.Read(null);
            if (list.Count != 0)
            {
                tree.CreateTree(list, new List<string>() { "Id", "FIO", "Description", "Status", "Summary" });
            }
        }
            public System.Windows.Forms.Form GetForm(PluginsConventionElement element)
        {
            FormOrder formOrder = new FormOrder();
            if (element != null)
            {
                formOrder.Id = element.Id;
            }
            return formOrder;
        }
        public bool CreateSimpleDocument(PluginsConventionSaveDocument saveDocument)
        {
            WindowsFormsControlLibraryKutygin.NonVisualComponents.WordBigTextComponent btc = new WindowsFormsControlLibraryKutygin.NonVisualComponents.WordBigTextComponent();
            List<string> content = new List<string>();
            try
            {
                var orders = orderLogic.Read(null);
                foreach (var order in orders)
                {
                    if (order.Summary == null) 
                    { 
                        content.Add(order.FIO + " " + order.Description);
                    }
                }
                btc.Report(saveDocument.FileName, "orders with sales", content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool CreateTableDocument(PluginsConventionSaveDocument saveDocument)
        {
            //CustomTableComponent ctc = new CustomTableComponent();
            ComponentDocumentWithTableMultiHeaderPdf ctc = new ComponentDocumentWithTableMultiHeaderPdf();
            
            try
            {
                var list = orderLogic.Read(null);
                string title = "Заказы";
                List<OrderToTable> orderList = new List<OrderToTable>();

                foreach (var order in list)
                {
                    if (order.Summary != null)
                    {
                        orderList.Add(new OrderToTable
                        {
                            Id = order.Id,
                            FIO = order.FIO,
                            Status = order.Status,
                            Summary = order.Summary.ToString()
                        });
                    }
                    else
                    {
                        orderList.Add(new OrderToTable
                        {
                            Id = order.Id,
                            FIO = order.FIO,
                            Status = order.Status,
                            Summary = "Заказ оплачен скидками"
                        });

                    }
                }

                ctc.CreateDoc(new ComponentDocumentWithTableHeaderDataConfig<OrderToTable>
                {
                    FilePath = saveDocument.FileName,
                    Header = title,
                    ColumnsRowsWidth = new List<(int, int)> {(5, 10), (20, 10), (10, 10), (15, 10)},
                    Headers = new List<(int ColumnIndex, int RowIndex, string Header, string PropertyName)> 
                    {
                        (0, 0, "ID", "Id"),
                        (1, 0, "FIO", "FIO"),
                        (2, 0, "Summary", "Summary"),
                        (3, 0, "Status", "Status"),
                    },
                    Data = orderList
                });
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool CreateDiagramDocument(PluginsConventionSaveDocument saveDocument)
        {
            Components.UnvisualComponents.ExcelPieChartComponent epcc = new Components.UnvisualComponents.ExcelPieChartComponent();
            string title = "Отчет по заказам";
            string chartName = "Диаграмма";
            List<OrderViewModel> orderList = new List<OrderViewModel>();
            var list = orderLogic.Read(null);
            var statuses = new List<string>();
            var diagramInfo = new Dictionary<string, decimal>();
            string location = "Bottom";
            
            try
            {

                foreach (var order in list)
                {
                    if (order.Summary != null)
                    {
                        orderList.Add(new OrderViewModel
                        {
                            Id = order.Id,
                            FIO = order.FIO,
                            Status = order.Status,
                            Description  = order.Description,
                            Summary = order.Summary
                        });
                    }
                }

                for (int i = 0; i < orderList.Count; ++i)
                {
                    if (!statuses.Contains(orderList[i].Status))
                    {
                        statuses.Add(orderList[i].Status);
                    }
                }

                foreach (var status in statuses)
                {
                    decimal count = 0;
                    for (int i = 0; i < orderList.Count; ++i)
                    {
                        if (orderList[i].Status.Contains(status))
                        {
                            count += 1;
                        }
                    }
                    diagramInfo.Add(status, count);
                }

                epcc.CreateFile(saveDocument.FileName,
                                title,
                                chartName,
                                diagramInfo,
                                location);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
