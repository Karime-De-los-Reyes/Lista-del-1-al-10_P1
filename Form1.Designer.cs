namespace WinFormsApp1__listbox_
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
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SG Alternative High-Alt", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(135, 19);
            label1.Name = "label1";
            label1.Size = new Size(344, 28);
            label1.TabIndex = 0;
            label1.Text = "Escribe los números del 0 a 10";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(255, 63);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 199);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("SG Alternative High-Alt", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(269, 268);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 2;
            button1.Text = "Enlistar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Button button1;
    }
}