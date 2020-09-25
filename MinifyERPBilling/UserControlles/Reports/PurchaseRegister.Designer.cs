namespace MinifyERPBilling.UserControlles.Reports
{
    partial class PurchaseRegister
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
            this.label_purchaseRegister = new System.Windows.Forms.Label();
            this.dateTimePicker_fromdate = new System.Windows.Forms.DateTimePicker();
            this.label_fromdate = new System.Windows.Forms.Label();
            this.dateTimePicker_todate = new System.Windows.Forms.DateTimePicker();
            this.label_todate = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label_purchaseRegister);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 54);
            this.panel3.TabIndex = 16;
            // 
            // label_purchaseRegister
            // 
            this.label_purchaseRegister.AutoSize = true;
            this.label_purchaseRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_purchaseRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_purchaseRegister.Location = new System.Drawing.Point(21, 16);
            this.label_purchaseRegister.Name = "label_purchaseRegister";
            this.label_purchaseRegister.Size = new System.Drawing.Size(164, 24);
            this.label_purchaseRegister.TabIndex = 0;
            this.label_purchaseRegister.Text = "Purchase Register";
            // 
            // dateTimePicker_fromdate
            // 
            this.dateTimePicker_fromdate.Location = new System.Drawing.Point(168, 86);
            this.dateTimePicker_fromdate.Name = "dateTimePicker_fromdate";
            this.dateTimePicker_fromdate.Size = new System.Drawing.Size(269, 20);
            this.dateTimePicker_fromdate.TabIndex = 62;
            // 
            // label_fromdate
            // 
            this.label_fromdate.AutoSize = true;
            this.label_fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fromdate.Location = new System.Drawing.Point(27, 86);
            this.label_fromdate.Name = "label_fromdate";
            this.label_fromdate.Size = new System.Drawing.Size(93, 20);
            this.label_fromdate.TabIndex = 61;
            this.label_fromdate.Text = "From Date :";
            // 
            // dateTimePicker_todate
            // 
            this.dateTimePicker_todate.Location = new System.Drawing.Point(640, 86);
            this.dateTimePicker_todate.Name = "dateTimePicker_todate";
            this.dateTimePicker_todate.Size = new System.Drawing.Size(269, 20);
            this.dateTimePicker_todate.TabIndex = 64;
            // 
            // label_todate
            // 
            this.label_todate.AutoSize = true;
            this.label_todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_todate.Location = new System.Drawing.Point(505, 86);
            this.label_todate.Name = "label_todate";
            this.label_todate.Size = new System.Drawing.Size(74, 20);
            this.label_todate.TabIndex = 63;
            this.label_todate.Text = "To Date :";
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(410, 137);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(164, 42);
            this.btn_view.TabIndex = 93;
            this.btn_view.Text = "View ";
            this.btn_view.UseVisualStyleBackColor = false;
            // 
            // PurchaseRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dateTimePicker_todate);
            this.Controls.Add(this.label_todate);
            this.Controls.Add(this.dateTimePicker_fromdate);
            this.Controls.Add(this.label_fromdate);
            this.Controls.Add(this.panel3);
            this.Name = "PurchaseRegister";
            this.Size = new System.Drawing.Size(985, 193);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_purchaseRegister;
        private System.Windows.Forms.DateTimePicker dateTimePicker_fromdate;
        private System.Windows.Forms.Label label_fromdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_todate;
        private System.Windows.Forms.Label label_todate;
        private System.Windows.Forms.Button btn_view;
    }
}
