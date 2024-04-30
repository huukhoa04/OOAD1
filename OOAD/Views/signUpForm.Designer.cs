namespace OOAD.Views
{
    partial class signUpForm
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
            label3 = new Label();
            logNameTxtBox = new TextBox();
            passwordTxtBox = new TextBox();
            signUpBtn = new Button();
            label4 = new Label();
            confirmPasswordTxtBox = new TextBox();
            label5 = new Label();
            userNameTxtBox = new TextBox();
            passwordLbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Đăng kí";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 1;
            label3.Text = "Mật khẩu";
            // 
            // logNameTxtBox
            // 
            logNameTxtBox.Location = new Point(132, 45);
            logNameTxtBox.Name = "logNameTxtBox";
            logNameTxtBox.Size = new Size(218, 23);
            logNameTxtBox.TabIndex = 2;
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(132, 126);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.Size = new Size(218, 23);
            passwordTxtBox.TabIndex = 2;
            passwordTxtBox.TextChanged += passwordTxtBox_TextChanged;
            // 
            // signUpBtn
            // 
            signUpBtn.Location = new Point(142, 220);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(75, 23);
            signUpBtn.TabIndex = 3;
            signUpBtn.Text = "Đăng kí";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 167);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 1;
            label4.Text = "Xác nhận mật khẩu";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // confirmPasswordTxtBox
            // 
            confirmPasswordTxtBox.Location = new Point(132, 164);
            confirmPasswordTxtBox.Name = "confirmPasswordTxtBox";
            confirmPasswordTxtBox.PasswordChar = '*';
            confirmPasswordTxtBox.Size = new Size(218, 23);
            confirmPasswordTxtBox.TabIndex = 2;
            confirmPasswordTxtBox.TextChanged += confirmPasswordTxtBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 88);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 1;
            label5.Text = "Tên thật";
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.Location = new Point(132, 85);
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(218, 23);
            userNameTxtBox.TabIndex = 2;
            userNameTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.Location = new Point(110, 190);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(143, 15);
            passwordLbl.TabIndex = 4;
            passwordLbl.Text = "Password does not match";
            passwordLbl.Visible = false;
            // 
            // signUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 270);
            Controls.Add(passwordLbl);
            Controls.Add(signUpBtn);
            Controls.Add(confirmPasswordTxtBox);
            Controls.Add(passwordTxtBox);
            Controls.Add(label4);
            Controls.Add(userNameTxtBox);
            Controls.Add(logNameTxtBox);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "signUpForm";
            Text = "Đăng kí";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox logNameTxtBox;
        private TextBox passwordTxtBox;
        private Button signUpBtn;
        private Label label4;
        private TextBox confirmPasswordTxtBox;
        private Label label5;
        private TextBox userNameTxtBox;
        private Label passwordLbl;
    }
}