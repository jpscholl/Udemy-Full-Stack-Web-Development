namespace LearningClasses
{
    partial class Form2
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
            lblEmployeeID = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            lblAge = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lblEmployeeID
            // 
            lblEmployeeID.AutoSize = true;
            lblEmployeeID.Location = new System.Drawing.Point(64, 62);
            lblEmployeeID.Name = "lblEmployeeID";
            lblEmployeeID.Size = new System.Drawing.Size(73, 15);
            lblEmployeeID.TabIndex = 0;
            lblEmployeeID.Text = "Employee ID";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(143, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(126, 23);
            textBox1.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new System.Drawing.Point(64, 154);
            lblAge.Name = "lblAge";
            lblAge.Size = new System.Drawing.Size(28, 15);
            lblAge.TabIndex = 0;
            lblAge.Text = "Age";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(143, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(126, 23);
            textBox2.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(64, 105);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(143, 97);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(126, 23);
            textBox3.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblName);
            Controls.Add(lblAge);
            Controls.Add(lblEmployeeID);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox3;
    }
}