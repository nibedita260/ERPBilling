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


namespace MinifyERPBilling.UserControlles.Settings
{
    public partial class TradeUserControl : UserControl
    {
        public TradeUserControl()
        {
            InitializeComponent();
            LoadData();
        }

        private DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TradeId", typeof(int));
            dt.Columns.Add("TradeName", typeof(string));
            dt.Columns.Add("ShortCode", typeof(string));
            dt.Columns.Add("AddressLine1", typeof(string));
            dt.Columns.Add("StateId", typeof(string));
            dt.Columns.Add("CityName", typeof(string));
            dt.Columns.Add("Pincode", typeof(string));
            dt.Columns.Add("EmailId", typeof(string));
            dt.Columns.Add("ContactNo1", typeof(string));
            dt.Columns.Add("GstInNo", typeof(string));
            dt.Columns.Add("Logo", typeof(string));
            Trade_Model trade_Model = new Trade_Model();
            trade_Model.Action = "fetch";
            DataSet ds = trade_Model.TradeOperation();
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt.Rows.Add(
                    ds.Tables[0].Rows[i]["TradeId"].ToString(),
                    ds.Tables[0].Rows[i]["TradeName"].ToString(),
                    ds.Tables[0].Rows[i]["ShortCode"].ToString(),
                    ds.Tables[0].Rows[i]["AddressLine1"].ToString(),
                    ds.Tables[0].Rows[i]["StateId"].ToString(),
                    ds.Tables[0].Rows[i]["CityName"].ToString(),
                    ds.Tables[0].Rows[i]["Pincode"].ToString(),
                    ds.Tables[0].Rows[i]["EmailId"].ToString(),
                    ds.Tables[0].Rows[i]["ContactNo1"].ToString(),
                    ds.Tables[0].Rows[i]["GstInNo"].ToString(),
                    ds.Tables[0].Rows[i]["Logo"].ToString()
                );
                
            }
            return dt;
        }

        private void LoadData()
        {
            datagrid_trade.DataSource = GetAll();
        }

        private void datagrid_trade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                TradeEntry tradeEntry = new TradeEntry(int.Parse(senderGrid.Rows[e.RowIndex].Cells["TradeId"].Value.ToString()));
                tradeEntry.ShowDialog();
            }
        }

        private void btnAddNewTrade_Click(object sender, EventArgs e)
        {
            TradeEntry tradeEntry = new TradeEntry();
            tradeEntry.ShowDialog();
        }
    }
}
