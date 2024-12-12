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
            pictureBoxAvatar_KRM = new PictureBox();
            labelInfo_KRM = new Label();
            buttonOk_KRM = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KRM).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KRM
            // 
            pictureBoxAvatar_KRM.Image = (Image)resources.GetObject("pictureBoxAvatar_KRM.Image");
            pictureBoxAvatar_KRM.Location = new Point(12, 15);
            pictureBoxAvatar_KRM.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAvatar_KRM.Name = "pictureBoxAvatar_KRM";
            pictureBoxAvatar_KRM.Size = new Size(230, 302);
            pictureBoxAvatar_KRM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_KRM.TabIndex = 0;
            pictureBoxAvatar_KRM.TabStop = false;
            pictureBoxAvatar_KRM.Click += pictureBoxAvatar_KRM_Click;
            // 
            // labelInfo_KRM
            // 
            labelInfo_KRM.AutoSize = true;
            labelInfo_KRM.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelInfo_KRM.Location = new Point(248, 15);
            labelInfo_KRM.Name = "labelInfo_KRM";
            labelInfo_KRM.Size = new Size(0, 22);
            labelInfo_KRM.TabIndex = 1;
            // 
            // buttonOk_KRM
            // 
            buttonOk_KRM.FlatStyle = FlatStyle.System;
            buttonOk_KRM.Location = new Point(633, 274);
            buttonOk_KRM.Margin = new Padding(3, 4, 3, 4);
            buttonOk_KRM.Name = "buttonOk_KRM";
            buttonOk_KRM.Size = new Size(122, 70);
            buttonOk_KRM.TabIndex = 2;
            buttonOk_KRM.Text = "OK";
            buttonOk_KRM.UseVisualStyleBackColor = true;
            buttonOk_KRM.Click += buttonOk_KRM_Click;
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
            Controls.Add(buttonOk_KRM);
            Controls.Add(labelInfo_KRM);
            Controls.Add(pictureBoxAvatar_KRM);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KRM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_KRM;
        private System.Windows.Forms.Label labelInfo_KRM;
        private System.Windows.Forms.Button buttonOk_KRM;
        private Label label1;
    }
}