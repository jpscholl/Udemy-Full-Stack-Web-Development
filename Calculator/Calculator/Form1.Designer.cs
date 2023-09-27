namespace Calculator
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
            groupBox1 = new GroupBox();
            btnLog10 = new Button();
            btnTan = new Button();
            btnAbs = new Button();
            btnLog = new Button();
            btnCos = new Button();
            btnMax = new Button();
            btnSqrt = new Button();
            btnSin = new Button();
            btnMin = new Button();
            btnPow = new Button();
            btnCopyFirst = new Button();
            btnExp = new Button();
            btnSign = new Button();
            ctnC = new Button();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            txtResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLog10);
            groupBox1.Controls.Add(btnTan);
            groupBox1.Controls.Add(btnAbs);
            groupBox1.Controls.Add(btnLog);
            groupBox1.Controls.Add(btnCos);
            groupBox1.Controls.Add(btnMax);
            groupBox1.Controls.Add(btnSqrt);
            groupBox1.Controls.Add(btnSin);
            groupBox1.Controls.Add(btnMin);
            groupBox1.Controls.Add(btnPow);
            groupBox1.Controls.Add(btnCopyFirst);
            groupBox1.Controls.Add(btnExp);
            groupBox1.Controls.Add(btnSign);
            groupBox1.Controls.Add(ctnC);
            groupBox1.Location = new Point(416, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 384);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnLog10
            // 
            btnLog10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLog10.Location = new Point(270, 180);
            btnLog10.Name = "btnLog10";
            btnLog10.Size = new Size(67, 59);
            btnLog10.TabIndex = 15;
            btnLog10.Text = "Log10";
            btnLog10.UseVisualStyleBackColor = true;
            btnLog10.Click += btnLog10_Click;
            // 
            // btnTan
            // 
            btnTan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTan.Location = new Point(270, 98);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(67, 59);
            btnTan.TabIndex = 11;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = true;
            btnTan.Click += btnTan_Click;
            // 
            // btnAbs
            // 
            btnAbs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbs.Location = new Point(270, 22);
            btnAbs.Name = "btnAbs";
            btnAbs.Size = new Size(67, 59);
            btnAbs.TabIndex = 7;
            btnAbs.Text = "Abs";
            btnAbs.UseVisualStyleBackColor = true;
            btnAbs.Click += btnAbs_Click;
            // 
            // btnLog
            // 
            btnLog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLog.Location = new Point(186, 180);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(67, 59);
            btnLog.TabIndex = 14;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnCos
            // 
            btnCos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCos.Location = new Point(186, 98);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(67, 59);
            btnCos.TabIndex = 10;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = true;
            btnCos.Click += btnCos_Click;
            // 
            // btnMax
            // 
            btnMax.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMax.Location = new Point(186, 22);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(67, 59);
            btnMax.TabIndex = 6;
            btnMax.Text = "Max";
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSqrt.Location = new Point(101, 180);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(67, 59);
            btnSqrt.TabIndex = 13;
            btnSqrt.Text = "Sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += btnSqrt_Click;
            // 
            // btnSin
            // 
            btnSin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSin.Location = new Point(101, 98);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(67, 59);
            btnSin.TabIndex = 9;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = true;
            btnSin.Click += btnSin_Click;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMin.Location = new Point(101, 22);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(67, 59);
            btnMin.TabIndex = 5;
            btnMin.Text = "Min";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnPow
            // 
            btnPow.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPow.Location = new Point(19, 180);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(67, 59);
            btnPow.TabIndex = 12;
            btnPow.Text = "Pow";
            btnPow.UseVisualStyleBackColor = true;
            btnPow.Click += btnPow_Click;
            // 
            // btnCopyFirst
            // 
            btnCopyFirst.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCopyFirst.Location = new Point(186, 264);
            btnCopyFirst.Name = "btnCopyFirst";
            btnCopyFirst.Size = new Size(151, 59);
            btnCopyFirst.TabIndex = 17;
            btnCopyFirst.Text = "Copy First";
            btnCopyFirst.UseVisualStyleBackColor = true;
            btnCopyFirst.Click += btnCopyFirst_Click;
            // 
            // btnExp
            // 
            btnExp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExp.Location = new Point(19, 264);
            btnExp.Name = "btnExp";
            btnExp.Size = new Size(67, 59);
            btnExp.TabIndex = 16;
            btnExp.Text = "Exp";
            btnExp.UseVisualStyleBackColor = true;
            btnExp.Click += btnExp_Click;
            // 
            // btnSign
            // 
            btnSign.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSign.Location = new Point(19, 98);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(67, 59);
            btnSign.TabIndex = 8;
            btnSign.Text = "Sign";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // ctnC
            // 
            ctnC.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ctnC.Location = new Point(19, 22);
            ctnC.Name = "ctnC";
            ctnC.Size = new Size(67, 59);
            ctnC.TabIndex = 4;
            ctnC.Text = "C";
            ctnC.UseVisualStyleBackColor = true;
            ctnC.Click += ctnC_Click;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstNumber.Location = new Point(223, 89);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(162, 29);
            txtFirstNumber.TabIndex = 1;
            txtFirstNumber.KeyPress += txtFirstNumber_KeyPress;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSecondNumber.Location = new Point(223, 160);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(162, 29);
            txtSecondNumber.TabIndex = 2;
            txtSecondNumber.KeyPress += txtSecondNumber_KeyPress;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtResult.Location = new Point(223, 247);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(162, 29);
            txtResult.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 89);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 0;
            label1.Text = "First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 160);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 0;
            label2.Text = "Second Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(55, 247);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 0;
            label3.Text = "Result";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(55, 307);
            button1.Name = "button1";
            button1.Size = new Size(146, 59);
            button1.TabIndex = 18;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResult);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button ctnC;
        private Button btnLog10;
        private Button btnTan;
        private Button btnAbs;
        private Button btnLog;
        private Button btnCos;
        private Button btnMax;
        private Button btnSqrt;
        private Button btnSin;
        private Button btnMin;
        private Button btnPow;
        private Button btnCopyFirst;
        private Button btnExp;
        private Button btnSign;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private TextBox txtResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}