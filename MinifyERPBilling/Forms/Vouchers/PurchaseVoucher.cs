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
using System.IO;
using MinifyERPBilling.Utils;

namespace MinifyERPBilling.Forms.Masters
{
    public partial class PurchaseVoucher : Form
    {
        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        AutoCompleteStringCollection col1 = new AutoCompleteStringCollection();
        DataTable addData;
        public PurchaseVoucher()
        {
            InitializeComponent();
            Auto();
            addData = new DataTable();
            addData.TableName = "Added Data";
            addData.Columns.Add("ItemName", typeof(string));
            addData.Columns.Add("HSNCode", typeof(string));
            addData.Columns.Add("Qty", typeof(string));
            addData.Columns.Add("Price", typeof(string));
            addData.Columns.Add("Discount", typeof(string));
            addData.Columns.Add("Taxable", typeof(string));
            addData.Columns.Add("GST", typeof(string));
            addData.Columns.Add("GST Amount", typeof(string));
            addData.Columns.Add("NetPayable", typeof(string));

            UtilsClass ut = new UtilsClass();
            DataTable dt = ut.States();
            ddl_state.DataSource = dt.DefaultView;
            ddl_state.DisplayMember = "StateName";
            ddl_state.ValueMember = "StateCode";

        }
        public void Auto()
        {
            AccountHeadModel accountHeadModel = new AccountHeadModel();
            accountHeadModel.Action = "Search";
            accountHeadModel.AccountHeadName = txt_accountHeadName.Text;
            DataSet dt = accountHeadModel.AccountHeadOperation();

            if (dt.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    col.Add(dt.Tables[0].Rows[i]["AccountHeadName"].ToString());
                }
            }
            //else
            //{
            //    MessageBox.Show("Name not Found.");
            //}
            txt_accountHeadName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_accountHeadName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_accountHeadName.AutoCompleteCustomSource = col;
            //fetch item name
            ItemMasterModel item = new ItemMasterModel();
            item.Action = "Search";
            item.ItemName = txt_itemName.Text;
            DataSet dt1 = item.ItemOperation();

            if (dt1.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Tables[0].Rows.Count; i++)
                {
                    col1.Add(dt1.Tables[0].Rows[i]["ItemName"].ToString());
                }
            }
            //else
            //{
            //    MessageBox.Show("Name not Found.");
            //}
            txt_itemName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_itemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_itemName.AutoCompleteCustomSource = col1;

        }
        public string ConvertDatatableToXML(DataTable dt)
        {

            MemoryStream str = new MemoryStream();
            dt.WriteXml(str, true);
            str.Seek(0, SeekOrigin.Begin);
            StreamReader sr = new StreamReader(str);
            string xmlstr;
            xmlstr = sr.ReadToEnd();
            return (xmlstr);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        
           
                int taxable, total, discount, GST, NetPaybale;
                total = (int.Parse(txt_Qty.Text)) * (int.Parse(txt_price.Text));
                discount = ((total) * (int.Parse(txt_discount.Text))) / 100;
                taxable = total - discount;
                GST = ((taxable) * (int.Parse(txt_gst.Text))) / 100;
                NetPaybale = taxable + GST;
                addData.Rows.Add(txt_itemName.Text, txt_hsnCode.Text, txt_Qty.Text, txt_price.Text, txt_discount.Text, taxable, txt_gst.Text, GST, NetPaybale);
                dataGridView1.DataSource = addData;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(Save()== true)
            {
                this.Close();
            }
        }
        private bool Save()
        {
            PurchaseVoucherModel sv = new PurchaseVoucherModel();
            sv.Action = "insert";
            sv.PartyId = txt_accountHeadName.Text;
            sv.InvoiceNo = txt_invoiceNo.Text;
            sv.PlaceOfSupply = ddl_state.SelectedValue.ToString();
            sv.PartyGstinNo = txt_gstinNo.Text;
            sv.InvoiceDate = DateTime.Parse(dateTimePicker.Text);
            sv.ReciptRefNo = txt_referenceNo.Text;
            sv.Description = richTxt_Narration.Text;
            sv.item_XML = ConvertDatatableToXML(addData);

            //MessageBox.Show(sv.item_XML);
            //return true;
            DataSet ds = sv.PurchaseOperation();
            if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "success")
            {
                MessageBox.Show("success", "MinifyERPBilling", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                return false;
            }
        }

        private void txt_itemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ItemMasterModel itemMasterModel = new ItemMasterModel();
                itemMasterModel.ItemName = txt_itemName.Text;
                itemMasterModel.Action = "fetchbyitemname";
                DataSet ds = itemMasterModel.ItemOperation();
                txt_hsnCode.Text = ds.Tables[0].Rows[0]["HSNCode"].ToString();
                txt_price.Text = ds.Tables[0].Rows[0]["SalesPrice"].ToString();
            }
        }
    }
}
