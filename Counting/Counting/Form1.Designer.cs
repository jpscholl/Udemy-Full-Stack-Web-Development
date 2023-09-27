namespace Counting
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
            label2 = new System.Windows.Forms.Label();
            txtStartFrom = new System.Windows.Forms.TextBox();
            txtTo = new System.Windows.Forms.TextBox();
            btnCount = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            cmbDivisible = new System.Windows.Forms.ComboBox();
            txtDivisibleNumbers = new System.Windows.Forms.TextBox();
            gpColor = new System.Windows.Forms.GroupBox();
            rdGreen = new System.Windows.Forms.RadioButton();
            rdBlue = new System.Windows.Forms.RadioButton();
            rdRed = new System.Windows.Forms.RadioButton();
            rdBlack = new System.Windows.Forms.RadioButton();
            chBold = new System.Windows.Forms.CheckBox();
            chItalic = new System.Windows.Forms.CheckBox();
            gpColor.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(47, 76);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Start From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(288, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 20);
            label2.TabIndex = 0;
            label2.Text = "To";
            // 
            // txtStartFrom
            // 
            txtStartFrom.Location = new System.Drawing.Point(159, 73);
            txtStartFrom.Name = "txtStartFrom";
            txtStartFrom.Size = new System.Drawing.Size(100, 23);
            txtStartFrom.TabIndex = 0;
            txtStartFrom.KeyPress += txtStartFrom_KeyPress;
            // 
            // txtTo
            // 
            txtTo.Location = new System.Drawing.Point(352, 73);
            txtTo.Name = "txtTo";
            txtTo.Size = new System.Drawing.Size(100, 23);
            txtTo.TabIndex = 1;
            txtTo.KeyPress += txtTo_KeyPress;
            // 
            // btnCount
            // 
            btnCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCount.Location = new System.Drawing.Point(245, 204);
            btnCount.Name = "btnCount";
            btnCount.Size = new System.Drawing.Size(103, 34);
            btnCount.TabIndex = 6;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(413, 204);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(98, 34);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(47, 141);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(142, 20);
            label3.TabIndex = 0;
            label3.Text = "Divisible Number";
            // 
            // cmbDivisible
            // 
            cmbDivisible.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbDivisible.FormattingEnabled = true;
            cmbDivisible.Location = new System.Drawing.Point(195, 137);
            cmbDivisible.Name = "cmbDivisible";
            cmbDivisible.Size = new System.Drawing.Size(121, 29);
            cmbDivisible.TabIndex = 2;
            cmbDivisible.SelectedIndexChanged += cmbDivisible_SelectedIndexChanged;
            // 
            // txtDivisibleNumbers
            // 
            txtDivisibleNumbers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDivisibleNumbers.Location = new System.Drawing.Point(0, 274);
            txtDivisibleNumbers.Multiline = true;
            txtDivisibleNumbers.Name = "txtDivisibleNumbers";
            txtDivisibleNumbers.Size = new System.Drawing.Size(799, 177);
            txtDivisibleNumbers.TabIndex = 4;
            // 
            // gpColor
            // 
            gpColor.Controls.Add(rdGreen);
            gpColor.Controls.Add(rdBlue);
            gpColor.Controls.Add(rdRed);
            gpColor.Controls.Add(rdBlack);
            gpColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gpColor.Location = new System.Drawing.Point(528, 50);
            gpColor.Name = "gpColor";
            gpColor.Size = new System.Drawing.Size(244, 197);
            gpColor.TabIndex = 5;
            gpColor.TabStop = false;
            gpColor.Text = "Select Color";
            // 
            // rdGreen
            // 
            rdGreen.AutoSize = true;
            rdGreen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdGreen.ForeColor = System.Drawing.Color.Green;
            rdGreen.Location = new System.Drawing.Point(13, 116);
            rdGreen.Name = "rdGreen";
            rdGreen.Size = new System.Drawing.Size(62, 21);
            rdGreen.TabIndex = 0;
            rdGreen.Text = "Green";
            rdGreen.UseVisualStyleBackColor = true;
            rdGreen.CheckedChanged += rdGreen_CheckedChanged;
            // 
            // rdBlue
            // 
            rdBlue.AutoSize = true;
            rdBlue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdBlue.ForeColor = System.Drawing.Color.Blue;
            rdBlue.Location = new System.Drawing.Point(13, 91);
            rdBlue.Name = "rdBlue";
            rdBlue.Size = new System.Drawing.Size(53, 21);
            rdBlue.TabIndex = 0;
            rdBlue.Text = "Blue";
            rdBlue.UseVisualStyleBackColor = true;
            rdBlue.CheckedChanged += rdBlue_CheckedChanged;
            // 
            // rdRed
            // 
            rdRed.AutoSize = true;
            rdRed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdRed.ForeColor = System.Drawing.Color.Red;
            rdRed.Location = new System.Drawing.Point(13, 66);
            rdRed.Name = "rdRed";
            rdRed.Size = new System.Drawing.Size(49, 21);
            rdRed.TabIndex = 0;
            rdRed.Text = "Red";
            rdRed.UseVisualStyleBackColor = true;
            rdRed.CheckedChanged += rdRed_CheckedChanged;
            // 
            // rdBlack
            // 
            rdBlack.AutoSize = true;
            rdBlack.Checked = true;
            rdBlack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rdBlack.Location = new System.Drawing.Point(13, 41);
            rdBlack.Name = "rdBlack";
            rdBlack.Size = new System.Drawing.Size(58, 21);
            rdBlack.TabIndex = 0;
            rdBlack.TabStop = true;
            rdBlack.Text = "Black";
            rdBlack.UseVisualStyleBackColor = true;
            rdBlack.CheckedChanged += rdBlack_CheckedChanged;
            // 
            // chBold
            // 
            chBold.AutoSize = true;
            chBold.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chBold.Location = new System.Drawing.Point(48, 193);
            chBold.Name = "chBold";
            chBold.Size = new System.Drawing.Size(55, 21);
            chBold.TabIndex = 3;
            chBold.Text = "Bold";
            chBold.UseVisualStyleBackColor = true;
            chBold.CheckedChanged += chBold_CheckedChanged;
            // 
            // chItalic
            // 
            chItalic.AutoSize = true;
            chItalic.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            chItalic.Location = new System.Drawing.Point(48, 219);
            chItalic.Name = "chItalic";
            chItalic.Size = new System.Drawing.Size(53, 21);
            chItalic.TabIndex = 4;
            chItalic.Text = "Italic";
            chItalic.UseVisualStyleBackColor = true;
            chItalic.CheckedChanged += chItalic_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(chItalic);
            Controls.Add(chBold);
            Controls.Add(gpColor);
            Controls.Add(txtDivisibleNumbers);
            Controls.Add(cmbDivisible);
            Controls.Add(btnExit);
            Controls.Add(btnCount);
            Controls.Add(txtTo);
            Controls.Add(txtStartFrom);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Counting Numbers";
            Load += Form1_Load;
            gpColor.ResumeLayout(false);
            gpColor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDivisible;
        private System.Windows.Forms.TextBox txtDivisibleNumbers;
        private System.Windows.Forms.GroupBox gpColor;
        private System.Windows.Forms.RadioButton rdGreen;
        private System.Windows.Forms.RadioButton rdBlue;
        private System.Windows.Forms.RadioButton rdRed;
        private System.Windows.Forms.RadioButton rdBlack;
        private System.Windows.Forms.CheckBox chBold;
        private System.Windows.Forms.CheckBox chItalic;
    }
}
