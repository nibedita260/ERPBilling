using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using MinifyERPBilling.Models;
namespace MinifyERPBilling.Forms.Masters
{
    public partial class PartyEntry : Form
    {
        private int Partyid;
        public PartyEntry()
        {
            InitializeComponent();
        }

        public PartyEntry(int AccountHeadId)
        {
            InitializeComponent();
            Partyid = AccountHeadId;
            AccountHeadModel table = new AccountHeadModel();
            table.Action = "fetchbyid";
            table.AccountHeadId = Partyid;
            DataSet ds = table.AccountHeadOperation();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txt_PartyName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                txt_Address.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                txt_PhoneNo.Text = ds.Tables[0].Rows[0]["ContactNo1"].ToString();
               
                txt_EmailId.Text = ds.Tables[0].Rows[0]["Emailid"].ToString();
                txt_Gstinno.Text = ds.Tables[0].Rows[0]["GstInNo"].ToString();
                if (ds.Tables[0].Rows[0]["AccountGroupId"].ToString()=="21")
                {
                    rb_PurchaseParty.Checked = true;
                }
                else
                {
                    rb_SaleParty.Checked = true;
                }
                btn_Save.Text = "Update";
                btn_SaveAddNew.Enabled = false;
                lbl_AddParty.Text = "Update Party";
                LoadDetails();
            }
           
        }

        private void LoadDetails()
        {
            
        }
        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PartyEntry_Load(object sender, EventArgs e)
        {

        }

        private void Btn_closewindw_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
          
                if (Save()== true)
                {
                    this.Close();
                }
          
        }

        private void btn_SaveAddNew_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                Clear();
            }
        }
        private bool Save()
        {
             
            if (txt_PartyName.Text != "")
            {
                double amount = 0;
                try
                {
                    amount = double.Parse(txt_CurrentBalance.Text);
                }
                catch
                {

                }
                if (rb_PurchaseParty.Checked == true)
                {
                    AccountHeadModel account = new AccountHeadModel();
                   

                    if (btn_Save.Text == "Update")
                    {
                        account.Action = "update";
                        account.AccountHeadId = Partyid;
                    }
                    else
                    {
                        account.Action = "insert";
                    }

                    account.AccountHeadName = txt_PartyName.Text;
                    account.AccountGroupId = 21;
                    account.Name = txt_PartyName.Text;
                    account.GstInNo = txt_Gstinno.Text;
                    account.State = ddl_State.SelectedItem.ToString();
                    account.ContactNo1 = txt_PhoneNo.Text;
                    account.EmailId = txt_EmailId.Text;
                    account.Address = txt_Address.Text;
                    account.OpeningBalance = amount;
                    account.OpeningBalanceType = ddl_OpeningBalanceType.SelectedItem.ToString();
                    DataSet ds = account.AccountHeadOperation();
                    if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Record Submitted Successfully")
                    {
                        MessageBox.Show("Record Submitted successfully", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Updated Successfully")
                    {
                        MessageBox.Show("Record Updated Successfully", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }


                    else if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Duplicate Record")
                    {
                        MessageBox.Show("Record Already Exists!!!Please Try Again With Diffrent Account HeadName", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to Execute Command!!! Please Try Again Later", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }
                else if (rb_SaleParty.Checked == true)
                {

                    AccountHeadModel account = new AccountHeadModel();
                    

                    if (btn_Save.Text == "Update")
                    {
                        account.Action = "update";
                        account.AccountHeadId = Partyid;
                    }
                    else
                    {
                        account.Action = "insert";
                    }
                    account.AccountHeadName = txt_PartyName.Text;
                    account.AccountGroupId = 22;
                    account.Name = txt_PartyName.Text;
                    account.GstInNo = txt_Gstinno.Text;
                    account.State = ddl_State.SelectedItem.ToString();
                    account.ContactNo1 = txt_PhoneNo.Text;
                    account.EmailId = txt_EmailId.Text;
                    account.Address = txt_Address.Text;
                    account.OpeningBalance = amount;
                    account.OpeningBalanceType = ddl_OpeningBalanceType.SelectedItem.ToString();
                    DataSet ds = account.AccountHeadOperation();
                    if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Record Submitted Successfully")
                    {
                        MessageBox.Show("Record Submitted successfully", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Updated Successfully")
                    {
                        MessageBox.Show("Record Updated Successfully", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }


                    else if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Duplicate Record")
                    {
                        MessageBox.Show("Record Already Exists!!!Please Try Again With Diffrent Account HeadName", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        MessageBox.Show("Failed to Execute Command!!! Please Try Again Later", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    

                }

                else
                {
                    MessageBox.Show("Please Select Party Type Purchase Party Or Sales Party", "MinifyERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please Enter  Party Name", "Minify ERP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
        }

        private void Clear()
        {
            txt_PartyName.Text = "";
            rb_PurchaseParty.Checked = false;
            rb_SaleParty.Checked = false;
            txt_PhoneNo.Text = "";
            txt_Address.Text = "";
        }
    }
}
