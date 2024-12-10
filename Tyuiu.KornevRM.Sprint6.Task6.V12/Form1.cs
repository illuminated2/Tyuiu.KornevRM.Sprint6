using Tyuiu.KornevRM.Sprint6.Task6.V12.Lib;
namespace Tyuiu.KornevRM.Sprint6.Task6.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_PAO_Click(object sender, EventArgs e)
        {
            openFileDialogTask6_PAO.ShowDialog();
            openFilePath = openFileDialogTask6_PAO.FileName;
            textBoxInPutData_PAO.Text = File.ReadAllText(openFilePath);
            groupBoxInPutData_PAO.Text = groupBoxOutPutData_PAO.Text + " " + openFileDialogTask6_PAO.FileName;
            buttonDone_PAO.Enabled = true;
        }

        private void buttonDone_PAO_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_PAO.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_PAO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
