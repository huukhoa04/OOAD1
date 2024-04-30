namespace OOAD
{
    partial class logInForm
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
            passwordTxtBox = new TextBox();
            nameTxtBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            logInBtn = new Button();
            signUpBtn = new Button();
            SuspendLayout();
            // 
            // passwordTxtBox
            // 
            passwordTxtBox.Location = new Point(120, 102);
            passwordTxtBox.Name = "passwordTxtBox";
            passwordTxtBox.PasswordChar = '*';
            passwordTxtBox.Size = new Size(218, 23);
            passwordTxtBox.TabIndex = 5;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(120, 58);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(218, 23);
            nameTxtBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 102);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 61);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Đăng nhập";
            // 
            // logInBtn
            // 
            logInBtn.Location = new Point(21, 157);
            logInBtn.Name = "logInBtn";
            logInBtn.Size = new Size(141, 24);
            logInBtn.TabIndex = 8;
            logInBtn.Text = "Đăng nhập";
            logInBtn.UseVisualStyleBackColor = true;
            logInBtn.Click += logInBtn_Click;
            // 
            // signUpBtn
            // 
            signUpBtn.Location = new Point(187, 158);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(151, 23);
            signUpBtn.TabIndex = 9;
            signUpBtn.Text = "Đăng kí";
            signUpBtn.UseVisualStyleBackColor = true;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // logInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 223);
            Controls.Add(signUpBtn);
            Controls.Add(logInBtn);
            Controls.Add(label1);
            Controls.Add(passwordTxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "logInForm";
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTxtBox;
        private TextBox nameTxtBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button logInBtn;
        private Button signUpBtn;
    }
}
