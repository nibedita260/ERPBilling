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

namespace MinifyERPBilling.Forms.Masters
{
    public partial class BankDetailsEntry : Form
    {
        private int PAccountHeadId;
        public BankDetailsEntry()
        {
            InitializeComponent();
        }
        public BankDetailsEntry(int AccountHeadId)
        {
            InitializeComponent();
            PAccountHeadId = AccountHeadId;
            AccountHeadModel bankDetailsModel = new AccountHeadModel();
            bankDetailsModel.Action = "fetchbyid";
            bankDetailsModel.AccountHeadId = PAccountHeadId;
            DataSet ds = bankDetailsModel.AccountHeadOperation();
            if (ds.Tables[0].Rows.Count > 0)
            {
                txt_accountHeadName.Text = ds.Tables[0].Rows[0]["AccountHeadName"].ToString();
                txt_BankName.Text = ds.Tables[0].Rows[0]["BankName"].ToString();
                txt_bankIFSCcode.Text = ds.Tables[0].Rows[0]["BankIFSCCode"].ToString();
                txt_bankBranchName.Text = ds.Tables[0].Rows[0]["BankBranchName"].ToString();
                txt_bankAccountNo.Text = ds.Tables[0].Rows[0]["BankAccountNo"].ToString();
                txt_accountHolderName.Text = ds.Tables[0].Rows[0]["BankAccountHolderName"].ToString();
                ddl_accountGrpId.SelectedItem = ds.Tables[0].Rows[0]["AccountGroupId"].ToString();
                btn_AddSaveNew.Enabled = false;
                btn_Save.Text = "Update";

            }
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
            AccountHeadModel bankDetailsModel = new AccountHeadModel();
            if (btn_Save.Text == "Update")
            {
                bankDetailsModel.Action = "update";
                bankDetailsModel.AccountHeadId = PAccountHeadId;
            }
            else
            {
                bankDetailsModel.Action = "insert";
            }
            
            bankDetailsModel.BankName = txt_BankName.Text;
            if(ddl_accountGrpId.SelectedItem.ToString() == "Bank Account")
            {
                bankDetailsModel.AccountGroupId=1;
            }
            else if (ddl_accountGrpId.SelectedItem.ToString() == "Bank CC A/C")
            {
                bankDetailsModel.AccountGroupId =2;
            }
            else if (ddl_accountGrpId.SelectedItem.ToString() == "Bank OD A/C")
            {
                bankDetailsModel.AccountGroupId =3;
            }

            bankDetailsModel.AccountHeadName=txt_accountHeadName.Text;
            bankDetailsModel.BankName=txt_BankName.Text;
            bankDetailsModel.BankIFSCCode=txt_bankIFSCcode.Text;
            bankDetailsModel.BankBranchName=txt_bankBranchName.Text;
            bankDetailsModel.BankAccountNo=txt_bankAccountNo.Text;
            bankDetailsModel.BankAccountHolderName=txt_accountHolderName.Text;

             DataSet ds = bankDetailsModel.AccountHeadOperation();
            if(ds.Tables[0].Rows[0].ItemArray[0].ToString()== "Record Submitted Successfully")
            {
                MessageBox.Show("Record Submitted Successfully", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (ds.Tables[0].Rows[0].ItemArray[0].ToString()== "Updated Successfully")
            {
                MessageBox.Show("Updated Successfully", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Please try again Later", "MINIFY", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

        }
        private void Clear()
        {
            txt_BankName.Text = "";
            ddl_accountGrpId.Text = "";
            txt_accountHeadName.Text = "";
            txt_bankIFSCcode.Text="";
            txt_bankBranchName.Text="";
            txt_bankAccountNo.Text="";
            txt_accountHolderName.Text="";
            ddl_accountGrpId.Text="";
        }

        private void btn_AddSaveNew_Click(object sender, EventArgs e)
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
