﻿namespace MinifyERPBilling.Forms.Masters
{
    partial class JournalVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalVoucher));
            this.btn_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.txt_toAccnt = new System.Windows.Forms.TextBox();
            this.label_toAccnt = new System.Windows.Forms.Label();
            this.txt_fromAccnt = new System.Windows.Forms.TextBox();
            this.label_fromAccnt = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label_transactiondate = new System.Windows.Forms.Label();
            this.label_journalVoucher = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.ddl_type = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(361, 392);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 32);
            this.btn_save.TabIndex = 145;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(712, 150);
            this.dataGridView1.TabIndex = 144;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(682, 172);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(79, 22);
            this.btn_add.TabIndex = 143;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(565, 172);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(111, 20);
            this.txt_amount.TabIndex = 142;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.Location = new System.Drawing.Point(475, 172);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(73, 20);
            this.label_amount.TabIndex = 141;
            this.label_amount.Text = "Amount :";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_type.Location = new System.Drawing.Point(497, 128);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(51, 20);
            this.label_type.TabIndex = 139;
            this.label_type.Text = "Type :";
            // 
            // txt_toAccnt
            // 
            this.txt_toAccnt.Location = new System.Drawing.Point(200, 174);
            this.txt_toAccnt.Name = "txt_toAccnt";
            this.txt_toAccnt.Size = new System.Drawing.Size(269, 20);
            this.txt_toAccnt.TabIndex = 138;
            // 
            // label_toAccnt
            // 
            this.label_toAccnt.AutoSize = true;
            this.label_toAccnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toAccnt.Location = new System.Drawing.Point(86, 172);
            this.label_toAccnt.Name = "label_toAccnt";
            this.label_toAccnt.Size = new System.Drawing.Size(98, 20);
            this.label_toAccnt.TabIndex = 137;
            this.label_toAccnt.Text = "To Account :";
            // 
            // txt_fromAccnt
            // 
            this.txt_fromAccnt.Location = new System.Drawing.Point(200, 128);
            this.txt_fromAccnt.Name = "txt_fromAccnt";
            this.txt_fromAccnt.Size = new System.Drawing.Size(269, 20);
            this.txt_fromAccnt.TabIndex = 136;
            // 
            // label_fromAccnt
            // 
            this.label_fromAccnt.AutoSize = true;
            this.label_fromAccnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fromAccnt.Location = new System.Drawing.Point(67, 128);
            this.label_fromAccnt.Name = "label_fromAccnt";
            this.label_fromAccnt.Size = new System.Drawing.Size(117, 20);
            this.label_fromAccnt.TabIndex = 135;
            this.label_fromAccnt.Text = "From Account :";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(200, 81);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(269, 20);
            this.dateTimePicker.TabIndex = 134;
            // 
            // label_transactiondate
            // 
            this.label_transactiondate.AutoSize = true;
            this.label_transactiondate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_transactiondate.Location = new System.Drawing.Point(45, 81);
            this.label_transactiondate.Name = "label_transactiondate";
            this.label_transactiondate.Size = new System.Drawing.Size(139, 20);
            this.label_transactiondate.TabIndex = 133;
            this.label_transactiondate.Text = "Transaction Date :";
            // 
            // label_journalVoucher
            // 
            this.label_journalVoucher.AutoSize = true;
            this.label_journalVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_journalVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.label_journalVoucher.Location = new System.Drawing.Point(292, 31);
            this.label_journalVoucher.Name = "label_journalVoucher";
            this.label_journalVoucher.Size = new System.Drawing.Size(156, 25);
            this.label_journalVoucher.TabIndex = 132;
            this.label_journalVoucher.Text = "Journal Voucher";
            this.label_journalVoucher.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(790, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 430);
            this.panel4.TabIndex = 130;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 10);
            this.panel1.TabIndex = 129;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 440);
            this.panel2.TabIndex = 128;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 10);
            this.panel3.TabIndex = 127;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(757, 16);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(27, 27);
            this.btn_close.TabIndex = 131;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // ddl_type
            // 
            this.ddl_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_type.FormattingEnabled = true;
            this.ddl_type.Items.AddRange(new object[] {
            "Cr",
            "Dr"});
            this.ddl_type.Location = new System.Drawing.Point(565, 127);
            this.ddl_type.Name = "ddl_type";
            this.ddl_type.Size = new System.Drawing.Size(111, 21);
            this.ddl_type.TabIndex = 146;
            // 
            // JournalVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ddl_type);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.txt_toAccnt);
            this.Controls.Add(this.label_toAccnt);
            this.Controls.Add(this.txt_fromAccnt);
            this.Controls.Add(this.label_fromAccnt);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label_transactiondate);
            this.Controls.Add(this.label_journalVoucher);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JournalVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JournalVoucher";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TextBox txt_toAccnt;
        private System.Windows.Forms.Label label_toAccnt;
        private System.Windows.Forms.TextBox txt_fromAccnt;
        private System.Windows.Forms.Label label_fromAccnt;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label_transactiondate;
        private System.Windows.Forms.Label label_journalVoucher;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox ddl_type;
    }
}