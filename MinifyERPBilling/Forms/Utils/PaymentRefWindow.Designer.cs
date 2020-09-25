namespace MinifyERPBilling.Forms.Utils
{
    partial class PaymentRefWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentRefWindow));
            this.label_billwisedetailsfor = new System.Windows.Forms.Label();
            this.label_upto = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_amount = new System.Windows.Forms.Label();
            this.btn_closeForPaymentRef = new System.Windows.Forms.Button();
            this.ddl_typeOfRef = new System.Windows.Forms.ComboBox();
            this.label_typeOfRef = new System.Windows.Forms.Label();
            this.label_nameof = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label_dueDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_forAmount = new System.Windows.Forms.Label();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_billwisedetailsfor
            // 
            this.label_billwisedetailsfor.AutoSize = true;
            this.label_billwisedetailsfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_billwisedetailsfor.Location = new System.Drawing.Point(62, 27);
            this.label_billwisedetailsfor.Name = "label_billwisedetailsfor";
            this.label_billwisedetailsfor.Size = new System.Drawing.Size(154, 20);
            this.label_billwisedetailsfor.TabIndex = 1;
            this.label_billwisedetailsfor.Text = "Bill-Wise Details For:";
            // 
            // label_upto
            // 
            this.label_upto.AutoSize = true;
            this.label_upto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_upto.Location = new System.Drawing.Point(62, 59);
            this.label_upto.Name = "label_upto";
            this.label_upto.Size = new System.Drawing.Size(48, 20);
            this.label_upto.TabIndex = 3;
            this.label_upto.Text = "Upto:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(222, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 20);
            this.label_name.TabIndex = 5;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(116, 36);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(0, 20);
            this.label_amount.TabIndex = 6;
            // 
            // btn_closeForPaymentRef
            // 
            this.btn_closeForPaymentRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btn_closeForPaymentRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeForPaymentRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closeForPaymentRef.ForeColor = System.Drawing.Color.White;
            this.btn_closeForPaymentRef.Location = new System.Drawing.Point(197, 330);
            this.btn_closeForPaymentRef.Name = "btn_closeForPaymentRef";
            this.btn_closeForPaymentRef.Size = new System.Drawing.Size(89, 32);
            this.btn_closeForPaymentRef.TabIndex = 89;
            this.btn_closeForPaymentRef.Text = "CLOSE";
            this.btn_closeForPaymentRef.UseVisualStyleBackColor = false;
            this.btn_closeForPaymentRef.Click += new System.EventHandler(this.btn_closeForPaymentRef_Click);
            // 
            // ddl_typeOfRef
            // 
            this.ddl_typeOfRef.AutoCompleteCustomSource.AddRange(new string[] {
            "Bank Account",
            "Bank CC A/C",
            "Bank OD A/C"});
            this.ddl_typeOfRef.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_typeOfRef.FormattingEnabled = true;
            this.ddl_typeOfRef.Items.AddRange(new object[] {
            "Advance",
            "Agst Ref",
            "New Ref",
            "On Account"});
            this.ddl_typeOfRef.Location = new System.Drawing.Point(173, 107);
            this.ddl_typeOfRef.Name = "ddl_typeOfRef";
            this.ddl_typeOfRef.Size = new System.Drawing.Size(187, 21);
            this.ddl_typeOfRef.TabIndex = 88;
            // 
            // label_typeOfRef
            // 
            this.label_typeOfRef.AutoSize = true;
            this.label_typeOfRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_typeOfRef.Location = new System.Drawing.Point(25, 108);
            this.label_typeOfRef.Name = "label_typeOfRef";
            this.label_typeOfRef.Size = new System.Drawing.Size(98, 20);
            this.label_typeOfRef.TabIndex = 87;
            this.label_typeOfRef.Text = "Type Of Ref:";
            // 
            // label_nameof
            // 
            this.label_nameof.AutoSize = true;
            this.label_nameof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nameof.Location = new System.Drawing.Point(25, 151);
            this.label_nameof.Name = "label_nameof";
            this.label_nameof.Size = new System.Drawing.Size(55, 20);
            this.label_nameof.TabIndex = 90;
            this.label_nameof.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(173, 151);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(187, 20);
            this.txt_name.TabIndex = 91;
            // 
            // label_dueDate
            // 
            this.label_dueDate.AutoSize = true;
            this.label_dueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dueDate.Location = new System.Drawing.Point(25, 196);
            this.label_dueDate.Name = "label_dueDate";
            this.label_dueDate.Size = new System.Drawing.Size(190, 20);
            this.label_dueDate.TabIndex = 92;
            this.label_dueDate.Text = "Due Date, or Credit Days:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(236, 197);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker.TabIndex = 93;
            // 
            // label_forAmount
            // 
            this.label_forAmount.AutoSize = true;
            this.label_forAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_forAmount.Location = new System.Drawing.Point(25, 240);
            this.label_forAmount.Name = "label_forAmount";
            this.label_forAmount.Size = new System.Drawing.Size(116, 20);
            this.label_forAmount.TabIndex = 94;
            this.label_forAmount.Text = "Amount(Dr/Cr):";
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(173, 242);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(187, 20);
            this.txt_amount.TabIndex = 95;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(102, 330);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 32);
            this.btn_save.TabIndex = 97;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 14);
            this.panel1.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel2.Location = new System.Drawing.Point(-1, 436);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 14);
            this.panel2.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel3.Location = new System.Drawing.Point(382, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(19, 425);
            this.panel3.TabIndex = 100;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel4.Location = new System.Drawing.Point(0, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 425);
            this.panel4.TabIndex = 101;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(349, 20);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(27, 27);
            this.btn_close.TabIndex = 96;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // PaymentRefWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label_forAmount);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label_dueDate);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label_nameof);
            this.Controls.Add(this.btn_closeForPaymentRef);
            this.Controls.Add(this.ddl_typeOfRef);
            this.Controls.Add(this.label_typeOfRef);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_upto);
            this.Controls.Add(this.label_billwisedetailsfor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentRefWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentRefWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_billwisedetailsfor;
        private System.Windows.Forms.Label label_upto;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Button btn_closeForPaymentRef;
        private System.Windows.Forms.ComboBox ddl_typeOfRef;
        private System.Windows.Forms.Label label_typeOfRef;
        private System.Windows.Forms.Label label_nameof;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label_dueDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label_forAmount;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}