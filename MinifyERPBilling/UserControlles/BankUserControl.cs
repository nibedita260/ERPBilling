using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinifyERPBilling.Models;
using MinifyERPBilling.Forms.Masters;

namespace MinifyERPBilling.UserControlles
{
    public partial class BankUserControl : UserControl
    {
        public BankUserControl()
        {
            InitializeComponent();
            LoadData();
        }
        private DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountHeadId", typeof(string));
            dt.Columns.Add("AccountGroupName", typeof(string));
            dt.Columns.Add("BankName", typeof(string));
            dt.Columns.Add("BankIFSCCode", typeof(string));
            dt.Columns.Add("BankAccountNo", typeof(string));
            dt.Columns.Add("BankBranchName", typeof(string));
            dt.Columns.Add("BankAccountHolderName", typeof(string));
            AccountHeadModel bankDetailsModel = new AccountHeadModel();
            bankDetailsModel.Action = "fetch_bankaccounts_bankcc_bankod";
            DataSet ds = bankDetailsModel.AccountHeadOperation();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt.Rows.Add(
                    ds.Tables[0].Rows[i]["AccountHeadId"].ToString(),
                    ds.Tables[0].Rows[i]["AccountGroupName"].ToString(),
                    ds.Tables[0].Rows[i]["BankName"].ToString(),
                    ds.Tables[0].Rows[i]["BankIFSCCode"].ToString(),
                    ds.Tables[0].Rows[i]["BankAccountNo"].ToString(),
                    ds.Tables[0].Rows[i]["BankBranchName"].ToString(),
                    ds.Tables[0].Rows[i]["BankAccountHolderName"].ToString()
                    );

            }
            return dt;
        }
            private void LoadData()
            {
                datagrid_bank.DataSource = GetAll(); 
            }
        

        private void datagrid_bank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                BankDetailsEntry bankDetailsEntry = new BankDetailsEntry(int.Parse(senderGrid.Rows[e.RowIndex].Cells["AccountHeadId"].Value.ToString()));
                bankDetailsEntry.ShowDialog();
            }
        }
    }
}
