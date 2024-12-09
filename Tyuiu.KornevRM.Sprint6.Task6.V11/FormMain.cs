using Tyuiu.KornevRM.Sprint6.Task6.V11.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonLoad_ZAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZAA.Filter = "Text|*.txt";
            if (openFileDialogTask_ZAA.ShowDialog() == DialogResult.OK)
            {
                groupBoxInputData_ZAA.Text = "Ввод: " + openFileDialogTask_ZAA.FileName;
                using (StreamReader reader = new StreamReader(openFileDialogTask_ZAA.FileName))
                {
                    textBoxInputData_ZAA.Text = reader.ReadToEnd();
                    buttonDone_ZAA.Enabled = true;
                }
            }
        }

        private void buttonDone_ZAA_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxOutputData_ZAA.Text = ds.CollectTextFromFile(openFileDialogTask_ZAA.FileName);
            }
            catch
            {
                MessageBox.Show("Неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }

}
