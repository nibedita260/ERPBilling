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

namespace MinifyERPBilling.Forms.Masters
{
    public partial class ContraVoucher : Form
    {
        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        DataTable addData;
        public ContraVoucher()
        {
            InitializeComponent();
            Auto();
            addData = new DataTable();
            addData.TableName = "Added Data";
            addData.Columns.Add("AccountHeadName", typeof(string));
            addData.Columns.Add("Amount", typeof(string));

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
        public void Auto()
        {
            AccountHeadModel accountHeadModel = new AccountHeadModel();
            accountHeadModel.Action = "Search";
            accountHeadModel.AccountHeadName = txt_fromAccnt.Text;
            accountHeadModel.AccountHeadName = txt_toAccnt.Text;

            DataSet dt = accountHeadModel.AccountHeadOperation();

            if (dt.Tables[0].Rows.Count > 0)
            {
                for(int i = 0; i < dt.Tables[0].Rows.Count; i++)
                {
                    col.Add(dt.Tables[0].Rows[i]["AccountHeadName"].ToString());
                }
            }

           
            txt_fromAccnt.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_fromAccnt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_fromAccnt.AutoCompleteCustomSource = col;

            txt_toAccnt.AutoCompleteMode = AutoCompleteMode.Suggest;

            txt_toAccnt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_toAccnt.AutoCompleteCustomSource = col;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addData.Rows.Add(txt_toAccnt.Text, txt_amount.Text);
            dataGridView1.DataSource = addData;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void btn_save_Click(object sender, EventArgs e)
        {
        if (Save() == true)
        {
            this.Close();
        }
        }

       

        private bool Save()
        {
            TransactionVouchermodel contra = new TransactionVouchermodel();
            if (ddl_type.SelectedItem.ToString() == "Cr")
            {
                contra.CrDr = "Cr";
            }
            else if (ddl_type.SelectedItem.ToString() == "Dr")
            {
                contra.CrDr = "Dr";
            }
           
                contra.Action = "ContraVoucherInsert";
                contra.TranscationDate = DateTime.Parse(dateTimePicker.Text);
                contra.AccountHeadId = txt_fromAccnt.Text;
                contra.xmlStr = ConvertDatatableToXML(addData);
                MessageBox.Show(contra.xmlStr);

            DataSet ds = contra.TransactionOperation();
            if (ds.Tables[0].Rows[0].ItemArray[0].ToString() == "Record Submitted Successfully")
            {
                MessageBox.Show("Record Submitted Successfully", "MinifyERPBilling", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[0].ToString());
                return false;
            }


        }
    }
}
