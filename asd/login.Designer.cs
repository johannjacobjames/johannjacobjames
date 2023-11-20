namespace asd
{
    partial class login
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
            label2 = new Label();
            checkbxShowPassword = new CheckBox();
            bRegister = new Button();
            textPassword = new TextBox();
            textLogin = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(338, 323);
            label2.Name = "label2";
            label2.Size = new Size(123, 16);
            label2.TabIndex = 13;
            label2.Text = "Create an account";
            label2.Click += label2_Click;
            // 
            // checkbxShowPassword
            // 
            checkbxShowPassword.AutoSize = true;
            checkbxShowPassword.BackColor = Color.Transparent;
            checkbxShowPassword.FlatStyle = FlatStyle.Flat;
            checkbxShowPassword.ForeColor = Color.SpringGreen;
            checkbxShowPassword.Location = new Point(280, 243);
            checkbxShowPassword.Name = "checkbxShowPassword";
            checkbxShowPassword.Size = new Size(105, 19);
            checkbxShowPassword.TabIndex = 12;
            checkbxShowPassword.Text = "Show Password";
            checkbxShowPassword.UseVisualStyleBackColor = false;
            checkbxShowPassword.CheckedChanged += checkbxShowPassword_CheckedChanged;
            // 
            // bRegister
            // 
            bRegister.BackColor = Color.SpringGreen;
            bRegister.BackgroundImageLayout = ImageLayout.Center;
            bRegister.FlatStyle = FlatStyle.Flat;
            bRegister.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bRegister.Location = new Point(280, 278);
            bRegister.Name = "bRegister";
            bRegister.Size = new Size(240, 29);
            bRegister.TabIndex = 10;
            bRegister.Text = "Login";
            bRegister.UseVisualStyleBackColor = false;
            bRegister.Click += bRegister_Click;
            // 
            // textPassword
            // 
            textPassword.AccessibleDescription = "";
            textPassword.AccessibleName = "";
            textPassword.BackColor = Color.FromArgb(230, 231, 233);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Location = new Point(280, 193);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(240, 30);
            textPassword.TabIndex = 9;
            // 
            // textLogin
            // 
            textLogin.BackColor = Color.FromArgb(230, 231, 233);
            textLogin.BorderStyle = BorderStyle.None;
            textLogin.Location = new Point(280, 140);
            textLogin.Multiline = true;
            textLogin.Name = "textLogin";
            textLogin.PlaceholderText = "Email";
            textLogin.Size = new Size(240, 30);
            textLogin.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(338, 67);
            label1.Name = "label1";
            label1.Size = new Size(112, 36);
            label1.TabIndex = 7;
            label1.Text = "Sign in";
            label1.Click += label1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_11_12_181420;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(checkbxShowPassword);
            Controls.Add(bRegister);
            Controls.Add(textPassword);
            Controls.Add(textLogin);
            Controls.Add(label1);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private CheckBox checkbxShowPassword;
        private Button bRegister;
        private TextBox textPassword;
        private TextBox textLogin;
        private Label label1;
    }
}