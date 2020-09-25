using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinifyERPBilling.Models;
using MinifyERPBilling.Forms.Masters;

namespace MinifyERPBilling.Forms.Masters
{
    public partial class ItemEntry : Form
    {
        private int PItemId;
        public ItemEntry()
        {
            InitializeComponent();
        }
       
        public ItemEntry(int ItemId)
        {
            InitializeComponent();
            PItemId = ItemId;
            ItemMasterModel table = new ItemMasterModel();
            table.Action = "fetchbyid";
            table.ItemId = PItemId;
            DataSet ds = table.ItemOperation();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txt_ItemName.Text = ds.Tables[0].Rows[0]["ItemName"].ToString();
                txt_HSNCode.Text = ds.Tables[0].Rows[0]["HSNCode"].ToString();
                txt_ReorderingLabel.Text=ds.Tables[0].Rows[0]["ReorderingLabel"].ToString();
                btn_AddSaveNew.Enabled=false;
                btn_Save.Text = "Update";

            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (Save() == true)
            {
                this.Close();
            }
        }
        private bool Save()
        {
            ItemMasterModel item = new ItemMasterModel();
            
            if (btn_Save.Text == "Update")
            {
                item.Action = "updateitem";
                item.ItemId = PItemId;
            }
            else
            {
                item.Action = "insert";
            }
            item.ItemName = txt_ItemName.Text;
            item.HSNCode = txt_HSNCode.Text;
            item.ReorderingLabel = txt_ReorderingLabel.Text;

            DataSet ds = item.ItemOperation();
            if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Record Submitted Successfully")
            {
                MessageBox.Show("Record Submitted successfully", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if(ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Update Successfully")
            {
                MessageBox.Show("Record Updated Successfully", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Failed to Execute Command!!! Please Try Again Later", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void Clear()
        {
            txt_ItemName.Text = "";
            txt_HSNCode.Text = "";
            txt_ReorderingLabel.Text = "";
           
        }
        private void ddl_rateofGST_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Clear();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
