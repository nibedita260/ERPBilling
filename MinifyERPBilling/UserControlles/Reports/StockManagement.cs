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


namespace MinifyERPBilling.UserControlles.Reports
{
    public partial class StockManagement : UserControl
    {
        AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
        DataTable addData;
        public StockManagement()
        {
            InitializeComponent();
            Auto();
            addData = new DataTable();

            addData.Columns.Add("ItemName", typeof(string));
        }
        public void Auto()
        {
            ItemMasterModel item = new ItemMasterModel();
            item.Action = "Search";
            item.ItemName = textBox_itemName.Text;
            DataSet dt1 = item.ItemOperation();

            if (dt1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Tables[0].Rows.Count; i++)
                {
                    col1.Add(dt1.Tables[0].Rows[i]["ItemName"].ToString());
                }
            }

            textBox_itemName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_itemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_itemName.AutoCompleteCustomSource = col1;
        }
    }
   
}
