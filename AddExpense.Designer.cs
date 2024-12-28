namespace PET
{
    partial class AddExpense
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
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            textBox3 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Expense Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(598, 420);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 410);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 4;
            label5.Text = "Notes/Remarks";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 363);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 5;
            label6.Text = "Payment Method";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 306);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 6;
            label7.Text = "Category";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 136);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 7;
            label8.Text = "Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 91);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 8;
            label9.Text = "Amount";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(177, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(177, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(283, 23);
            textBox2.TabIndex = 10;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(177, 126);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(177, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(283, 23);
            textBox3.TabIndex = 12;
            // 
            // radioButton1
            // 
            radioButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButton1.AutoSize = true;
            radioButton1.BackColor = SystemColors.ButtonFace;
            radioButton1.Location = new Point(177, 363);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 19);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Online";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ButtonFace;
            radioButton2.Location = new Point(301, 363);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(51, 19);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cash";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            radioButton3.AutoSize = true;
            radioButton3.BackColor = SystemColors.ButtonFace;
            radioButton3.Location = new Point(427, 363);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(43, 19);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "UPI";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(177, 410);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(283, 65);
            richTextBox1.TabIndex = 16;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(127, 537);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(301, 537);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // AddExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 586);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox3);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddExpense";
            Text = "AddExpense";
            Load += AddExpense_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private MonthCalendar monthCalendar1;
        private TextBox textBox3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
    }
}