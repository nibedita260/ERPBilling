using System.Data;
using System.Windows.Forms;
using MinifyERPBilling.Models;


namespace MinifyERPBilling.UserControlles.Reports
{
    public partial class AccountLedgerReport : UserControl
    {
        AutoCompleteStringCollection coll = new AutoCompleteStringCollection();

        DataTable addedData;
        public AccountLedgerReport()
        {
            InitializeComponent();
            Auto();

            addedData = new DataTable();
            addedData.TableName = "Added Data";

            addedData.Columns.Add("AccountHeadName", typeof(string));
        }
        //Main logic for autocomplete   
        public void Auto()
        {
            AccountHeadModel accountHeadModel = new AccountHeadModel();
            accountHeadModel.Action = "Search";
            accountHeadModel.AccountHeadName = textBox_accountHeadName.Text;
            DataSet dt = accountHeadModel.AccountHeadOperation();



            if (dt.Tables[0].Rows.Count > 0)

            {

                for (int i = 0; i < dt.Tables[0].Rows.Count; i++)

                {

                    coll.Add(dt.Tables[0].Rows[i]["AccountHeadName"].ToString());

                }

            }
            textBox_accountHeadName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox_accountHeadName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox_accountHeadName.AutoCompleteCustomSource = coll;
            

        }
    }
}
