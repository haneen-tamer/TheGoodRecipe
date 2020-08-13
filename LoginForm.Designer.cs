namespace TheGoodRecipe
{
    partial class LoginForm
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
            this.SignUp = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.name_l = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(510, 332);
            this.SignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(89, 51);
            this.SignUp.TabIndex = 1;
            this.SignUp.Text = "Sign Up";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(226, 332);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(128, 51);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Log in";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(173, 189);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(78, 20);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(323, 76);
            this.name_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(112, 26);
            this.name_txt.TabIndex = 5;
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(323, 129);
            this.username_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(112, 26);
            this.username_txt.TabIndex = 6;
            // 
            // pass_txt
            // 
            this.pass_txt.Location = new System.Drawing.Point(323, 189);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(112, 26);
            this.pass_txt.TabIndex = 7;
            // 
            // name_l
            // 
            this.name_l.AutoSize = true;
            this.name_l.Location = new System.Drawing.Point(173, 82);
            this.name_l.Name = "name_l";
            this.name_l.Size = new System.Drawing.Size(51, 20);
            this.name_l.TabIndex = 8;
            this.name_l.Text = "Name";
            this.name_l.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(173, 135);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(83, 20);
            this.username.TabIndex = 9;
            this.username.Text = "Username";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.username);
            this.Controls.Add(this.name_l);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.SignUp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Onclosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label name_l;
        private System.Windows.Forms.Label username;
    }
}