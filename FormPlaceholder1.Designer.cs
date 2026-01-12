namespace Loopie_Helper_GUI
{
    partial class FormPlaceholder1
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
            picStatsClose = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picStatsClose).BeginInit();
            SuspendLayout();
            // 
            // picStatsClose
            // 
            picStatsClose.BackColor = Color.FromArgb(6, 23, 14);
            picStatsClose.Image = Properties.Resources.x;
            picStatsClose.Location = new Point(2, 3);
            picStatsClose.Name = "picStatsClose";
            picStatsClose.Size = new Size(28, 30);
            picStatsClose.SizeMode = PictureBoxSizeMode.CenterImage;
            picStatsClose.TabIndex = 0;
            picStatsClose.TabStop = false;
            picStatsClose.Click += picStatsClose_Click;
            picStatsClose.MouseEnter += picStatsClose_MouseEnter;
            picStatsClose.MouseLeave += picStatsClose_MouseLeave;
            // 
            // FormPlaceholder1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 34, 21);
            ClientSize = new Size(913, 541);
            Controls.Add(picStatsClose);
            Name = "FormPlaceholder1";
            Text = "FormPlaceholder1";
            ((System.ComponentModel.ISupportInitialize)picStatsClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picStatsClose;
    }
}