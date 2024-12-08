namespace Tyuiu.KornevRM.Sprint6.Task2.V9
{

    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SDA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxInfo_SDA = new System.Windows.Forms.GroupBox();
            this.labelStop_SDA = new System.Windows.Forms.Label();
            this.labelStart_SDA = new System.Windows.Forms.Label();
            this.textBoxStop_SDA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SDA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SDA = new System.Windows.Forms.GroupBox();
            this.labelResult_SDA = new System.Windows.Forms.Label();
            this.chartFunction_SDA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_SDA = new System.Windows.Forms.DataGridView();
            this.ColumnX_SDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF_SDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInfo_SDA = new System.Windows.Forms.Button();
            this.buttonDone_SDA = new System.Windows.Forms.Button();
            this.groupBoxTask_SDA.SuspendLayout();
            this.groupBoxInfo_SDA.SuspendLayout();
            this.groupBoxResult_SDA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SDA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SDA
            // 
            this.groupBoxTask_SDA.Controls.Add(this.textBoxTask_SDA);
            this.groupBoxTask_SDA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SDA.Name = "groupBoxTask_SDA";
            this.groupBoxTask_SDA.Size = new System.Drawing.Size(605, 281);
            this.groupBoxTask_SDA.TabIndex = 0;
            this.groupBoxTask_SDA.TabStop = false;
            this.groupBoxTask_SDA.Text = "Условие";
            // 
            // textBoxTask_SDA
            // 
            this.textBoxTask_SDA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SDA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxTask_SDA.Location = new System.Drawing.Point(19, 32);
            this.textBoxTask_SDA.Multiline = true;
            this.textBoxTask_SDA.Name = "textBoxTask_SDA";
            this.textBoxTask_SDA.ReadOnly = true;
            this.textBoxTask_SDA.Size = new System.Drawing.Size(580, 78);
            this.textBoxTask_SDA.TabIndex = 0;
            this.textBoxTask_SDA.Text = "Продабулировать функцию \" (3x - 1.5) / (sin(x) - 3 + x) +2 \" на заданном диапозон" +
    "е.\r\nРезультат вывести в DataGridView и построить график функции.";
            this.textBoxTask_SDA.TextChanged += new System.EventHandler(this.textBoxTask_SDA_TextChanged);
            // 
            // groupBoxInfo_SDA
            // 
            this.groupBoxInfo_SDA.Controls.Add(this.labelStop_SDA);
            this.groupBoxInfo_SDA.Controls.Add(this.labelStart_SDA);
            this.groupBoxInfo_SDA.Controls.Add(this.textBoxStop_SDA);
            this.groupBoxInfo_SDA.Controls.Add(this.textBoxStart_SDA);
            this.groupBoxInfo_SDA.Location = new System.Drawing.Point(12, 299);
            this.groupBoxInfo_SDA.Name = "groupBoxInfo_SDA";
            this.groupBoxInfo_SDA.Size = new System.Drawing.Size(332, 69);
            this.groupBoxInfo_SDA.TabIndex = 0;
            this.groupBoxInfo_SDA.TabStop = false;
            this.groupBoxInfo_SDA.Text = "Вывод данных";
            // 
            // labelStop_SDA
            // 
            this.labelStop_SDA.AutoSize = true;
            this.labelStop_SDA.Location = new System.Drawing.Point(169, 18);
            this.labelStop_SDA.Name = "labelStop_SDA";
            this.labelStop_SDA.Size = new System.Drawing.Size(93, 17);
            this.labelStop_SDA.TabIndex = 1;
            this.labelStop_SDA.Text = "Конец шага: ";
            // 
            // labelStart_SDA
            // 
            this.labelStart_SDA.AutoSize = true;
            this.labelStart_SDA.Location = new System.Drawing.Point(6, 18);
            this.labelStart_SDA.Name = "labelStart_SDA";
            this.labelStart_SDA.Size = new System.Drawing.Size(91, 17);
            this.labelStart_SDA.TabIndex = 1;
            this.labelStart_SDA.Text = "Старт шага: ";
            // 
            // textBoxStop_SDA
            // 
            this.textBoxStop_SDA.Location = new System.Drawing.Point(172, 41);
            this.textBoxStop_SDA.Name = "textBoxStop_SDA";
            this.textBoxStop_SDA.Size = new System.Drawing.Size(154, 22);
            this.textBoxStop_SDA.TabIndex = 0;
            // 
            // textBoxStart_SDA
            // 
            this.textBoxStart_SDA.Location = new System.Drawing.Point(9, 41);
            this.textBoxStart_SDA.Name = "textBoxStart_SDA";
            this.textBoxStart_SDA.Size = new System.Drawing.Size(157, 22);
            this.textBoxStart_SDA.TabIndex = 0;
            // 
            // groupBoxResult_SDA
            // 
            this.groupBoxResult_SDA.Controls.Add(this.labelResult_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.chartFunction_SDA);
            this.groupBoxResult_SDA.Controls.Add(this.dataGridViewFunction_SDA);
            this.groupBoxResult_SDA.Location = new System.Drawing.Point(623, 12);
            this.groupBoxResult_SDA.Name = "groupBoxResult_SDA";
            this.groupBoxResult_SDA.Size = new System.Drawing.Size(718, 356);
            this.groupBoxResult_SDA.TabIndex = 0;
            this.groupBoxResult_SDA.TabStop = false;
            this.groupBoxResult_SDA.Text = "Вывод данных";
            // 
            // labelResult_SDA
            // 
            this.labelResult_SDA.AutoSize = true;
            this.labelResult_SDA.Location = new System.Drawing.Point(6, 18);
            this.labelResult_SDA.Name = "labelResult_SDA";
            this.labelResult_SDA.Size = new System.Drawing.Size(84, 17);
            this.labelResult_SDA.TabIndex = 1;
            this.labelResult_SDA.Text = "Результат: ";
            // 
            // chartFunction_SDA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_SDA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_SDA.Legends.Add(legend1);
            this.chartFunction_SDA.Location = new System.Drawing.Point(172, 38);
            this.chartFunction_SDA.Name = "chartFunction_SDA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_SDA.Series.Add(series1);
            this.chartFunction_SDA.Size = new System.Drawing.Size(540, 312);
            this.chartFunction_SDA.TabIndex = 6;
            this.chartFunction_SDA.Text = "chart1";
            // 
            // dataGridViewFunction_SDA
            // 
            this.dataGridViewFunction_SDA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SDA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_SDA,
            this.ColumnF_SDA});
            this.dataGridViewFunction_SDA.Location = new System.Drawing.Point(9, 38);
            this.dataGridViewFunction_SDA.Name = "dataGridViewFunction_SDA";
            this.dataGridViewFunction_SDA.RowHeadersVisible = false;
            this.dataGridViewFunction_SDA.RowHeadersWidth = 51;
            this.dataGridViewFunction_SDA.RowTemplate.Height = 24;
            this.dataGridViewFunction_SDA.Size = new System.Drawing.Size(157, 312);
            this.dataGridViewFunction_SDA.TabIndex = 0;
            this.dataGridViewFunction_SDA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFunction_SDA_CellContentClick);
            // 
            // ColumnX_SDA
            // 
            this.ColumnX_SDA.HeaderText = "X";
            this.ColumnX_SDA.MinimumWidth = 6;
            this.ColumnX_SDA.Name = "ColumnX_SDA";
            this.ColumnX_SDA.Width = 50;
            // 
            // ColumnF_SDA
            // 
            this.ColumnF_SDA.HeaderText = "F(x)";
            this.ColumnF_SDA.MinimumWidth = 6;
            this.ColumnF_SDA.Name = "ColumnF_SDA";
            this.ColumnF_SDA.Width = 50;
            // 
            // buttonInfo_SDA
            // 
            this.buttonInfo_SDA.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_SDA.Location = new System.Drawing.Point(350, 299);
            this.buttonInfo_SDA.Name = "buttonInfo_SDA";
            this.buttonInfo_SDA.Size = new System.Drawing.Size(106, 69);
            this.buttonInfo_SDA.TabIndex = 1;
            this.buttonInfo_SDA.Text = "Справка";
            this.buttonInfo_SDA.UseVisualStyleBackColor = false;
            this.buttonInfo_SDA.Click += new System.EventHandler(this.buttonInfo_SDA_Click);
            // 
            // buttonDone_SDA
            // 
            this.buttonDone_SDA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SDA.Location = new System.Drawing.Point(462, 299);
            this.buttonDone_SDA.Name = "buttonDone_SDA";
            this.buttonDone_SDA.Size = new System.Drawing.Size(155, 69);
            this.buttonDone_SDA.TabIndex = 1;
            this.buttonDone_SDA.Text = "Выполнить";
            this.buttonDone_SDA.UseVisualStyleBackColor = false;
            this.buttonDone_SDA.Click += new System.EventHandler(this.buttonDone_SDA_Click);
            this.buttonDone_SDA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SDA_MouseDown);
            this.buttonDone_SDA.MouseEnter += new System.EventHandler(this.buttonDone_SDA_MouseEnter);
            this.buttonDone_SDA.MouseLeave += new System.EventHandler(this.buttonDone_SDA_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 380);
            this.Controls.Add(this.buttonDone_SDA);
            this.Controls.Add(this.buttonInfo_SDA);
            this.Controls.Add(this.groupBoxResult_SDA);
            this.Controls.Add(this.groupBoxInfo_SDA);
            this.Controls.Add(this.groupBoxTask_SDA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 9 | Корнев Р.М.";
            this.groupBoxTask_SDA.ResumeLayout(false);
            this.groupBoxTask_SDA.PerformLayout();
            this.groupBoxInfo_SDA.ResumeLayout(false);
            this.groupBoxInfo_SDA.PerformLayout();
            this.groupBoxResult_SDA.ResumeLayout(false);
            this.groupBoxResult_SDA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_SDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SDA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SDA;
        private System.Windows.Forms.TextBox textBoxTask_SDA;
        private System.Windows.Forms.GroupBox groupBoxInfo_SDA;
        private System.Windows.Forms.Label labelStop_SDA;
        private System.Windows.Forms.Label labelStart_SDA;
        private System.Windows.Forms.TextBox textBoxStop_SDA;
        private System.Windows.Forms.TextBox textBoxStart_SDA;
        private System.Windows.Forms.GroupBox groupBoxResult_SDA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SDA;
        private System.Windows.Forms.Button buttonInfo_SDA;
        private System.Windows.Forms.Button buttonDone_SDA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SDA;
        private System.Windows.Forms.Label labelResult_SDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_SDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF_SDA;
    }
}
