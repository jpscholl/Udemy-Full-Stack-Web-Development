namespace switchForm
{
    partial class frmGetData
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
            txtName = new System.Windows.Forms.TextBox();
            txtSurname = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(222, 95);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(137, 51);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(39, 46);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new System.Drawing.Point(39, 123);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new System.Drawing.Size(100, 23);
            txtSurname.TabIndex = 2;
            // 
            // frmGetData
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(481, 281);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "frmGetData";
            Text = "frmGetData";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
    }
}
