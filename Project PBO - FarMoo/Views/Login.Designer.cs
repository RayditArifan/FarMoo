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
            btnLogin = new Button();
            label2 = new Label();
            tbUsername = new TextBox();
            label3 = new Label();
            label1 = new Label();
            tbPassword = new TextBox();
            label4 = new Label();
            lblRegister = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(1442, 639);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 48);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Arial Narrow", 10F);
            label2.Location = new Point(1366, 360);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 4;
            label2.Text = "Userame";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Arial Narrow", 10F);
            tbUsername.Location = new Point(1366, 387);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(286, 30);
            tbUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Arial Narrow", 10F);
            label3.Location = new Point(1366, 455);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1430, 186);
            label1.Name = "label1";
            label1.Size = new Size(132, 57);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.Click += label1_Click;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Arial Narrow", 10F);
            tbPassword.Location = new Point(1366, 482);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(286, 30);
            tbPassword.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1368, 731);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(214, 26);
            label4.TabIndex = 6;
            label4.Text = "Belum punya akun?";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.DeepSkyBlue;
            lblRegister.Location = new Point(1580, 733);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(89, 24);
            lblRegister.TabIndex = 7;
            lblRegister.Text = "Register";
            lblRegister.Click += lblRegister_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.Login__6_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1898, 1024);
            Controls.Add(lblRegister);
            Controls.Add(label4);
            Controls.Add(tbPassword);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(tbUsername);
            Controls.Add(label2);
            DoubleBuffered = true;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label2;
        private TextBox tbUsername;
        private Label label3;
        private Label label1;
        private TextBox tbPassword;
        private Label label4;
        private Label lblRegister;
    }
}