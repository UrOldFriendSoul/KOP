using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;
using NotVisualComponents2.HelperModels;

namespace NotVisualComponents2
{
    public partial class WordComponentLinearDiagram : Component
    {
        public WordComponentLinearDiagram()
        {
            InitializeComponent();
        }

        public WordComponentLinearDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        public void Report(string fileName, string title, string nameDiagram, ChartLegendPosition chartLegendPosition, List<Test> data)
        {
            if (String.IsNullOrEmpty(fileName) || String.IsNullOrEmpty(title) || String.IsNullOrEmpty(nameDiagram) || data.Count == 0)
            {
                throw new Exception("Поля не заполнены");
            }
            CreateDoc(fileName, title, nameDiagram, chartLegendPosition, data);

        }
        private void CreateDoc(string fileName, string title, string nameDiagram, ChartLegendPosition chartLegendPosition, List<Test> data)
        {
            try
            {
                DocX document = DocX.Create(fileName);
                document.InsertParagraph(title);
                document.Paragraphs[0].Direction = Direction.RightToLeft;
                document.Paragraphs[0].Alignment = Alignment.center;
                document.Paragraphs[0].FontSize(20);
                document.Paragraphs[0].Bold();
                document.InsertChart(CreateLinearChart(chartLegendPosition, nameDiagram, data));
                document.Save();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static Chart CreateLinearChart(ChartLegendPosition chartLegendPosition, string nameDiagram, List<Test> data)
        {
            // создаём линейную диаграмму
            LineChart lineChart = new LineChart();
            // добавляем легенду 
            lineChart.AddLegend(chartLegendPosition, false);
            Series seriesFirst = new Series(nameDiagram);
            // заполняем данными
            seriesFirst.Bind(data, "name", "value");
            // создаём набор данных и добавляем на диаграмму
            lineChart.AddSeries(seriesFirst);
            return lineChart;
        }
    }
}
