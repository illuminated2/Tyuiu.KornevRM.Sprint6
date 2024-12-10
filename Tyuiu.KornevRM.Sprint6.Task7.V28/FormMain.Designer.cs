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
            panelButtons_DDA = new Panel();
            groupBoxCondition_DDA = new GroupBox();
            labelCondition_DDA = new Label();
            panelTask_DDA = new Panel();
            buttonInfo_DDA = new Button();
            buttonSaveFile_DDA = new Button();
            buttonDone_DDA = new Button();
            buttonOpenFile_DDA = new Button();
            panelOutPut_DDA = new Panel();
            groupBoxOutPut_DDA = new GroupBox();
            dataGridViewOut_DDA = new DataGridView();
            panelInPut_DDA = new Panel();
            groupBoxInPut_DDA = new GroupBox();
            dataGridViewIn_DDA = new DataGridView();
            openFileDialog_DDA = new OpenFileDialog();
            saveFileDialogMatrix_DDA = new SaveFileDialog();
            toolTipButton_DDA = new ToolTip(components);
            label1 = new Label();
            panelButtons_DDA.SuspendLayout();
            groupBoxCondition_DDA.SuspendLayout();
            panelTask_DDA.SuspendLayout();
            panelOutPut_DDA.SuspendLayout();
            groupBoxOutPut_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_DDA).BeginInit();
            panelInPut_DDA.SuspendLayout();
            groupBoxInPut_DDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_DDA).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_DDA
            // 
            panelButtons_DDA.Controls.Add(groupBoxCondition_DDA);
            panelButtons_DDA.Controls.Add(panelTask_DDA);
            panelButtons_DDA.Dock = DockStyle.Top;
            panelButtons_DDA.Location = new Point(0, 0);
            panelButtons_DDA.Margin = new Padding(3, 4, 3, 4);
            panelButtons_DDA.Name = "panelButtons_DDA";
            panelButtons_DDA.Size = new Size(1340, 315);
            panelButtons_DDA.TabIndex = 0;
            // 
            // groupBoxCondition_DDA
            // 
            groupBoxCondition_DDA.Controls.Add(label1);
            groupBoxCondition_DDA.Controls.Add(labelCondition_DDA);
            groupBoxCondition_DDA.Dock = DockStyle.Top;
            groupBoxCondition_DDA.Location = new Point(0, 172);
            groupBoxCondition_DDA.Margin = new Padding(3, 4, 3, 4);
            groupBoxCondition_DDA.Name = "groupBoxCondition_DDA";
            groupBoxCondition_DDA.Padding = new Padding(3, 4, 3, 4);
            groupBoxCondition_DDA.Size = new Size(1340, 132);
            groupBoxCondition_DDA.TabIndex = 1;
            groupBoxCondition_DDA.TabStop = false;
            groupBoxCondition_DDA.Text = "Условие: ";
            groupBoxCondition_DDA.Enter += groupBoxCondition_DDA_Enter;
            // 
            // labelCondition_DDA
            // 
            labelCondition_DDA.AutoSize = true;
            labelCondition_DDA.Dock = DockStyle.Fill;
            labelCondition_DDA.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCondition_DDA.Location = new Point(3, 24);
            labelCondition_DDA.Name = "labelCondition_DDA";
            labelCondition_DDA.Size = new Size(0, 23);
            labelCondition_DDA.TabIndex = 0;
            // 
            // panelTask_DDA
            // 
            panelTask_DDA.Controls.Add(buttonInfo_DDA);
            panelTask_DDA.Controls.Add(buttonSaveFile_DDA);
            panelTask_DDA.Controls.Add(buttonDone_DDA);
            panelTask_DDA.Controls.Add(buttonOpenFile_DDA);
            panelTask_DDA.Dock = DockStyle.Top;
            panelTask_DDA.Location = new Point(0, 0);
            panelTask_DDA.Margin = new Padding(3, 4, 3, 4);
            panelTask_DDA.Name = "panelTask_DDA";
            panelTask_DDA.Size = new Size(1340, 172);
            panelTask_DDA.TabIndex = 0;
            // 
            // buttonInfo_DDA
            // 
            buttonInfo_DDA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_DDA.Location = new Point(1215, 41);
            buttonInfo_DDA.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_DDA.Name = "buttonInfo_DDA";
            buttonInfo_DDA.Size = new Size(115, 104);
            buttonInfo_DDA.TabIndex = 3;
            buttonInfo_DDA.Text = "Справка";
            buttonInfo_DDA.UseVisualStyleBackColor = true;
            buttonInfo_DDA.Click += buttonInfo_DDA_Click;
            // 
            // buttonSaveFile_DDA
            // 
            buttonSaveFile_DDA.Enabled = false;
            buttonSaveFile_DDA.Location = new Point(289, 41);
            buttonSaveFile_DDA.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_DDA.Name = "buttonSaveFile_DDA";
            buttonSaveFile_DDA.Size = new Size(124, 104);
            buttonSaveFile_DDA.TabIndex = 2;
            buttonSaveFile_DDA.Text = "Скопировать";
            toolTipButton_DDA.SetToolTip(buttonSaveFile_DDA, " Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.\r\n\r\n\r\n");
            buttonSaveFile_DDA.UseVisualStyleBackColor = true;
            buttonSaveFile_DDA.Click += buttonSaveFile_DDA_Click;
            // 
            // buttonDone_DDA
            // 
            buttonDone_DDA.Anchor = AnchorStyles.Left;
            buttonDone_DDA.Enabled = false;
            buttonDone_DDA.Location = new Point(156, 41);
            buttonDone_DDA.Margin = new Padding(3, 4, 3, 4);
            buttonDone_DDA.Name = "buttonDone_DDA";
            buttonDone_DDA.Size = new Size(111, 104);
            buttonDone_DDA.TabIndex = 1;
            buttonDone_DDA.Text = "Отправить";
            toolTipButton_DDA.SetToolTip(buttonDone_DDA, "Изменить в седьмой строке числа не равные 13 на 0. Результат вывести в объект dataGridViewOut.");
            buttonDone_DDA.UseVisualStyleBackColor = true;
            buttonDone_DDA.Click += buttonDone_DDA_Click;
            // 
            // buttonOpenFile_DDA
            // 
            buttonOpenFile_DDA.Location = new Point(29, 41);
            buttonOpenFile_DDA.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_DDA.Name = "buttonOpenFile_DDA";
            buttonOpenFile_DDA.Size = new Size(107, 104);
            buttonOpenFile_DDA.TabIndex = 0;
            buttonOpenFile_DDA.Text = "Загрузить";
            toolTipButton_DDA.SetToolTip(buttonOpenFile_DDA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_DDA.UseVisualStyleBackColor = true;
            buttonOpenFile_DDA.Click += buttonOpenFile_DDA_Click;
            // 
            // panelOutPut_DDA
            // 
            panelOutPut_DDA.Controls.Add(groupBoxOutPut_DDA);
            panelOutPut_DDA.Dock = DockStyle.Fill;
            panelOutPut_DDA.Location = new Point(677, 315);
            panelOutPut_DDA.Margin = new Padding(3, 4, 3, 4);
            panelOutPut_DDA.Name = "panelOutPut_DDA";
            panelOutPut_DDA.Size = new Size(663, 670);
            panelOutPut_DDA.TabIndex = 2;
            panelOutPut_DDA.Paint += panelOutPut_DDA_Paint;
            // 
            // groupBoxOutPut_DDA
            // 
            groupBoxOutPut_DDA.Controls.Add(dataGridViewOut_DDA);
            groupBoxOutPut_DDA.Dock = DockStyle.Fill;
            groupBoxOutPut_DDA.Location = new Point(0, 0);
            groupBoxOutPut_DDA.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutPut_DDA.Name = "groupBoxOutPut_DDA";
            groupBoxOutPut_DDA.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutPut_DDA.Size = new Size(663, 670);
            groupBoxOutPut_DDA.TabIndex = 0;
            groupBoxOutPut_DDA.TabStop = false;
            groupBoxOutPut_DDA.Text = "Вывод:";
            // 
            // dataGridViewOut_DDA
            // 
            dataGridViewOut_DDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_DDA.Dock = DockStyle.Fill;
            dataGridViewOut_DDA.Location = new Point(3, 24);
            dataGridViewOut_DDA.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOut_DDA.Name = "dataGridViewOut_DDA";
            dataGridViewOut_DDA.RowHeadersVisible = false;
            dataGridViewOut_DDA.RowHeadersWidth = 51;
            dataGridViewOut_DDA.RowTemplate.Height = 24;
            dataGridViewOut_DDA.Size = new Size(657, 642);
            dataGridViewOut_DDA.TabIndex = 0;
            // 
            // panelInPut_DDA
            // 
            panelInPut_DDA.Controls.Add(groupBoxInPut_DDA);
            panelInPut_DDA.Dock = DockStyle.Left;
            panelInPut_DDA.Location = new Point(0, 315);
            panelInPut_DDA.Margin = new Padding(3, 4, 3, 4);
            panelInPut_DDA.Name = "panelInPut_DDA";
            panelInPut_DDA.Size = new Size(677, 670);
            panelInPut_DDA.TabIndex = 3;
            // 
            // groupBoxInPut_DDA
            // 
            groupBoxInPut_DDA.Controls.Add(dataGridViewIn_DDA);
            groupBoxInPut_DDA.Dock = DockStyle.Fill;
            groupBoxInPut_DDA.Location = new Point(0, 0);
            groupBoxInPut_DDA.Margin = new Padding(3, 4, 3, 4);
            groupBoxInPut_DDA.Name = "groupBoxInPut_DDA";
            groupBoxInPut_DDA.Padding = new Padding(3, 4, 3, 4);
            groupBoxInPut_DDA.Size = new Size(677, 670);
            groupBoxInPut_DDA.TabIndex = 0;
            groupBoxInPut_DDA.TabStop = false;
            groupBoxInPut_DDA.Text = "Ввод:";
            // 
            // dataGridViewIn_DDA
            // 
            dataGridViewIn_DDA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_DDA.Dock = DockStyle.Fill;
            dataGridViewIn_DDA.Location = new Point(3, 24);
            dataGridViewIn_DDA.Margin = new Padding(3, 4, 3, 4);
            dataGridViewIn_DDA.Name = "dataGridViewIn_DDA";
            dataGridViewIn_DDA.RowHeadersVisible = false;
            dataGridViewIn_DDA.RowHeadersWidth = 51;
            dataGridViewIn_DDA.RowTemplate.Height = 24;
            dataGridViewIn_DDA.Size = new Size(671, 642);
            dataGridViewIn_DDA.TabIndex = 0;
            // 
            // openFileDialog_DDA
            // 
            openFileDialog_DDA.FileName = "openFileDialog1";
            openFileDialog_DDA.FileOk += openFileDialog_DDA_FileOk;
            // 
            // toolTipButton_DDA
            // 
            toolTipButton_DDA.IsBalloon = true;
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
            Controls.Add(panelOutPut_DDA);
            Controls.Add(panelInPut_DDA);
            Controls.Add(panelButtons_DDA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 28 | Корнев Р.М.";
            panelButtons_DDA.ResumeLayout(false);
            groupBoxCondition_DDA.ResumeLayout(false);
            groupBoxCondition_DDA.PerformLayout();
            panelTask_DDA.ResumeLayout(false);
            panelOutPut_DDA.ResumeLayout(false);
            groupBoxOutPut_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_DDA).EndInit();
            panelInPut_DDA.ResumeLayout(false);
            groupBoxInPut_DDA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_DDA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_DDA;
        private System.Windows.Forms.GroupBox groupBoxCondition_DDA;
        private System.Windows.Forms.Label labelCondition_DDA;
        private System.Windows.Forms.Panel panelTask_DDA;
        private System.Windows.Forms.Panel panelOutPut_DDA;
        private System.Windows.Forms.Panel panelInPut_DDA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_DDA;
        private System.Windows.Forms.DataGridView dataGridViewOut_DDA;
        private System.Windows.Forms.GroupBox groupBoxInPut_DDA;
        private System.Windows.Forms.DataGridView dataGridViewIn_DDA;
        private System.Windows.Forms.Button buttonDone_DDA;
        private System.Windows.Forms.Button buttonOpenFile_DDA;
        private System.Windows.Forms.Button buttonInfo_DDA;
        private System.Windows.Forms.Button buttonSaveFile_DDA;
        private System.Windows.Forms.OpenFileDialog openFileDialog_DDA;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_DDA;
        private System.Windows.Forms.ToolTip toolTipButton_DDA;
        private Label label1;
    }
}
