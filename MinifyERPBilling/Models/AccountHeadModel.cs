
namespace MinifyERPBilling.Models
{
    using System.Data;
    using System.Data.SqlClient;
    using SQLHelper;
    class AccountHeadModel : DbContext
    {

        public string Action { get; set; }
        public int? AccountHeadId { get; set; }
        public string AccountHeadName { get; set; }
        public int? AccountGroupId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string EmailId { get; set; }
        public string FaxNo { get; set; }
        public string GstInNo { get; set; }
        public string BankAccountNo { get; set; }
        public string BankName { get; set; }
        public string BankIFSCCode { get; set; }
        public string BankBranchName { get; set; }
        public string BankAccountHolderName { get; set; }
        public int? CreatedBy { get; set; }
        public double? OpeningBalance { get; set; }
        public string OpeningBalanceType { get; set; }


        public DataSet AccountHeadOperation()
        {
            SqlParameter[] p = new SqlParameter[23];
            p[0] = new SqlParameter("@AccountHeadId", this.AccountHeadId);
            p[1] = new SqlParameter("@AccountHeadName", this.AccountHeadName);
            p[2] = new SqlParameter("@AccountGroupId", this.AccountGroupId);
            p[3] = new SqlParameter("@Name", this.Name);
            p[4] = new SqlParameter("@Address", this.Address);
            p[5] = new SqlParameter("@Country", this.Country);
            p[6] = new SqlParameter("@State", this.State);
            p[7] = new SqlParameter("@City", this.City);
            p[8] = new SqlParameter("@Pincode", this.Pincode);
            p[9] = new SqlParameter("@ContactNo1", this.ContactNo1);
            p[10] = new SqlParameter("@ContactNo2", this.ContactNo2);
            p[11] = new SqlParameter("@EmailId", this.EmailId);
            p[12] = new SqlParameter("@FaxNo", this.FaxNo);
            p[13] = new SqlParameter("@GstInNo", this.GstInNo);
            p[14] = new SqlParameter("@BankAccountNo", this.BankAccountNo);
            p[15] = new SqlParameter("@BankName", this.BankName);
            p[16] = new SqlParameter("@BankIFSCCode", this.BankIFSCCode);
            p[17] = new SqlParameter("@BankBranchName", this.BankBranchName);
            p[18] = new SqlParameter("@BankAccountHolderName", this.BankAccountHolderName);
            p[19] = new SqlParameter("@OpeningBalance", this.OpeningBalance);
            p[20] = new SqlParameter("@OpeningBalanceType", this.OpeningBalanceType);

            p[21] = new SqlParameter("@CreatedBy", this.CreatedBy);
            p[22] = new SqlParameter("@Action", this.Action);


            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Accounts_AccountHeadMaster_Operation", p);
        }

    }
}
