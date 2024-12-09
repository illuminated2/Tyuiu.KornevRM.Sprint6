using Tyuiu.KornevRM.Sprint6.Task5.V8.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task5.V8
{
   public partial class FormMain_HNA : Form
    {
        public FormMain_HNA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private static readonly string path = @"C:\DataSprint5\InPutFileTask5V8.txt";

        private void Lib1Uslovie_HNA_Click(object sender, EventArgs e)
        {

        }

        private void But1Vipolnit_HNA_Click(object sender, EventArgs e)
        {
            DGridViewTable_HNA.ColumnCount = 2;
            DGridViewTable_HNA.Columns[0].Width = 20;
            DGridViewTable_HNA.Columns[1].Width = 50;

            this.ChartTableGraf_HNA.ChartAreas[0].AxisX.Title = "Ось X";
            this.ChartTableGraf_HNA.ChartAreas[0].AxisY.Title = "Ось Y";

            ChartTableGraf_HNA.Series[0].Points.Clear();

            double[] numArray = new double[ds.len];
            numArray = ds.LoadFromDataFile(path);

            for (int i = 0; i < numArray.Length; i++)
            {
                DGridViewTable_HNA.Rows.Add(Convert.ToString(i), Convert.ToString(numArray[i]));
                ChartTableGraf_HNA.Series[0].Points.AddXY(i, numArray[i]);
            }
        }

        private void But2Sohranit_HNA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void But3Spavka_HNA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Такс 5 выполнил студент группы ИСПб-24-1 Корнев Руслан Максимович", "Справка");

        }
    }
}
