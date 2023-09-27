namespace ListClassForm
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
            btnFillList = new Button();
            txtNumber = new TextBox();
            cmbDays = new ComboBox();
            daylist = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)daylist).BeginInit();
            SuspendLayout();
            // 
            // btnFillList
            // 
            btnFillList.Location = new Point(456, 101);
            btnFillList.Name = "btnFillList";
            btnFillList.Size = new Size(159, 88);
            btnFillList.TabIndex = 0;
            btnFillList.Text = "Fill List";
            btnFillList.UseVisualStyleBackColor = true;
            btnFillList.Click += btnFillList_Click;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(57, 101);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(234, 158);
            txtNumber.TabIndex = 1;
            // 
            // cmbDays
            // 
            cmbDays.FormattingEnabled = true;
            cmbDays.Location = new Point(471, 279);
            cmbDays.Name = "cmbDays";
            cmbDays.Size = new Size(121, 23);
            cmbDays.TabIndex = 2;
            cmbDays.SelectedIndexChanged += cmbDays_SelectedIndexChanged;
            // 
            // daylist
            // 
            daylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            daylist.Location = new Point(421, 381);
            daylist.Name = "daylist";
            daylist.RowTemplate.Height = 25;
            daylist.Size = new Size(385, 215);
            daylist.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 666);
            Controls.Add(daylist);
            Controls.Add(cmbDays);
            Controls.Add(txtNumber);
            Controls.Add(btnFillList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)daylist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFillList;
        private TextBox txtNumber;
        private ComboBox cmbDays;
        private DataGridView daylist;
    }
}