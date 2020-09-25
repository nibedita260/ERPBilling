namespace MinifyERPBilling.Forms.Masters
{
    partial class ItemEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ItemName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_HSNCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddl_rateofGST = new System.Windows.Forms.ComboBox();
            this.ddl_UnitOfMeasurment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ReorderingLabel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_SalesPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_PurchasePrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_CurrentStock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Save = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_AddSaveNew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.label1.Location = new System.Drawing.Point(364, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Add Item";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 430);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(790, 10);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(790, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 440);
            this.panel4.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 33;
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
            this.btn_close.TabIndex = 34;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Item Name :";
            // 
            // txt_ItemName
            // 
            this.txt_ItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ItemName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ItemName.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ItemName.HintText = "Please Enter Item Name";
            this.txt_ItemName.isPassword = false;
            this.txt_ItemName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_ItemName.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ItemName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_ItemName.LineThickness = 3;
            this.txt_ItemName.Location = new System.Drawing.Point(132, 73);
            this.txt_ItemName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ItemName.Name = "txt_ItemName";
            this.txt_ItemName.Size = new System.Drawing.Size(621, 44);
            this.txt_ItemName.TabIndex = 37;
            this.txt_ItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "HSN Code :";
            // 
            // txt_HSNCode
            // 
            this.txt_HSNCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HSNCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_HSNCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_HSNCode.HintForeColor = System.Drawing.Color.Empty;
            this.txt_HSNCode.HintText = "PleaseEnter HSN Code ";
            this.txt_HSNCode.isPassword = false;
            this.txt_HSNCode.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_HSNCode.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_HSNCode.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_HSNCode.LineThickness = 3;
            this.txt_HSNCode.Location = new System.Drawing.Point(132, 125);
            this.txt_HSNCode.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HSNCode.Name = "txt_HSNCode";
            this.txt_HSNCode.Size = new System.Drawing.Size(259, 44);
            this.txt_HSNCode.TabIndex = 39;
            this.txt_HSNCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(416, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Rate Of GST :";
            // 
            // ddl_rateofGST
            // 
            this.ddl_rateofGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_rateofGST.FormattingEnabled = true;
            this.ddl_rateofGST.Items.AddRange(new object[] {
            "Nill Rated",
            "Zero Rated",
            "5%",
            "12%",
            "18%",
            "28%"});
            this.ddl_rateofGST.Location = new System.Drawing.Point(532, 142);
            this.ddl_rateofGST.Name = "ddl_rateofGST";
            this.ddl_rateofGST.Size = new System.Drawing.Size(221, 21);
            this.ddl_rateofGST.TabIndex = 41;
            this.ddl_rateofGST.SelectedIndexChanged += new System.EventHandler(this.ddl_rateofGST_SelectedIndexChanged);
            // 
            // ddl_UnitOfMeasurment
            // 
            this.ddl_UnitOfMeasurment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddl_UnitOfMeasurment.FormattingEnabled = true;
            this.ddl_UnitOfMeasurment.Items.AddRange(new object[] {
            "--Select--",
            "Bag-Bags",
            "Bal-Bale",
            "Bdl-Bundles",
            "Bkl-buckles",
            "Bou-Billion of units",
            "Box-Box",
            "Btl-Bottles",
            "Bun-Bunches",
            "CAN-Cans",
            "Cbm-Cubic meters",
            "CCM-CUBIC CENTIMETERS",
            "CMS-CENTIMETERS",
            "CTN-CARTONS",
            "DOZ-DOZENS",
            "DRM-DRUMS",
            "GGK-GREAT GROSS",
            "GMS-GRAMMES",
            "GRS-GROSS",
            "GYS-GROSS YARDS",
            "KGS-KILOGRAMS",
            "KLR-KILOLITRE",
            "KME-KILOMITRE",
            "MLT-MILILITRE",
            "MTR-METERS",
            "MTS-METRIC TON",
            "NOS-NUMBERS",
            "SET-SETS",
            "SQF-SQUARE FEET",
            "SQM-SQUARE METERS",
            "SQY-SQUARE YARDS",
            "TBS-TABLETS",
            "TEN-GROSS",
            "THD-THOUSANDS",
            "TON-TONNES",
            "TUB-TUBES",
            "UGS-US GALLONS",
            "UNT-UNITS",
            "YDS-YARDS",
            "OTH-OTHERS",
            "CUM-CUBIC METER"});
            this.ddl_UnitOfMeasurment.Location = new System.Drawing.Point(195, 188);
            this.ddl_UnitOfMeasurment.Name = "ddl_UnitOfMeasurment";
            this.ddl_UnitOfMeasurment.Size = new System.Drawing.Size(121, 21);
            this.ddl_UnitOfMeasurment.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Unit of Measurment :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Reordering Label :";
            // 
            // txt_ReorderingLabel
            // 
            this.txt_ReorderingLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ReorderingLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ReorderingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ReorderingLabel.HintForeColor = System.Drawing.Color.Empty;
            this.txt_ReorderingLabel.HintText = "Please Enter Reordering Label";
            this.txt_ReorderingLabel.isPassword = false;
            this.txt_ReorderingLabel.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_ReorderingLabel.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_ReorderingLabel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_ReorderingLabel.LineThickness = 3;
            this.txt_ReorderingLabel.Location = new System.Drawing.Point(493, 170);
            this.txt_ReorderingLabel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ReorderingLabel.Name = "txt_ReorderingLabel";
            this.txt_ReorderingLabel.Size = new System.Drawing.Size(260, 44);
            this.txt_ReorderingLabel.TabIndex = 48;
            this.txt_ReorderingLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_SalesPrice
            // 
            this.txt_SalesPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SalesPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_SalesPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_SalesPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txt_SalesPrice.HintText = "Sales Price";
            this.txt_SalesPrice.isPassword = false;
            this.txt_SalesPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_SalesPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_SalesPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_SalesPrice.LineThickness = 3;
            this.txt_SalesPrice.Location = new System.Drawing.Point(375, 222);
            this.txt_SalesPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SalesPrice.Name = "txt_SalesPrice";
            this.txt_SalesPrice.Size = new System.Drawing.Size(105, 44);
            this.txt_SalesPrice.TabIndex = 52;
            this.txt_SalesPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_SalesPrice.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "Sales Price :";
            // 
            // txt_PurchasePrice
            // 
            this.txt_PurchasePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_PurchasePrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_PurchasePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PurchasePrice.HintForeColor = System.Drawing.Color.Empty;
            this.txt_PurchasePrice.HintText = "Purchase Price";
            this.txt_PurchasePrice.isPassword = false;
            this.txt_PurchasePrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_PurchasePrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_PurchasePrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_PurchasePrice.LineThickness = 3;
            this.txt_PurchasePrice.Location = new System.Drawing.Point(160, 222);
            this.txt_PurchasePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PurchasePrice.Name = "txt_PurchasePrice";
            this.txt_PurchasePrice.Size = new System.Drawing.Size(105, 44);
            this.txt_PurchasePrice.TabIndex = 50;
            this.txt_PurchasePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 20);
            this.label8.TabIndex = 49;
            this.label8.Text = "Purchase Price :";
            // 
            // txt_CurrentStock
            // 
            this.txt_CurrentStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CurrentStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CurrentStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_CurrentStock.HintForeColor = System.Drawing.Color.Empty;
            this.txt_CurrentStock.HintText = "Current Stock";
            this.txt_CurrentStock.isPassword = false;
            this.txt_CurrentStock.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_CurrentStock.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_CurrentStock.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_CurrentStock.LineThickness = 3;
            this.txt_CurrentStock.Location = new System.Drawing.Point(648, 222);
            this.txt_CurrentStock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CurrentStock.Name = "txt_CurrentStock";
            this.txt_CurrentStock.Size = new System.Drawing.Size(105, 44);
            this.txt_CurrentStock.TabIndex = 54;
            this.txt_CurrentStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(512, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Current Stock :";
            // 
            // btn_Save
            // 
            this.btn_Save.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Save.BorderRadius = 0;
            this.btn_Save.ButtonText = "Save";
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Save.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Save.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Save.Iconimage")));
            this.btn_Save.Iconimage_right = null;
            this.btn_Save.Iconimage_right_Selected = null;
            this.btn_Save.Iconimage_Selected = null;
            this.btn_Save.IconMarginLeft = 0;
            this.btn_Save.IconMarginRight = 0;
            this.btn_Save.IconRightVisible = true;
            this.btn_Save.IconRightZoom = 0D;
            this.btn_Save.IconVisible = true;
            this.btn_Save.IconZoom = 90D;
            this.btn_Save.IsTab = false;
            this.btn_Save.Location = new System.Drawing.Point(311, 350);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Save.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_Save.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Save.selected = false;
            this.btn_Save.Size = new System.Drawing.Size(115, 48);
            this.btn_Save.TabIndex = 55;
            this.btn_Save.Text = "Save";
            this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Textcolor = System.Drawing.Color.White;
            this.btn_Save.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btn_AddSaveNew
            // 
            this.btn_AddSaveNew.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AddSaveNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AddSaveNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_AddSaveNew.BorderRadius = 0;
            this.btn_AddSaveNew.ButtonText = "Save & Add New";
            this.btn_AddSaveNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddSaveNew.DisabledColor = System.Drawing.Color.Gray;
            this.btn_AddSaveNew.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_AddSaveNew.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_AddSaveNew.Iconimage")));
            this.btn_AddSaveNew.Iconimage_right = null;
            this.btn_AddSaveNew.Iconimage_right_Selected = null;
            this.btn_AddSaveNew.Iconimage_Selected = null;
            this.btn_AddSaveNew.IconMarginLeft = 0;
            this.btn_AddSaveNew.IconMarginRight = 0;
            this.btn_AddSaveNew.IconRightVisible = true;
            this.btn_AddSaveNew.IconRightZoom = 0D;
            this.btn_AddSaveNew.IconVisible = true;
            this.btn_AddSaveNew.IconZoom = 90D;
            this.btn_AddSaveNew.IsTab = false;
            this.btn_AddSaveNew.Location = new System.Drawing.Point(432, 350);
            this.btn_AddSaveNew.Name = "btn_AddSaveNew";
            this.btn_AddSaveNew.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_AddSaveNew.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btn_AddSaveNew.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_AddSaveNew.selected = false;
            this.btn_AddSaveNew.Size = new System.Drawing.Size(163, 48);
            this.btn_AddSaveNew.TabIndex = 56;
            this.btn_AddSaveNew.Text = "Save & Add New";
            this.btn_AddSaveNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddSaveNew.Textcolor = System.Drawing.Color.White;
            this.btn_AddSaveNew.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSaveNew.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Close";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(601, 350);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(55)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(17)))), ((int)(((byte)(45)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(115, 48);
            this.bunifuFlatButton3.TabIndex = 57;
            this.bunifuFlatButton3.Text = "Close";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // ItemEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.btn_AddSaveNew);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_CurrentStock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_SalesPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_PurchasePrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_ReorderingLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddl_UnitOfMeasurment);
            this.Controls.Add(this.ddl_rateofGST);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_HSNCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ItemName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ItemName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_HSNCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddl_rateofGST;
        private System.Windows.Forms.ComboBox ddl_UnitOfMeasurment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_ReorderingLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_SalesPrice;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_PurchasePrice;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_CurrentStock;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Save;
        private Bunifu.Framework.UI.BunifuFlatButton btn_AddSaveNew;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
    }
}