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

namespace MinifyERPBilling.UserControlles.Settings
{
    public partial class TradeEntry : Form
    {
        private int TradeId;
        public TradeEntry()
        {
            InitializeComponent();
            
        }
        public TradeEntry(int PtradeId)
        {
            InitializeComponent();
            TradeId = PtradeId;
            Trade_Model tm = new Trade_Model();
            tm.Action = "fetchbyid";
            tm.TradeId = PtradeId;
            DataSet ds = tm.TradeOperation();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txt_TradeName.Text = ds.Tables[0].Rows[0]["TradeName"].ToString();
                txt_shortcode.Text = ds.Tables[0].Rows[0]["ShortCode"].ToString();
                txt_Gstinno.Text = ds.Tables[0].Rows[0]["GstInNo"].ToString();
                txt_Address1.Text = ds.Tables[0].Rows[0]["AddressLine1"].ToString();
                txt_address2.Text = ds.Tables[0].Rows[0]["AddressLine2"].ToString();
                txt_address3.Text = ds.Tables[0].Rows[0]["AddressLine3"].ToString();
                txt_city.Text = ds.Tables[0].Rows[0]["CityName"].ToString();
                txt_pincode.Text = ds.Tables[0].Rows[0]["Pincode"].ToString();
                txt_ContactNo1.Text = ds.Tables[0].Rows[0]["ContactNo1"].ToString();
                txt_contactno2.Text = ds.Tables[0].Rows[0]["ContactNo2"].ToString();
                txt_email.Text = ds.Tables[0].Rows[0]["EmailId"].ToString();
                txt_file.Text = ds.Tables[0].Rows[0]["Logo"].ToString();
                btn_Save.Text = "Update";
                btn_SaveAddNew.Enabled=false;
                btn_SaveAddNew.Text = "Update Trade";
            }
        }
        private void txt_TradeName_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_contactno2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_Address1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ddl_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trade_Model tm = new Trade_Model();
            DataSet ds = tm.TradeOperation();
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_closewindw_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Save() == true)
            {
                this.Close();
            }
        }
        private bool Save()
        {
            if (txt_TradeName.Text!= "")
            {
                Trade_Model tm = new Trade_Model();

                if (btn_Save.Text == "Update")
                {
                    tm.Action = "updateitem";
                    tm.TradeId = TradeId;
                }
                else
                {
                    tm.Action = "insert";
                }

                tm.TradeName = txt_TradeName.Text;
                tm.ShortCode = txt_shortcode.Text;
                tm.GstInNo = txt_Gstinno.Text;
                tm.AddressLine1 = txt_Address1.Text;
                tm.AddressLine2 = txt_address2.Text;
                tm.AddressLine3 = txt_address3.Text;
                tm.CityName = txt_city.Text;
                tm.Pincode = txt_pincode.Text;
                tm.ContactNo1 = txt_ContactNo1.Text;
                tm.ContactNo2 = txt_contactno2.Text;
                tm.EmailId = txt_email.Text;
                tm.Logo = txt_file.Text;
                //tm.StateId = ddl_State.SelectedItem.ToString();
                DataSet ds = tm.TradeOperation();
                if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Record Submitted Successfully")
                {
                    MessageBox.Show("Record Submitted Successfully", "MinifyERPBilling", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Update Successfully")
                {
                    MessageBox.Show("Updated Successfully", "MinifyERPBilling", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Item Name Aready Exists")
                {
                    MessageBox.Show("Item Name Aready Exists!!!Please Try Again With Diffrent Trade Name", "MinifyERPBilling", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    MessageBox.Show("Failed to Execute Command!!! Please Try Again Later", "MinifyERPBilling", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Failed to Execute Command!!! Please Try Again Later", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


        }

        private void btn_SaveAddNew_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Clear();
            }
        }
        private void Clear()
        {

            txt_TradeName.Text = "";
            txt_shortcode.Text = "";
            txt_Gstinno.Text = "";
            txt_Address1.Text = "";
            txt_address2.Text = "";
            txt_address3.Text = "";
            txt_city.Text = "";
            txt_pincode.Text = "";
            txt_ContactNo1.Text = "";
            txt_contactno2.Text = "";
            txt_email.Text = "";
            txt_file.Text = "";
        }
    }
}
