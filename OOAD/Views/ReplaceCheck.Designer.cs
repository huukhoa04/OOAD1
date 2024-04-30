namespace OOAD.Views
{
    partial class ReplaceCheck
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
            okBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 41);
            label1.Name = "label1";
            label1.Size = new Size(336, 15);
            label1.TabIndex = 0;
            label1.Text = "There's already an appointment occuring at this period of time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 69);
            label2.Name = "label2";
            label2.Size = new Size(251, 15);
            label2.TabIndex = 0;
            label2.Text = "Would you like to overwrite this appointment?";
            // 
            // okBtn
            // 
            okBtn.Location = new Point(140, 120);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 1;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += okBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(362, 120);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // ReplaceCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 197);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ReplaceCheck";
            Text = "ReplaceCheck";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button okBtn;
        private Button cancelBtn;
    }
}