namespace Tyuiu.KornevRM.Sprint6.Task7.V28
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_DDA = new PictureBox();
            labelInfo_DDA = new Label();
            buttonOk_DDA = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DDA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_DDA
            // 
            pictureBoxAvatar_DDA.Image = (Image)resources.GetObject("pictureBoxAvatar_DDA.Image");
            pictureBoxAvatar_DDA.Location = new Point(12, 15);
            pictureBoxAvatar_DDA.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAvatar_DDA.Name = "pictureBoxAvatar_DDA";
            pictureBoxAvatar_DDA.Size = new Size(230, 302);
            pictureBoxAvatar_DDA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_DDA.TabIndex = 0;
            pictureBoxAvatar_DDA.TabStop = false;
            pictureBoxAvatar_DDA.Click += pictureBoxAvatar_DDA_Click;
            // 
            // labelInfo_DDA
            // 
            labelInfo_DDA.AutoSize = true;
            labelInfo_DDA.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_DDA.Location = new Point(248, 15);
            labelInfo_DDA.Name = "labelInfo_DDA";
            labelInfo_DDA.Size = new Size(0, 22);
            labelInfo_DDA.TabIndex = 1;
            // 
            // buttonOk_DDA
            // 
            buttonOk_DDA.FlatStyle = FlatStyle.System;
            buttonOk_DDA.Location = new Point(633, 274);
            buttonOk_DDA.Margin = new Padding(3, 4, 3, 4);
            buttonOk_DDA.Name = "buttonOk_DDA";
            buttonOk_DDA.Size = new Size(122, 70);
            buttonOk_DDA.TabIndex = 2;
            buttonOk_DDA.Text = "OK";
            buttonOk_DDA.UseVisualStyleBackColor = true;
            buttonOk_DDA.Click += buttonOk_DDA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(371, 114);
            label1.Name = "label1";
            label1.Size = new Size(250, 20);
            label1.TabIndex = 3;
            label1.Text = "Корнев Р.М. ИСПб-24-1 ТИУ ВШЦТ";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 352);
            Controls.Add(label1);
            Controls.Add(buttonOk_DDA);
            Controls.Add(labelInfo_DDA);
            Controls.Add(pictureBoxAvatar_DDA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_DDA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_DDA;
        private System.Windows.Forms.Label labelInfo_DDA;
        private System.Windows.Forms.Button buttonOk_DDA;
        private Label label1;
    }
}