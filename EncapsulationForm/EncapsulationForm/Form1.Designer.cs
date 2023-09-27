namespace EncapsulationForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            txtEmployeeAge = new TextBox();
            txtEmployeePosition = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(65, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 19);
            label1.TabIndex = 0;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(65, 119);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 1;
            label2.Text = "EmployeeName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(65, 162);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 19);
            label3.TabIndex = 2;
            label3.Text = "Employee Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(65, 200);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 19);
            label4.TabIndex = 3;
            label4.Text = "Employee Position";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(225, 75);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(120, 26);
            txtEmployeeID.TabIndex = 4;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(225, 112);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(120, 26);
            txtEmployeeName.TabIndex = 5;
            // 
            // txtEmployeeAge
            // 
            txtEmployeeAge.Location = new Point(225, 155);
            txtEmployeeAge.Name = "txtEmployeeAge";
            txtEmployeeAge.Size = new Size(120, 26);
            txtEmployeeAge.TabIndex = 6;
            // 
            // txtEmployeePosition
            // 
            txtEmployeePosition.Location = new Point(225, 193);
            txtEmployeePosition.Name = "txtEmployeePosition";
            txtEmployeePosition.Size = new Size(120, 26);
            txtEmployeePosition.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(135, 273);
            button1.Name = "button1";
            button1.Size = new Size(161, 46);
            button1.TabIndex = 8;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 438);
            Controls.Add(button1);
            Controls.Add(txtEmployeePosition);
            Controls.Add(txtEmployeeAge);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private TextBox txtEmployeeAge;
        private TextBox txtEmployeePosition;
        private Button button1;
    }
}