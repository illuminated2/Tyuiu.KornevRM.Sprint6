namespace Tyuiu.KornevRM.Sprint6.Task6.V11
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
            panel2 = new Panel();
            labelAbout_ZAA = new Label();
            image_ZAA = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(labelAbout_ZAA);
            panel2.Location = new Point(341, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 276);
            panel2.TabIndex = 1;
            // 
            // labelAbout_ZAA
            // 
            labelAbout_ZAA.AutoSize = true;
            labelAbout_ZAA.Dock = DockStyle.Fill;
            labelAbout_ZAA.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelAbout_ZAA.Location = new Point(0, 0);
            labelAbout_ZAA.MaximumSize = new Size(427, 250);
            labelAbout_ZAA.MinimumSize = new Size(427, 250);
            labelAbout_ZAA.Name = "labelAbout_ZAA";
            labelAbout_ZAA.Size = new Size(427, 250);
            labelAbout_ZAA.TabIndex = 0;
            // 
            // image_ZAA
            // 
            image_ZAA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            image_ZAA.BackgroundImageLayout = ImageLayout.Stretch;
            image_ZAA.Location = new Point(13, 16);
            image_ZAA.Margin = new Padding(3, 4, 3, 4);
            image_ZAA.Name = "image_ZAA";
            image_ZAA.Size = new Size(321, 276);
            image_ZAA.TabIndex = 0;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 311);
            Controls.Add(panel2);
            Controls.Add(image_ZAA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel image_ZAA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelAbout_ZAA;
    }
}