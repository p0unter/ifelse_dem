namespace ifelse_deneme
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 112);
            label1.Name = "label1";
            label1.Size = new Size(68, 56);
            label1.TabIndex = 0;
            label1.Text = "....";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(21, 171);
            button1.Name = "button1";
            button1.Size = new Size(262, 56);
            button1.TabIndex = 1;
            button1.Text = "KONTUROL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(49, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(201, 75);
            textBox1.TabIndex = 2;
            textBox1.Text = "ŞİFRE";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(26F, 56F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(304, 251);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("AR DESTINE", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(8);
            Name = "Form1";
            Text = "Naber De";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
    }
}