namespace MinifyERPBilling.Models
{
    using System.Data;
    using System.Data.SqlClient;
    using SQLHelper;

    class Trade_Model : DbContext
    {
        public string Action { get; set; }
        public int? TradeId { get; set; }
        public string TradeName { get; set; }
        public string ShortCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string StateId { get; set; }
        public string CityName { get; set; }
        public string Pincode { get; set; }
        public string EmailId { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string Logo { get; set; }
        public string GstInNo { get; set; }
        public string CreatedBy { get; set; }

        public DataSet TradeOperation()
        {
            SqlParameter[] sql = new SqlParameter[16];
            sql[0] = new SqlParameter("@Action", this.Action);
            sql[1] = new SqlParameter("@TradeId", this.TradeId);
            sql[2] = new SqlParameter("@TradeName", this.TradeName);
            sql[3] = new SqlParameter("@ShortCode", this.ShortCode);
            sql[4] = new SqlParameter("@AddressLine1", this.AddressLine1);
            sql[5] = new SqlParameter("@AddressLine2", this.AddressLine2);
            sql[6] = new SqlParameter("@AddressLine3", this.AddressLine3);
            sql[7] = new SqlParameter("@StateId", this.StateId);
            sql[8] = new SqlParameter("@CityName", this.CityName);
            sql[9] = new SqlParameter("@Pincode", this.Pincode);
            sql[10] = new SqlParameter("@EmailId", this.EmailId);
            sql[11] = new SqlParameter("@ContactNo1", this.ContactNo1);
            sql[12] = new SqlParameter("@ContactNo2", this.ContactNo2);
            sql[13] = new SqlParameter("@Logo", this.Logo);
            sql[14] = new SqlParameter("@GstInNo", this.GstInNo);
            sql[15] = new SqlParameter("@CreatedBy", this.CreatedBy);


            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "trade_Operation", sql);
        }
    }
}