namespace WinFormSwitchCase9_34
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
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            btnSwitchCase = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(105, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 21);
            label1.TabIndex = 0;
            label1.Text = "Only (2,4,6,8)";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(274, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(108, 29);
            textBox1.TabIndex = 1;
            // 
            // btnSwitchCase
            // 
            btnSwitchCase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            btnSwitchCase.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSwitchCase.Location = new System.Drawing.Point(466, 156);
            btnSwitchCase.Name = "btnSwitchCase";
            btnSwitchCase.Size = new System.Drawing.Size(109, 34);
            btnSwitchCase.TabIndex = 2;
            btnSwitchCase.Text = "SwitchCase";
            btnSwitchCase.UseVisualStyleBackColor = true;
            btnSwitchCase.Click += btnSwitchCase_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox2.Location = new System.Drawing.Point(274, 191);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(108, 29);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(105, 195);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(98, 21);
            label2.TabIndex = 4;
            label2.Text = "Only (1, 2, 3)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(btnSwitchCase);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSwitchCase;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}
