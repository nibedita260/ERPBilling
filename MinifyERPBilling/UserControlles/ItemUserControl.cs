using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinifyERPBilling.Forms.Masters;
using MinifyERPBilling.Models;

namespace MinifyERPBilling.UserControlles
{
    public partial class ItemUserControl : UserControl
    {
        public ItemUserControl()
        {
            InitializeComponent();
            LoadData();
        }
        private DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ItemId", typeof(string));
            dt.Columns.Add("ItemName", typeof(string));
            dt.Columns.Add("HSNCode", typeof(string));
            dt.Columns.Add("RateOfGST", typeof(string));
            dt.Columns.Add("UnitOfMeasurment", typeof(string));
            dt.Columns.Add("ReorderingLabel", typeof(string));
            dt.Columns.Add("PurchasePrice", typeof(string));
            dt.Columns.Add("SalesPrice", typeof(string));
            dt.Columns.Add("CurrentStock", typeof(string));
            ItemMasterModel itemMaster = new ItemMasterModel();
            itemMaster.Action = "fetch";
            DataSet ds = itemMaster.ItemOperation();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dt.Rows.Add(
                    ds.Tables[0].Rows[i]["ItemId"].ToString(),
                    ds.Tables[0].Rows[i]["ItemName"].ToString(),
                    ds.Tables[0].Rows[i]["HSNCode"].ToString(),
                    ds.Tables[0].Rows[i]["RateOfGST"].ToString(),
                    ds.Tables[0].Rows[i]["UnitOfMeasurment"].ToString(),
                    ds.Tables[0].Rows[i]["ReorderingLabel"].ToString(),
                    ds.Tables[0].Rows[i]["PurchasePrice"].ToString(),
                    ds.Tables[0].Rows[i]["SalesPrice"].ToString(),
                    ds.Tables[0].Rows[i]["CurrentStock"].ToString()
                    );
            }
            return dt;
        }
        private void LoadData()
        {
            datagrid_Item.DataSource = GetAll();
        }

        private void datagrid_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                ItemEntry item = new ItemEntry(int.Parse(senderGrid.Rows[e.RowIndex].Cells["ItemId"].Value.ToString()));
                item.ShowDialog();
            }
           
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            ItemEntry itemEntry = new ItemEntry();
            itemEntry.ShowDialog();

        }
    }
}
