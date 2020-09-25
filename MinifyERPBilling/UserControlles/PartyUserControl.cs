
namespace MinifyERPBilling.UserControlles
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using MinifyERPBilling.Forms.Masters;
    using MinifyERPBilling.Models;
    public partial class PartyUserControl : UserControl
    {
        public PartyUserControl()
        {
            InitializeComponent();
            LoadData();
        }

        private DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("AccountHeadId", typeof(string));
            dt.Columns.Add("accountheadname", typeof(string));
            dt.Columns.Add("AccountGroup", typeof(string));
            dt.Columns.Add("partyname", typeof(string));
            dt.Columns.Add("gstinno", typeof(string));
            dt.Columns.Add("state", typeof(string));
            dt.Columns.Add("phoneno", typeof(string));
            dt.Columns.Add("emilid", typeof(string));
            dt.Columns.Add("address", typeof(string));
            dt.Columns.Add("openingbalance", typeof(string));
            dt.Columns.Add("openingbalancetype", typeof(string));
            AccountHeadModel account = new AccountHeadModel();
            account.Action = "fetch";
            DataSet ds = account.AccountHeadOperation();
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt.Rows.Add(
                    ds.Tables[0].Rows[i]["AccountHeadId"].ToString(),
                    ds.Tables[0].Rows[i]["AccountHeadName"].ToString(),
                    ds.Tables[0].Rows[i]["AccountGroupName"].ToString(),
                    ds.Tables[0].Rows[i]["Name"].ToString(),
                    ds.Tables[0].Rows[i]["GstinNo"].ToString(),
                    ds.Tables[0].Rows[i]["State"].ToString(),
                    ds.Tables[0].Rows[i]["ContactNo1"].ToString(),
                    ds.Tables[0].Rows[i]["EmailId"].ToString(),
                    ds.Tables[0].Rows[i]["Address"].ToString(),
                    ds.Tables[0].Rows[i]["OpeningBalance"].ToString(),
                    ds.Tables[0].Rows[i]["OpeningBalanceType"].ToString()
                    );
            }
            return dt;
        }


        private void LoadData()
        {
            datagrid_Party.DataSource = GetAll();
        }
        private void BtnAddNewParty_Click(object sender, EventArgs e)
        {
            PartyEntry party = new PartyEntry();
            party.ShowDialog();
        }

        private void Datagrid_Party_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
            {

                PartyEntry party = new PartyEntry(int.Parse(senderGrid.Rows[e.RowIndex].Cells["AccountHeadId"].Value.ToString()));
                party.ShowDialog();
                //TODO - Button Clicked - Execute Code Here
            }
        }
    }
}
