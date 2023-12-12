using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabukovDV.Sprint6.Task4.V15.Lib;

namespace Tyuiu.ShabukovDV.Sprint6.Task4.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void DBox3Vivod_HNA_Enter(object sender, EventArgs e)
        {

        }

        private void TBox3Res_HNA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(TBox1Start_HNA.Text);
                int stopValue = Convert.ToInt32(TBox2Stop_HNA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;


                double[] wait = new double[len];
                wait = ds.GetMassFunction(startValue, stopValue);

                this.chart1.ChartAreas[0].AxisX.Title = "Ось X";
                this.chart1.ChartAreas[0].AxisY.Title = "Ось Y";

                TBox3Res_HNA.Text = "";

                chart1.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chart1.Series[0].Points.AddXY(startValue, wait[i]);
                    TBox3Res_HNA.AppendText(wait[i] + Environment.NewLine);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студент группы СМАРТб-23-1 Шабуков Данил Валереьвич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V15.txt";
                File.WriteAllText(path, TBox3Res_HNA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + "сохранен успешно!\n Открыть его в блокноте ?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранение файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
