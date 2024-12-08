using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KornevRM.Sprint6.Task2.V9.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task2.V9
{
   
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void textBoxTask_SDA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_SDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_SDA.Text);
                int stopValue = Convert.ToInt32(textBoxStop_SDA.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_SDA.Titles.Add("График функции (3x - 1.5) / (sin(x) - 3 + x) +2 ");
                this.chartFunction_SDA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_SDA.ChartAreas[0].AxisY.Title = "Ось Y";


                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_SDA.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartFunction_SDA.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewFunction_SDA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_SDA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SDA.BackColor = Color.Red;
        }

        private void buttonDone_SDA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SDA.BackColor = Color.Green;
        }

        private void buttonDone_SDA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SDA.BackColor = Color.Blue;
        }

        private void buttonInfo_SDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСПб-24-1 Корнев Руслан Максимович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
