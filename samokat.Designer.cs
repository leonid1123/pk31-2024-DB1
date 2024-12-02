namespace pk31
{
    partial class samokat
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
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(179, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(425, 43);
            textBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 16F);
            numericUpDown1.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Location = new Point(179, 144);
            numericUpDown1.Maximum = new decimal(new int[] { 500000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(425, 43);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(179, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(425, 43);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 37);
            label1.TabIndex = 3;
            label1.Text = "Марка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(36, 80);
            label2.Name = "label2";
            label2.Size = new Size(101, 37);
            label2.TabIndex = 4;
            label2.Text = "Номер";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(36, 150);
            label3.Name = "label3";
            label3.Size = new Size(108, 37);
            label3.TabIndex = 5;
            label3.Text = "Пробег";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(243, 227);
            button1.Name = "button1";
            button1.Size = new Size(219, 71);
            button1.TabIndex = 6;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(303, 331);
            label4.Name = "label4";
            label4.Size = new Size(0, 37);
            label4.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(631, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(544, 376);
            listBox1.TabIndex = 8;
            // 
            // samokat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 413);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Name = "samokat";
            Text = "samokat";
            Load += samokat_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Label label4;
        private ListBox listBox1;
    }
}