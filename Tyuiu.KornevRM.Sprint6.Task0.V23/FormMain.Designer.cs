namespace Tyuiu.KornevRM.Sprint6.Task0.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxUslovie_GVE = new GroupBox();
            textBox1 = new TextBox();
            pictureBoxFormula_GVE = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxInput_GVE = new GroupBox();
            labelVarX_GVE = new Label();
            textBoxVarX_GVE = new TextBox();
            groupBoxOut_GVE = new GroupBox();
            labelRes_GVE = new Label();
            textBoxRes_GVE = new TextBox();
            buttonDone_GVE = new Button();
            buttonInfo_GVE = new Button();
            groupBoxUslovie_GVE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_GVE).BeginInit();
            groupBoxInput_GVE.SuspendLayout();
            groupBoxOut_GVE.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_GVE
            // 
            groupBoxUslovie_GVE.Controls.Add(textBox1);
            groupBoxUslovie_GVE.Controls.Add(pictureBoxFormula_GVE);
            groupBoxUslovie_GVE.Location = new Point(29, 54);
            groupBoxUslovie_GVE.Margin = new Padding(3, 4, 3, 4);
            groupBoxUslovie_GVE.Name = "groupBoxUslovie_GVE";
            groupBoxUslovie_GVE.Padding = new Padding(3, 4, 3, 4);
            groupBoxUslovie_GVE.Size = new Size(628, 230);
            groupBoxUslovie_GVE.TabIndex = 0;
            groupBoxUslovie_GVE.TabStop = false;
            groupBoxUslovie_GVE.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 42);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(356, 163);
            textBox1.TabIndex = 2;
            textBox1.Text = "Вычислить выражение по формуле: ";
            // 
            // pictureBoxFormula_GVE
            // 
            pictureBoxFormula_GVE.ErrorImage = null;
            pictureBoxFormula_GVE.Image = (Image)resources.GetObject("pictureBoxFormula_GVE.Image");
            pictureBoxFormula_GVE.InitialImage = null;
            pictureBoxFormula_GVE.Location = new Point(408, 42);
            pictureBoxFormula_GVE.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula_GVE.Name = "pictureBoxFormula_GVE";
            pictureBoxFormula_GVE.Size = new Size(125, 57);
            pictureBoxFormula_GVE.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFormula_GVE.TabIndex = 1;
            pictureBoxFormula_GVE.TabStop = false;
            // 
            // groupBoxInput_GVE
            // 
            groupBoxInput_GVE.Controls.Add(labelVarX_GVE);
            groupBoxInput_GVE.Controls.Add(textBoxVarX_GVE);
            groupBoxInput_GVE.Location = new Point(29, 328);
            groupBoxInput_GVE.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_GVE.Name = "groupBoxInput_GVE";
            groupBoxInput_GVE.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_GVE.Size = new Size(290, 125);
            groupBoxInput_GVE.TabIndex = 1;
            groupBoxInput_GVE.TabStop = false;
            groupBoxInput_GVE.Text = "Ввод данных:";
            // 
            // labelVarX_GVE
            // 
            labelVarX_GVE.AutoSize = true;
            labelVarX_GVE.Location = new Point(7, 28);
            labelVarX_GVE.Name = "labelVarX_GVE";
            labelVarX_GVE.Size = new Size(114, 20);
            labelVarX_GVE.TabIndex = 1;
            labelVarX_GVE.Text = "Переменная X:";
            // 
            // textBoxVarX_GVE
            // 
            textBoxVarX_GVE.Location = new Point(10, 64);
            textBoxVarX_GVE.Margin = new Padding(3, 4, 3, 4);
            textBoxVarX_GVE.Name = "textBoxVarX_GVE";
            textBoxVarX_GVE.Size = new Size(100, 27);
            textBoxVarX_GVE.TabIndex = 0;
            textBoxVarX_GVE.TextChanged += textBoxVarX_GVE_TextChanged;
            // 
            // groupBoxOut_GVE
            // 
            groupBoxOut_GVE.Controls.Add(labelRes_GVE);
            groupBoxOut_GVE.Controls.Add(textBoxRes_GVE);
            groupBoxOut_GVE.Location = new Point(367, 328);
            groupBoxOut_GVE.Margin = new Padding(3, 4, 3, 4);
            groupBoxOut_GVE.Name = "groupBoxOut_GVE";
            groupBoxOut_GVE.Padding = new Padding(3, 4, 3, 4);
            groupBoxOut_GVE.Size = new Size(290, 125);
            groupBoxOut_GVE.TabIndex = 1;
            groupBoxOut_GVE.TabStop = false;
            groupBoxOut_GVE.Text = "Вывод данных:";
            // 
            // labelRes_GVE
            // 
            labelRes_GVE.AutoSize = true;
            labelRes_GVE.Location = new Point(6, 28);
            labelRes_GVE.Name = "labelRes_GVE";
            labelRes_GVE.Size = new Size(78, 20);
            labelRes_GVE.TabIndex = 1;
            labelRes_GVE.Text = "Результат:";
            // 
            // textBoxRes_GVE
            // 
            textBoxRes_GVE.Location = new Point(9, 64);
            textBoxRes_GVE.Margin = new Padding(3, 4, 3, 4);
            textBoxRes_GVE.Name = "textBoxRes_GVE";
            textBoxRes_GVE.ReadOnly = true;
            textBoxRes_GVE.Size = new Size(100, 27);
            textBoxRes_GVE.TabIndex = 0;
            // 
            // buttonDone_GVE
            // 
            buttonDone_GVE.Location = new Point(554, 480);
            buttonDone_GVE.Margin = new Padding(3, 4, 3, 4);
            buttonDone_GVE.Name = "buttonDone_GVE";
            buttonDone_GVE.Size = new Size(118, 48);
            buttonDone_GVE.TabIndex = 2;
            buttonDone_GVE.Text = "Выполнить";
            buttonDone_GVE.UseVisualStyleBackColor = true;
            buttonDone_GVE.Click += buttonDone_GVE_Click;
            // 
            // buttonInfo_GVE
            // 
            buttonInfo_GVE.FlatStyle = FlatStyle.Flat;
            buttonInfo_GVE.Location = new Point(495, 480);
            buttonInfo_GVE.Margin = new Padding(3, 4, 3, 4);
            buttonInfo_GVE.Name = "buttonInfo_GVE";
            buttonInfo_GVE.Size = new Size(42, 48);
            buttonInfo_GVE.TabIndex = 3;
            buttonInfo_GVE.Text = "?";
            buttonInfo_GVE.UseVisualStyleBackColor = true;
            buttonInfo_GVE.Click += buttonInfo_GVE_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 542);
            Controls.Add(buttonInfo_GVE);
            Controls.Add(buttonDone_GVE);
            Controls.Add(groupBoxOut_GVE);
            Controls.Add(groupBoxInput_GVE);
            Controls.Add(groupBoxUslovie_GVE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск0 | Вариант 23 | Корнев Р.М.";
            groupBoxUslovie_GVE.ResumeLayout(false);
            groupBoxUslovie_GVE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_GVE).EndInit();
            groupBoxInput_GVE.ResumeLayout(false);
            groupBoxInput_GVE.PerformLayout();
            groupBoxOut_GVE.ResumeLayout(false);
            groupBoxOut_GVE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_GVE;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxFormula_GVE;
        private System.Windows.Forms.GroupBox groupBoxInput_GVE;
        private System.Windows.Forms.GroupBox groupBoxOut_GVE;
        private System.Windows.Forms.Label labelVarX_GVE;
        private System.Windows.Forms.TextBox textBoxVarX_GVE;
        private System.Windows.Forms.Label labelRes_GVE;
        private System.Windows.Forms.TextBox textBoxRes_GVE;
        private System.Windows.Forms.Button buttonDone_GVE;
        private System.Windows.Forms.Button buttonInfo_GVE;
        private System.Windows.Forms.TextBox textBox1;
    }
}