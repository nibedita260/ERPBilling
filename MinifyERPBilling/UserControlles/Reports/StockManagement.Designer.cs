namespace MinifyERPBilling.UserControlles.Reports
{
    partial class StockManagement
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
            this.label_stockManagement = new System.Windows.Forms.Label();
            this.btn_view = new System.Windows.Forms.Button();
            this.label_itemName = new System.Windows.Forms.Label();
            this.textBox_itemName = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label_stockManagement);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(985, 54);
            this.panel3.TabIndex = 17;
            // 
            // label_stockManagement
            // 
            this.label_stockManagement.AutoSize = true;
            this.label_stockManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stockManagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_stockManagement.Location = new System.Drawing.Point(21, 16);
            this.label_stockManagement.Name = "label_stockManagement";
            this.label_stockManagement.Size = new System.Drawing.Size(172, 24);
            this.label_stockManagement.TabIndex = 0;
            this.label_stockManagement.Text = "Stock Management";
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.White;
            this.btn_view.Location = new System.Drawing.Point(570, 67);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(164, 42);
            this.btn_view.TabIndex = 95;
            this.btn_view.Text = "View ";
            this.btn_view.UseVisualStyleBackColor = false;
            // 
            // label_itemName
            // 
            this.label_itemName.AutoSize = true;
            this.label_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_itemName.Location = new System.Drawing.Point(27, 75);
            this.label_itemName.Name = "label_itemName";
            this.label_itemName.Size = new System.Drawing.Size(99, 20);
            this.label_itemName.TabIndex = 94;
            this.label_itemName.Text = " Item Name :";
            // 
            // textBox_itemName
            // 
            this.textBox_itemName.Location = new System.Drawing.Point(149, 75);
            this.textBox_itemName.Name = "textBox_itemName";
            this.textBox_itemName.Size = new System.Drawing.Size(394, 20);
            this.textBox_itemName.TabIndex = 96;
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_itemName);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label_itemName);
            this.Controls.Add(this.panel3);
            this.Name = "StockManagement";
            this.Size = new System.Drawing.Size(985, 125);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label_stockManagement;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label label_itemName;
        private System.Windows.Forms.TextBox textBox_itemName;
    }
}
