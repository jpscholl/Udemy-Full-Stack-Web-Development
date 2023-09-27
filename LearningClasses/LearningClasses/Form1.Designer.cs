namespace LearningClasses
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
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            txtEmployeeID = new System.Windows.Forms.TextBox();
            txtEmployeeName = new System.Windows.Forms.TextBox();
            txtEmployeeAge = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(45, 61);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(180, 63);
            button1.TabIndex = 0;
            button1.Text = "Get Values";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(276, 61);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(198, 63);
            button2.TabIndex = 1;
            button2.Text = "Set Values";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new System.Drawing.Point(51, 187);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new System.Drawing.Size(141, 23);
            txtEmployeeID.TabIndex = 2;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new System.Drawing.Point(51, 237);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new System.Drawing.Size(141, 23);
            txtEmployeeName.TabIndex = 2;
            // 
            // txtEmployeeAge
            // 
            txtEmployeeAge.Location = new System.Drawing.Point(51, 290);
            txtEmployeeAge.Name = "txtEmployeeAge";
            txtEmployeeAge.Size = new System.Drawing.Size(141, 23);
            txtEmployeeAge.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(512, 61);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(215, 63);
            button3.TabIndex = 3;
            button3.Text = "Send";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(button3);
            Controls.Add(txtEmployeeAge);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Button button3;
    }
}
