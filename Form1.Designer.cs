namespace PET
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
            Login = new Button();
            signupbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(740, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Personal Expenese Tracker Application";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Login
            // 
            Login.Location = new Point(87, 217);
            Login.Name = "Login";
            Login.Size = new Size(176, 63);
            Login.TabIndex = 1;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // signupbtn
            // 
            signupbtn.Location = new Point(452, 217);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(188, 63);
            signupbtn.TabIndex = 2;
            signupbtn.Text = "Sigup";
            signupbtn.UseVisualStyleBackColor = true;
            signupbtn.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(signupbtn);
            Controls.Add(Login);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Personal Expense Tracker";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Login;
        private Button signupbtn;
    }
}
