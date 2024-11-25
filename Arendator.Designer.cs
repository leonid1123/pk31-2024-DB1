namespace pk31
{
    partial class Arendator
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(12, 354);
            button1.Name = "button1";
            button1.Size = new Size(261, 73);
            button1.TabIndex = 0;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16F);
            textBox1.Location = new Point(164, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(474, 43);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 4;
            label2.Text = "Паспорт";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 16F);
            textBox2.Location = new Point(164, 52);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(474, 43);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 6;
            label3.Text = "Телефон";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 16F);
            textBox3.Location = new Point(164, 101);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(474, 43);
            textBox3.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 16F);
            dateTimePicker1.Location = new Point(388, 166);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 43);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(209, 37);
            label4.TabIndex = 8;
            label4.Text = "Дата рождения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(15, 9);
            label5.Name = "label5";
            label5.Size = new Size(130, 37);
            label5.TabIndex = 10;
            label5.Text = "Фамилия";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(317, 255);
            label6.Name = "label6";
            label6.Size = new Size(0, 37);
            label6.TabIndex = 11;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 16F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(662, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(666, 411);
            listBox1.TabIndex = 12;
            // 
            // Arendator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 450);
            Controls.Add(listBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Arendator";
            Text = "Arendator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label label6;
        private ListBox listBox1;
    }
}