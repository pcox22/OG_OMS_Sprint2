namespace OGOMS_Sprint2 {
    partial class Login {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblLogin = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            tbxUserName = new TextBox();
            tbxPassword = new TextBox();
            btnContinue = new Button();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblLogin.ForeColor = Color.FromArgb(  18,   47,   94);
            lblLogin.Location = new Point(470, 71);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(138, 59);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            lblLogin.Click += label1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblUsername.ForeColor = Color.FromArgb(  18,   47,   94);
            lblUsername.Location = new Point(417, 172);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(110, 30);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point,  0);
            lblPassword.ForeColor = Color.FromArgb(  18,   47,   94);
            lblPassword.Location = new Point(417, 251);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(105, 30);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password";
            // 
            // tbxUserName
            // 
            tbxUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxUserName.Location = new Point(417, 205);
            tbxUserName.MaxLength = 24;
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(245, 29);
            tbxUserName.TabIndex = 3;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            tbxPassword.Location = new Point(417, 284);
            tbxPassword.MaxLength = 24;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(245, 29);
            tbxPassword.TabIndex = 4;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.FromArgb(  61,   128,   186);
            btnContinue.Font = new Font("Segoe UI", 9F,  FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point,  0);
            btnContinue.ForeColor = Color.White;
            btnContinue.Location = new Point(496, 344);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(86, 31);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(  222,   235,   247);
            ClientSize = new Size(1078, 589);
            Controls.Add(btnContinue);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLogin);
            Name = "Login";
            Text = "OG OMS - Prototype, Sprint 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbxUserName;
        private TextBox tbxPassword;
        private Button btnContinue;
    }
}