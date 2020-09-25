namespace MinifyERPBilling.UserControlles.Reports
{
    partial class AccountLedgerReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewLedger = new System.Windows.Forms.Button();
            this.label_AccntHeadname = new System.Windows.Forms.Label();
            this.textBox_accountHeadName = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 54);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Ledger Report";
            // 
            // btn_viewLedger
            // 
            this.btn_viewLedger.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_viewLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewLedger.ForeColor = System.Drawing.Color.White;
            this.btn_viewLedger.Location = new System.Drawing.Point(650, 68);
            this.btn_viewLedger.Name = "btn_viewLedger";
            this.btn_viewLedger.Size = new System.Drawing.Size(164, 42);
            this.btn_viewLedger.TabIndex = 92;
            this.btn_viewLedger.Text = "View Ledger";
            this.btn_viewLedger.UseVisualStyleBackColor = false;
            // 
            // label_AccntHeadname
            // 
            this.label_AccntHeadname.AutoSize = true;
            this.label_AccntHeadname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccntHeadname.Location = new System.Drawing.Point(21, 76);
            this.label_AccntHeadname.Name = "label_AccntHeadname";
            this.label_AccntHeadname.Size = new System.Drawing.Size(169, 20);
            this.label_AccntHeadname.TabIndex = 91;
            this.label_AccntHeadname.Text = " Account Head Name :";
            // 
            // textBox_accountHeadName
            // 
            this.textBox_accountHeadName.Location = new System.Drawing.Point(209, 76);
            this.textBox_accountHeadName.Name = "textBox_accountHeadName";
            this.textBox_accountHeadName.Size = new System.Drawing.Size(419, 20);
            this.textBox_accountHeadName.TabIndex = 93;
            // 
            // AccountLedgerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_accountHeadName);
            this.Controls.Add(this.btn_viewLedger);
            this.Controls.Add(this.label_AccntHeadname);
            this.Controls.Add(this.panel3);
            this.Name = "AccountLedgerReport";
            this.Size = new System.Drawing.Size(985, 125);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_viewLedger;
        private System.Windows.Forms.Label label_AccntHeadname;
        private System.Windows.Forms.TextBox textBox_accountHeadName;
    }
}
