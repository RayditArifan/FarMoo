namespace Project_PBO___FarMoo.Views
{
    partial class Login
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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(335, 65);
            label1.Name = "label1";
            label1.Size = new Size(89, 29);
            label1.TabIndex = 0;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Arial Narrow", 10F);
            tbUsername.Location = new Point(256, 157);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(219, 30);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Arial Narrow", 10F);
            tbPassword.Location = new Point(256, 248);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(219, 30);
            tbPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(312, 346);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10F);
            label2.Location = new Point(256, 129);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 4;
            label2.Text = "Userame";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10F);
            label3.Location = new Point(256, 220);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Label label2;
        private Label label3;
    }
}