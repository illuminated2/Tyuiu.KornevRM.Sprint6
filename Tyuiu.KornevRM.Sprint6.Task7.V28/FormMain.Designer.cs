namespace Tyuiu.KornevRM.Sprint6.Task7.V28
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_KRM = new Panel();
            groupBoxCondition_KRM = new GroupBox();
            labelCondition_KRM = new Label();
            panelTask_KRM = new Panel();
            buttonInfo_KRM = new Button();
            buttonSaveFile_KRM = new Button();
            buttonDone_KRM = new Button();
            buttonOpenFile_KRM = new Button();
            panelOutPut_KRM = new Panel();
            groupBoxOutPut_KRM = new GroupBox();
            dataGridViewOut_KRM = new DataGridView();
            panelInPut_KRM = new Panel();
            groupBoxInPut_KRM = new GroupBox();
            dataGridViewIn_KRM = new DataGridView();
            openFileDialog_KRM = new OpenFileDialog();
            saveFileDialogMatrix_KRM = new SaveFileDialog();
            toolTipButton_KRM = new ToolTip(components);
            label1 = new Label();
            panelButtons_KRM.SuspendLayout();
            groupBoxCondition_KRM.SuspendLayout();
            panelTask_KRM.SuspendLayout();
            panelOutPut_KRM.SuspendLayout();
            groupBoxOutPut_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KRM).BeginInit();
            panelInPut_KRM.SuspendLayout();
            groupBoxInPut_KRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KRM).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_KRM
            // 
            panelButtons_KRM.Controls.Add(groupBoxCondition_KRM);
            panelButtons_KRM.Controls.Add(panelTask_KRM);
            panelButtons_KRM.Dock = DockStyle.Top;
            panelButtons_KRM.Location = new Point(0, 0);
            panelButtons_KRM.Margin = new Padding(3, 4, 3, 4);
            panelButtons_KRM.Name = "panelButtons_KRM";
            panelButtons_KRM.Size = new Size(1340, 315);
            panelButtons_KRM.TabIndex = 0;
            // 
            // groupBoxCondition_KRM
            // 
            groupBoxCondition_KRM.Controls.Add(label1);
            groupBoxCondition_KRM.Controls.Add(labelCondition_KRM);
            groupBoxCondition_KRM.Dock = DockStyle.Top;
            groupBoxCondition_KRM.Location = new Point(0, 172);
            groupBoxCondition_KRM.Margin = new Padding(3, 4, 3, 4);
            groupBoxCondition_KRM.Name = "groupBoxCondition_KRM";
            groupBoxCondition_KRM.Padding = new Padding(3, 4, 3, 4);
            groupBoxCondition_KRM.Size = new Size(1340, 132);
            groupBoxCondition_KRM.TabIndex = 1;
            groupBoxCondition_KRM.TabStop = false;
            groupBoxCondition_KRM.Text = "Условие: ";
            groupBoxCondition_KRM.Enter += groupBoxCondition_KRM_Enter;
            // 
            // labelCondition_KRM
            // 
            labelCondition_KRM.AutoSize = true;
            labelCondition_KRM.Dock = DockStyle.Fill;
            labelCondition_KRM.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition_KRM.Location = new Point(3, 24);
            labelCondition_KRM.Name = "labelCondition_KRM";
            labelCondition_KRM.Size = new Size(0, 23);
            labelCondition_KRM.TabIndex = 0;
            // 
            // panelTask_KRM
            // 
            panelTask_KRM.Controls.Add(buttonInfo_KRM);
            panelTask_KRM.Controls.Add(buttonSaveFile_KRM);
            panelTask_KRM.Controls.Add(buttonDone_KRM);
            panelTask_KRM.Controls.Add(buttonOpenFile_KRM);
            panelTask_KRM.Dock = DockStyle.Top;
            panelTask_KRM.Location = new Point(0, 0);
            panelTask_KRM.Margin = new Padding(3, 4, 3, 4);
            panelTask_KRM.Name = "panelTask_KRM";
            panelTask_KRM.Size = new Size(1340, 172);
            panelTask_KRM.TabIndex = 0;
            // 
            // buttonInfo_KRM
            // 
            buttonInfo_KRM.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_KRM.Location = new Point(1215, 41);
            buttonInfo_KRM.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_KRM.Name = "buttonInfo_KRM";
            buttonInfo_KRM.Size = new Size(115, 104);
            buttonInfo_KRM.TabIndex = 3;
            buttonInfo_KRM.Text = "Справка";
            buttonInfo_KRM.UseVisualStyleBackColor = true;
            buttonInfo_KRM.Click += buttonInfo_KRM_Click;
            // 
            // buttonSaveFile_KRM
            // 
            buttonSaveFile_KRM.Enabled = false;
            buttonSaveFile_KRM.Location = new Point(289, 41);
            buttonSaveFile_KRM.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_KRM.Name = "buttonSaveFile_KRM";
            buttonSaveFile_KRM.Size = new Size(124, 104);
            buttonSaveFile_KRM.TabIndex = 2;
            buttonSaveFile_KRM.Text = "Скопировать";
            toolTipButton_KRM.SetToolTip(buttonSaveFile_KRM, " Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.\r\n\r\n\r\n");
            buttonSaveFile_KRM.UseVisualStyleBackColor = true;
            buttonSaveFile_KRM.Click += buttonSaveFile_KRM_Click;
            // 
            // buttonDone_KRM
            // 
            buttonDone_KRM.Anchor = AnchorStyles.Left;
            buttonDone_KRM.Enabled = false;
            buttonDone_KRM.Location = new Point(156, 41);
            buttonDone_KRM.Margin = new Padding(3, 4, 3, 4);
            buttonDone_KRM.Name = "buttonDone_KRM";
            buttonDone_KRM.Size = new Size(111, 104);
            buttonDone_KRM.TabIndex = 1;
            buttonDone_KRM.Text = "Отправить";
            toolTipButton_KRM.SetToolTip(buttonDone_KRM, "Изменить в седьмой строке числа не равные 13 на 0. Результат вывести в объект dataGridViewOut.");
            buttonDone_KRM.UseVisualStyleBackColor = true;
            buttonDone_KRM.Click += buttonDone_KRM_Click;
            // 
            // buttonOpenFile_KRM
            // 
            buttonOpenFile_KRM.Location = new Point(29, 41);
            buttonOpenFile_KRM.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_KRM.Name = "buttonOpenFile_KRM";
            buttonOpenFile_KRM.Size = new Size(107, 104);
            buttonOpenFile_KRM.TabIndex = 0;
            buttonOpenFile_KRM.Text = "Загрузить";
            toolTipButton_KRM.SetToolTip(buttonOpenFile_KRM, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_KRM.UseVisualStyleBackColor = true;
            buttonOpenFile_KRM.Click += buttonOpenFile_KRM_Click;
            // 
            // panelOutPut_KRM
            // 
            panelOutPut_KRM.Controls.Add(groupBoxOutPut_KRM);
            panelOutPut_KRM.Dock = DockStyle.Fill;
            panelOutPut_KRM.Location = new Point(677, 315);
            panelOutPut_KRM.Margin = new Padding(3, 4, 3, 4);
            panelOutPut_KRM.Name = "panelOutPut_KRM";
            panelOutPut_KRM.Size = new Size(663, 670);
            panelOutPut_KRM.TabIndex = 2;
            panelOutPut_KRM.Paint += panelOutPut_KRM_Paint;
            // 
            // groupBoxOutPut_KRM
            // 
            groupBoxOutPut_KRM.Controls.Add(dataGridViewOut_KRM);
            groupBoxOutPut_KRM.Dock = DockStyle.Fill;
            groupBoxOutPut_KRM.Location = new Point(0, 0);
            groupBoxOutPut_KRM.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutPut_KRM.Name = "groupBoxOutPut_KRM";
            groupBoxOutPut_KRM.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutPut_KRM.Size = new Size(663, 670);
            groupBoxOutPut_KRM.TabIndex = 0;
            groupBoxOutPut_KRM.TabStop = false;
            groupBoxOutPut_KRM.Text = "Вывод:";
            // 
            // dataGridViewOut_KRM
            // 
            dataGridViewOut_KRM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KRM.Dock = DockStyle.Fill;
            dataGridViewOut_KRM.Location = new Point(3, 24);
            dataGridViewOut_KRM.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOut_KRM.Name = "dataGridViewOut_KRM";
            dataGridViewOut_KRM.RowHeadersVisible = false;
            dataGridViewOut_KRM.RowHeadersWidth = 51;
            dataGridViewOut_KRM.RowTemplate.Height = 24;
            dataGridViewOut_KRM.Size = new Size(657, 642);
            dataGridViewOut_KRM.TabIndex = 0;
            // 
            // panelInPut_KRM
            // 
            // ...
            // Здесь должен быть оставшийся код для panelInPut_KRM
            // 
            // panelInPut_DDA
            // 
            // 
            // panelInPut_KRM
            // 
            panelInPut_KRM.Controls.Add(groupBoxInPut_KRM);
            panelInPut_KRM.Dock = DockStyle.Left;
            panelInPut_KRM.Location = new Point(0, 315);
            panelInPut_KRM.Margin = new Padding(3, 4, 3, 4);
            panelInPut_KRM.Name = "panelInPut_KRM";
            panelInPut_KRM.Size = new Size(677, 670);
            panelInPut_KRM.TabIndex = 3;
            // 
            // groupBoxInPut_KRM
            // 
            groupBoxInPut_KRM.Controls.Add(dataGridViewIn_KRM);
            groupBoxInPut_KRM.Dock = DockStyle.Fill;
            groupBoxInPut_KRM.Location = new Point(0, 0);
            groupBoxInPut_KRM.Margin = new Padding(3, 4, 3, 4);
            groupBoxInPut_KRM.Name = "groupBoxInPut_KRM";
            groupBoxInPut_KRM.Padding = new Padding(3, 4, 3, 4);
            groupBoxInPut_KRM.Size = new Size(677, 670);
            groupBoxInPut_KRM.TabIndex = 0;
            groupBoxInPut_KRM.TabStop = false;
            groupBoxInPut_KRM.Text = "Ввод:";
            // 
            // dataGridViewIn_KRM
            // 
            dataGridViewIn_KRM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KRM.Dock = DockStyle.Fill;
            dataGridViewIn_KRM.Location = new Point(3, 24);
            dataGridViewIn_KRM.Margin = new Padding(3, 4, 3, 4);
            dataGridViewIn_KRM.Name = "dataGridViewIn_KRM";
            dataGridViewIn_KRM.RowHeadersVisible = false;
            dataGridViewIn_KRM.RowHeadersWidth = 51;
            dataGridViewIn_KRM.RowTemplate.Height = 24;
            dataGridViewIn_KRM.Size = new Size(671, 642);
            dataGridViewIn_KRM.TabIndex = 0;
            // 
            // openFileDialog_KRM
            // 
            openFileDialog_KRM.FileName = "openFileDialog1";
            openFileDialog_KRM.FileOk += openFileDialog_KRM_FileOk;
            // 
            // toolTipButton_KRM
            // 
            toolTipButton_KRM.IsBalloon = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(1176, 40);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1340, 985);
            Controls.Add(panelOutPut_KRM);
            Controls.Add(panelInPut_KRM);
            Controls.Add(panelButtons_KRM);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Корнев Р.М.";
            panelButtons_KRM.ResumeLayout(false);
            groupBoxCondition_KRM.ResumeLayout(false);
            groupBoxCondition_KRM.PerformLayout();
            panelTask_KRM.ResumeLayout(false);
            panelOutPut_KRM.ResumeLayout(false);
            groupBoxOutPut_KRM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KRM).EndInit();
            panelInPut_KRM.ResumeLayout(false);
            groupBoxInPut_KRM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KRM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_KRM;
        private System.Windows.Forms.GroupBox groupBoxCondition_KRM;
        private System.Windows.Forms.Label labelCondition_KRM;
        private System.Windows.Forms.Panel panelTask_KRM;
        private System.Windows.Forms.Panel panelOutPut_KRM;
        private System.Windows.Forms.Panel panelInPut_KRM;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KRM;
        private System.Windows.Forms.DataGridView dataGridViewOut_KRM;
        private System.Windows.Forms.GroupBox groupBoxInPut_KRM;
        private System.Windows.Forms.DataGridView dataGridViewIn_KRM;
        private System.Windows.Forms.Button buttonDone_KRM;
        private System.Windows.Forms.Button buttonOpenFile_KRM;
        private System.Windows.Forms.Button buttonInfo_KRM;
        private System.Windows.Forms.Button buttonSaveFile_KRM;
        private System.Windows.Forms.OpenFileDialog openFileDialog_KRM;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KRM;
        private System.Windows.Forms.ToolTip toolTipButton_KRM;
        private Label label1;
    }
}
