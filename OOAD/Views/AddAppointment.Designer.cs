namespace OOAD.Views
{
    partial class AddAppointment
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
            label4 = new Label();
            label5 = new Label();
            appNameTxtBox = new TextBox();
            lctTxtBox = new TextBox();
            rmdCb = new CheckBox();
            groupBox1 = new GroupBox();
            rmdCbb = new ComboBox();
            label6 = new Label();
            okBtn = new Button();
            cancelBtn = new Button();
            hour1TxtBox = new TextBox();
            min1TxtBox = new TextBox();
            sec1TxtBox = new TextBox();
            hour2TxtBox = new TextBox();
            min2TxtBox = new TextBox();
            sec2TxtBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Add a new appointment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 44);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Appointment name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 85);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 1;
            label3.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 126);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 1;
            label4.Text = "Start time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 167);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 1;
            label5.Text = "End time";
            // 
            // appNameTxtBox
            // 
            appNameTxtBox.Location = new Point(187, 44);
            appNameTxtBox.Name = "appNameTxtBox";
            appNameTxtBox.Size = new Size(257, 23);
            appNameTxtBox.TabIndex = 2;
            // 
            // lctTxtBox
            // 
            lctTxtBox.Location = new Point(187, 82);
            lctTxtBox.Name = "lctTxtBox";
            lctTxtBox.Size = new Size(257, 23);
            lctTxtBox.TabIndex = 2;
            // 
            // rmdCb
            // 
            rmdCb.AutoSize = true;
            rmdCb.Location = new Point(47, 214);
            rmdCb.Name = "rmdCb";
            rmdCb.Size = new Size(96, 19);
            rmdCb.TabIndex = 4;
            rmdCb.Text = "Set Reminder";
            rmdCb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rmdCbb);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(47, 249);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 111);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reminder";
            // 
            // rmdCbb
            // 
            rmdCbb.FormattingEnabled = true;
            rmdCbb.Location = new Point(38, 59);
            rmdCbb.Name = "rmdCbb";
            rmdCbb.Size = new Size(121, 23);
            rmdCbb.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 29);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 0;
            label6.Text = "Remind me before";
            // 
            // okBtn
            // 
            okBtn.Location = new Point(316, 406);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 6;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(407, 406);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 6;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // hour1TxtBox
            // 
            hour1TxtBox.Location = new Point(187, 123);
            hour1TxtBox.Name = "hour1TxtBox";
            hour1TxtBox.Size = new Size(29, 23);
            hour1TxtBox.TabIndex = 7;
            // 
            // min1TxtBox
            // 
            min1TxtBox.Location = new Point(277, 123);
            min1TxtBox.Name = "min1TxtBox";
            min1TxtBox.Size = new Size(29, 23);
            min1TxtBox.TabIndex = 7;
            // 
            // sec1TxtBox
            // 
            sec1TxtBox.Location = new Point(368, 123);
            sec1TxtBox.Name = "sec1TxtBox";
            sec1TxtBox.Size = new Size(29, 23);
            sec1TxtBox.TabIndex = 7;
            // 
            // hour2TxtBox
            // 
            hour2TxtBox.Location = new Point(187, 164);
            hour2TxtBox.Name = "hour2TxtBox";
            hour2TxtBox.Size = new Size(29, 23);
            hour2TxtBox.TabIndex = 7;
            // 
            // min2TxtBox
            // 
            min2TxtBox.Location = new Point(277, 164);
            min2TxtBox.Name = "min2TxtBox";
            min2TxtBox.Size = new Size(29, 23);
            min2TxtBox.TabIndex = 7;
            // 
            // sec2TxtBox
            // 
            sec2TxtBox.Location = new Point(368, 164);
            sec2TxtBox.Name = "sec2TxtBox";
            sec2TxtBox.Size = new Size(29, 23);
            sec2TxtBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(222, 126);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 8;
            label7.Text = "Hour";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(222, 167);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 8;
            label8.Text = "Hour";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(312, 167);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 8;
            label9.Text = "Minute";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(312, 126);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 8;
            label10.Text = "Minute";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(403, 126);
            label11.Name = "label11";
            label11.Size = new Size(46, 15);
            label11.TabIndex = 8;
            label11.Text = "Second";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(403, 167);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 8;
            label12.Text = "Second";
            // 
            // AddAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(sec2TxtBox);
            Controls.Add(sec1TxtBox);
            Controls.Add(min2TxtBox);
            Controls.Add(hour2TxtBox);
            Controls.Add(min1TxtBox);
            Controls.Add(hour1TxtBox);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(groupBox1);
            Controls.Add(rmdCb);
            Controls.Add(lctTxtBox);
            Controls.Add(appNameTxtBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddAppointment";
            Text = "Add a new Appointment";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox appNameTxtBox;
        private TextBox lctTxtBox;
        private CheckBox rmdCb;
        private GroupBox groupBox1;
        private Button okBtn;
        private Button cancelBtn;
        private ComboBox rmdCbb;
        private Label label6;
        private TextBox hour1TxtBox;
        private TextBox min1TxtBox;
        private TextBox sec1TxtBox;
        private TextBox hour2TxtBox;
        private TextBox min2TxtBox;
        private TextBox sec2TxtBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}