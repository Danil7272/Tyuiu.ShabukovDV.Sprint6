using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShabukovDV.Sprint6.V16.Lib;

namespace Tyuiu.ShabukovDV.Sprint6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxDONE_KAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRESULTAT_KAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonVOPROS_KAN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТБ-23-1 Шабуков Д. В.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonToDo_KAN_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxRESULTAT_KAN.Text = Convert.ToString(ds.SaveToFileTextData(Convert.ToInt32(textBoxDONE_KAN.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные даннаые", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox_KAN_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDONE_KAN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
