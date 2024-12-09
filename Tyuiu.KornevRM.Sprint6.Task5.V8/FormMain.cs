using Tyuiu.KornevRM.Sprint6.Task5.V8.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task5.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\iLLum\source\repos\Tyuiu.KornevRM.Sprint6\Tyuiu.KornevRM.Sprint6.Task5.V8\bin\DebugInPutFileTask5V8.txt";

        private void buttonDone_PEI_Click(object sender, EventArgs e)
        {
            dataGrid_PEI.ColumnCount = 2;
            dataGrid_PEI.Columns[0].Width = 20;
            dataGrid_PEI.Columns[1].Width = 50;

            this.chartDiag_PEI.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_PEI.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_PEI.Series[0].Points.Clear();

            double[] array = new double[ds.len];
            array = ds.LoadFromDataFile(path);

            for (int i = 0; i < array.Length; i++)
            {
                dataGrid_PEI.Rows.Add(Convert.ToString(i), Convert.ToString(array[i]));
                chartDiag_PEI.Series[0].Points.AddXY(i, array[i]);
            }

        }

        private void buttonHelp_PEI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСПб-24-1 Корнев Руслан Максимович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_PEI_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
