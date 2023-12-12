using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabukovDV.Sprint6.TAsk5.V19.Lib;

namespace Tyuiu.ShabukovDV.Sprint6.TAsk5.V19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\InPutFileTask5V19.txt";

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KDG.ColumnCount = 2;
            dataGridViewResult_KDG.Columns[0].Width = 20;
            dataGridViewResult_KDG.Columns[1].Width = 50;

            this.chart1.ChartAreas[0].AxisX.Title = " Ось X";
            this.chart1.ChartAreas[0].AxisY.Title = " Ось Y";

            chart1.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KDG.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chart1.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KDG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТБ-23-1 Шабуков Данил Валерьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
