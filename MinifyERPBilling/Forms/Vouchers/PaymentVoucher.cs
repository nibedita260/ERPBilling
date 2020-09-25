using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinifyERPBilling.Models;
using System.IO;


namespace MinifyERPBilling.Forms.Masters
{
    public partial class PaymentVoucher : Form
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        DataTable addedData;
        

        public PaymentVoucher()
        {
            InitializeComponent();
            Auto();
         
            addedData = new DataTable();
            addedData.TableName = "Added Data";

            addedData.Columns.Add("AccountHeadName", typeof(string));
            addedData.Columns.Add("Amount", typeof(string));
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

        //Main logic for autocomplete   
        public void Auto()
        {
            AccountHeadModel accountHeadModel = new AccountHeadModel();
            accountHeadModel.Action = "Search";

            accountHeadModel.AccountHeadName = txt_fromAccnt.Text;
            accountHeadModel.AccountHeadName = txt_toAccnt.Text;
            DataSet dt = accountHeadModel.AccountHeadOperation();

           

            if (dt.Tables[0].Rows.Count > 0)

            {

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)

                {

                    coll.Add(dt.Tables[0].Rows[i]["AccountHeadName"].ToString());

                }

            }
            //else

            //{

            //    MessageBox.Show("Name not found");

            //}

            txt_fromAccnt.AutoCompleteMode = AutoCompleteMode.Suggest;

            txt_fromAccnt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_fromAccnt.AutoCompleteCustomSource = coll;

            txt_toAccnt.AutoCompleteMode = AutoCompleteMode.Suggest;

            txt_toAccnt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_toAccnt.AutoCompleteCustomSource = coll;

        }

        
        private void txt_fromAccnt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
     


        private void btn_add_Click(object sender, EventArgs e)
        {
            Utils.PaymentRefWindow paymentref = new Utils.PaymentRefWindow();
            paymentref.ShowDialog();
            addedData.Rows.Add(txt_toAccnt.Text, txt_amount.Text);
            dataGridView1.DataSource = addedData;
              
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Save() == true)
            {
                string xmlfile=ConvertDatatableToXML(addedData);
                MessageBox.Show(xmlfile);
                this.Close();
            }
        }
        private bool Save()
        {
           
            return true;
        }
    }
}
