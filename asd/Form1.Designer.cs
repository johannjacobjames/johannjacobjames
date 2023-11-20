namespace asd
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
            textLogin = new TextBox();
            textPassword = new TextBox();
            bRegister = new Button();
            textConfPass = new TextBox();
            checkbxShowPassword = new CheckBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(323, 75);
            label1.Name = "label1";
            label1.Size = new Size(122, 36);
            label1.TabIndex = 0;
            label1.Text = "Sign up";
            // 
            // textLogin
            // 
            textLogin.BackColor = Color.FromArgb(230, 231, 233);
            textLogin.BorderStyle = BorderStyle.None;
            textLogin.Location = new Point(265, 148);
            textLogin.Multiline = true;
            textLogin.Name = "textLogin";
            textLogin.PlaceholderText = "Email";
            textLogin.Size = new Size(240, 30);
            textLogin.TabIndex = 1;
            // 
            // textPassword
            // 
            textPassword.AccessibleDescription = "";
            textPassword.AccessibleName = "";
            textPassword.BackColor = Color.FromArgb(230, 231, 233);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Location = new Point(265, 201);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.PlaceholderText = "Password";
            textPassword.Size = new Size(240, 30);
            textPassword.TabIndex = 2;
            // 
            // bRegister
            // 
            bRegister.BackColor = Color.SpringGreen;
            bRegister.BackgroundImageLayout = ImageLayout.Center;
            bRegister.FlatStyle = FlatStyle.Flat;
            bRegister.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            bRegister.Location = new Point(265, 331);
            bRegister.Name = "bRegister";
            bRegister.Size = new Size(240, 29);
            bRegister.TabIndex = 3;
            bRegister.Text = "Register";
            bRegister.UseVisualStyleBackColor = false;
            bRegister.Click += bRegister_Click;
            // 
            // textConfPass
            // 
            textConfPass.AccessibleDescription = "";
            textConfPass.AccessibleName = "";
            textConfPass.BackColor = Color.FromArgb(230, 231, 233);
            textConfPass.BorderStyle = BorderStyle.None;
            textConfPass.Location = new Point(265, 251);
            textConfPass.Multiline = true;
            textConfPass.Name = "textConfPass";
            textConfPass.PasswordChar = '*';
            textConfPass.PlaceholderText = "Confirm Password";
            textConfPass.Size = new Size(240, 30);
            textConfPass.TabIndex = 4;
            // 
            // checkbxShowPassword
            // 
            checkbxShowPassword.AutoSize = true;
            checkbxShowPassword.BackColor = Color.Transparent;
            checkbxShowPassword.FlatStyle = FlatStyle.Flat;
            checkbxShowPassword.ForeColor = Color.SpringGreen;
            checkbxShowPassword.Location = new Point(265, 296);
            checkbxShowPassword.Name = "checkbxShowPassword";
            checkbxShowPassword.Size = new Size(105, 19);
            checkbxShowPassword.TabIndex = 5;
            checkbxShowPassword.Text = "Show Password";
            checkbxShowPassword.UseVisualStyleBackColor = false;
            checkbxShowPassword.CheckedChanged += checkbxShowPassword_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SpringGreen;
            label2.Location = new Point(296, 376);
            label2.Name = "label2";
            label2.Size = new Size(177, 16);
            label2.TabIndex = 6;
            label2.Text = "Already have an account ?";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            BackgroundImage = Properties.Resources.Screenshot_2023_11_12_181420;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(checkbxShowPassword);
            Controls.Add(textConfPass);
            Controls.Add(bRegister);
            Controls.Add(textPassword);
            Controls.Add(textLogin);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textLogin;
        private TextBox textPassword;
        private Button bRegister;
        private TextBox textConfPass;
        private CheckBox checkbxShowPassword;
        private Label label2;
    }
}