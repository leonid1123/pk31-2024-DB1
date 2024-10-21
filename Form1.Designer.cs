namespace pk31
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            listBox2 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox3 = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(23, 12);
            button1.Name = "button1";
            button1.Size = new Size(299, 43);
            button1.TabIndex = 0;
            button1.Text = "Получить записи";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 16F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(23, 135);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1355, 152);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(345, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(688, 43);
            textBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 16F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 37;
            listBox2.Location = new Point(23, 337);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(1355, 152);
            listBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(23, 58);
            label1.Name = "label1";
            label1.Size = new Size(276, 37);
            label1.TabIndex = 4;
            label1.Text = "Список арендаторов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(23, 290);
            label2.Name = "label2";
            label2.Size = new Size(243, 37);
            label2.TabIndex = 5;
            label2.Text = "Список самокатов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(23, 499);
            label3.Name = "label3";
            label3.Size = new Size(343, 37);
            label3.TabIndex = 6;
            label3.Text = "Список выдачи самокатов";
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 16F);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 37;
            listBox3.Location = new Point(23, 542);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(1355, 226);
            listBox3.TabIndex = 7;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(305, 61);
            button2.Name = "button2";
            button2.Size = new Size(61, 41);
            button2.TabIndex = 8;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(272, 290);
            button3.Name = "button3";
            button3.Size = new Size(61, 41);
            button3.TabIndex = 9;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(372, 495);
            button4.Name = "button4";
            button4.Size = new Size(61, 41);
            button4.TabIndex = 10;
            button4.Text = "+";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1390, 809);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(listBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private TextBox textBox1;
        private ListBox listBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox3;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
