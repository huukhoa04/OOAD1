namespace OOAD.Views
{
    partial class MainUI
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
            nameLbl = new Label();
            groupBox1 = new GroupBox();
            showBtn = new Button();
            dataGridView1 = new DataGridView();
            groupBox2 = new GroupBox();
            createBtn = new Button();
            label2 = new Label();
            monthCalendar1 = new MonthCalendar();
            logOutBtn = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Hello, ";
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(79, 9);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(37, 15);
            nameLbl.TabIndex = 1;
            nameLbl.Text = "name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(showBtn);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(32, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(348, 359);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Check your appointments";
            // 
            // showBtn
            // 
            showBtn.Location = new Point(87, 22);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(160, 23);
            showBtn.TabIndex = 1;
            showBtn.Text = "Show your appointments";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(336, 294);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(createBtn);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(monthCalendar1);
            groupBox2.Location = new Point(442, 49);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(346, 278);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Create a new appointment";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(64, 233);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(227, 23);
            createBtn.TabIndex = 2;
            createBtn.Text = "Create an appointment";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 30);
            label2.Name = "label2";
            label2.Size = new Size(271, 15);
            label2.TabIndex = 1;
            label2.Text = "Pick your desired date then click the button below";
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.HotTrack;
            monthCalendar1.Location = new Point(64, 59);
            monthCalendar1.MaxSelectionCount = 1;
            monthCalendar1.MinDate = new DateTime(2024, 4, 29, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.TrailingForeColor = SystemColors.HotTrack;
            // 
            // logOutBtn
            // 
            logOutBtn.Location = new Point(305, 9);
            logOutBtn.Name = "logOutBtn";
            logOutBtn.Size = new Size(75, 23);
            logOutBtn.TabIndex = 4;
            logOutBtn.Text = "Log out";
            logOutBtn.UseVisualStyleBackColor = true;
            logOutBtn.Click += logOutBtn_Click;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logOutBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(nameLbl);
            Controls.Add(label1);
            Name = "MainUI";
            Text = "MainUI";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nameLbl;
        private GroupBox groupBox1;
        private Button showBtn;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private MonthCalendar monthCalendar1;
        private Button createBtn;
        private Label label2;
        private Button logOutBtn;
    }
}