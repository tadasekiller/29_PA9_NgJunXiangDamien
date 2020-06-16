namespace _29_PA9_NgJunXiangDamien
{
    partial class Form1
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
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_selectcurrency = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.txt_convertedamt = new System.Windows.Forms.TextBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rdb_USdollars = new System.Windows.Forms.RadioButton();
            this.rdb_JapYen = new System.Windows.Forms.RadioButton();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(123, 40);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(100, 20);
            this.txt_amount.TabIndex = 0;
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(29, 43);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_amount.TabIndex = 1;
            this.lbl_amount.Text = "Amount";
            this.lbl_amount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_selectcurrency
            // 
            this.lbl_selectcurrency.AutoSize = true;
            this.lbl_selectcurrency.Location = new System.Drawing.Point(29, 100);
            this.lbl_selectcurrency.Name = "lbl_selectcurrency";
            this.lbl_selectcurrency.Size = new System.Drawing.Size(82, 13);
            this.lbl_selectcurrency.TabIndex = 2;
            this.lbl_selectcurrency.Text = "Select Currency";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(29, 174);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(34, 13);
            this.lbl_value.TabIndex = 3;
            this.lbl_value.Text = "Value";
            // 
            // txt_convertedamt
            // 
            this.txt_convertedamt.Location = new System.Drawing.Point(123, 171);
            this.txt_convertedamt.Name = "txt_convertedamt";
            this.txt_convertedamt.ReadOnly = true;
            this.txt_convertedamt.Size = new System.Drawing.Size(75, 20);
            this.txt_convertedamt.TabIndex = 4;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(319, 134);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(75, 23);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(319, 171);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rdb_USdollars
            // 
            this.rdb_USdollars.AutoSize = true;
            this.rdb_USdollars.Location = new System.Drawing.Point(133, 100);
            this.rdb_USdollars.Name = "rdb_USdollars";
            this.rdb_USdollars.Size = new System.Drawing.Size(75, 17);
            this.rdb_USdollars.TabIndex = 7;
            this.rdb_USdollars.TabStop = true;
            this.rdb_USdollars.Text = "US Dollars";
            this.rdb_USdollars.UseVisualStyleBackColor = true;
            // 
            // rdb_JapYen
            // 
            this.rdb_JapYen.AutoSize = true;
            this.rdb_JapYen.Location = new System.Drawing.Point(133, 134);
            this.rdb_JapYen.Name = "rdb_JapYen";
            this.rdb_JapYen.Size = new System.Drawing.Size(93, 17);
            this.rdb_JapYen.TabIndex = 8;
            this.rdb_JapYen.TabStop = true;
            this.rdb_JapYen.Text = "Japanese Yen";
            this.rdb_JapYen.UseVisualStyleBackColor = true;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Location = new System.Drawing.Point(120, 194);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 224);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.rdb_JapYen);
            this.Controls.Add(this.rdb_USdollars);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.txt_convertedamt);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.lbl_selectcurrency);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.txt_amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_selectcurrency;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.TextBox txt_convertedamt;
        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.RadioButton rdb_USdollars;
        private System.Windows.Forms.RadioButton rdb_JapYen;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.RadioButton rdb_malaysia;

    }
}

