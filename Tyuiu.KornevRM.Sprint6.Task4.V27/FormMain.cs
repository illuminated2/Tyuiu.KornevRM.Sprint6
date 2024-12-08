using Tyuiu.KornevRM.Sprint6.Task4.V27.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task4.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonResult_KAS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KAS.Text);
                int stopStep = Convert.ToInt32(textBoxStop.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult_KAS.Text = "";

                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KAS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_KAS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ����-24-1 ������ ������ ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_KAS_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_KAS.Text);

                DialogResult dialogResult = MessageBox.Show("����" + path + "������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResult_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_KAS.BackColor = Color.Blue;
        }

        private void buttonResult_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_KAS.BackColor = Color.Red;
        }

        private void buttonResult_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_KAS.BackColor = Color.Lime;
        }
    }
}
