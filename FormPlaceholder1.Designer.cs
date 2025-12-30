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
            buttonPlaceholder = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonPlaceholder
            // 
            buttonPlaceholder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlaceholder.ForeColor = Color.Black;
            buttonPlaceholder.Location = new Point(43, 24);
            buttonPlaceholder.Name = "buttonPlaceholder";
            buttonPlaceholder.Size = new Size(75, 60);
            buttonPlaceholder.TabIndex = 1;
            buttonPlaceholder.Text = "X";
            buttonPlaceholder.UseVisualStyleBackColor = true;
            buttonPlaceholder.Click += buttonPlaceholder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(211, 33);
            label1.Name = "label1";
            label1.Size = new Size(364, 25);
            label1.TabIndex = 2;
            label1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            // 
            // FormPlaceholder1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 34, 21);
            ClientSize = new Size(913, 541);
            Controls.Add(label1);
            Controls.Add(buttonPlaceholder);
            Name = "FormPlaceholder1";
            Text = "FormPlaceholder1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonPlaceholder;
        private Label label1;
    }
}