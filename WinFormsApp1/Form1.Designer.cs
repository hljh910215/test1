namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            waCheckBox1 = new WACheckBox();
            waTextBox1 = new WATextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(206, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // waCheckBox1
            // 
            waCheckBox1.AutoSize = true;
            waCheckBox1.Location = new Point(206, 113);
            waCheckBox1.Name = "waCheckBox1";
            waCheckBox1.Size = new Size(104, 19);
            waCheckBox1.TabIndex = 3;
            waCheckBox1.Text = "waCheckBox1";
            waCheckBox1.UseVisualStyleBackColor = true;
            waCheckBox1.CheckedChanged += waCheckBox1_CheckedChanged;
            // 
            // waTextBox1
            // 
            waTextBox1.Location = new Point(206, 151);
            waTextBox1.Name = "waTextBox1";
            waTextBox1.Size = new Size(100, 23);
            waTextBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 316);
            Controls.Add(waTextBox1);
            Controls.Add(waCheckBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private WACheckBox waCheckBox1;
        private WATextBox waTextBox1;
    }
}
