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
    public partial class ReciptVoucher : Form
    {
        AutoCompleteStringCollection col = new AutoCompleteStringCollection();
        DataTable addData;
        public ReciptVoucher()
        {
            
            InitializeComponent();
            Auto();
            addData = new DataTable();
            addData.Columns.Add("AccountHeadName", typeof(string));
            addData.Columns.Add("Amount", typeof(string));
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

                    col.Add(dt.Tables[0].Rows[i]["AccountHeadName"].ToString());

                }

            }
            //else

            //{

            //    MessageBox.Show("Name not found");

            //}

            txt_fromAccnt.AutoCompleteMode = AutoCompleteMode.Suggest;

            txt_fromAccnt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_fromAccnt.AutoCompleteCustomSource = col;

            txt_toAccnt.AutoCompleteMode = AutoCompleteMode.Suggest;

            txt_toAccnt.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txt_toAccnt.AutoCompleteCustomSource = col;

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Utils.PaymentRefWindow reciptRef = new Utils.PaymentRefWindow();
            reciptRef.ShowDialog();
            addData.Rows.Add(txt_toAccnt.Text, txt_amount.Text);
            dataGridView1.DataSource = addData;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }
    }
}
