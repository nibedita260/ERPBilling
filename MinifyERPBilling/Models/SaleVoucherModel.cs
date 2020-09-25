
namespace MinifyERPBilling.Models
{
    using System;

    using System.Data;
    using System.Data.SqlClient;
    using SQLHelper;

    class SaleVoucherModel:DbContext
    {
        public string Action { get; set; }
        public int? SalesDocId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string PartyId { get; set; }
        public string PartyGstinNo { get; set; }
        public int SalesAccountId { get; set; }
        public string PlaceOfSupply { get; set; }
        public string Description { get; set; }
        public string TranscationDocId { get; set; }
        public int? CreatedBy { get; set; }
        public string ReciptRefNo { get; set; }
        public string item_XML { get; set; }



        public DataSet SaleOperation()
        {
            SqlParameter[] sql = new SqlParameter[13];
            sql[0] = new SqlParameter("@Action", this.Action);
            sql[1] = new SqlParameter("@SalesDocId", this.SalesDocId);
            sql[2] = new SqlParameter("@InvoiceNo", this.InvoiceNo);
            sql[3] = new SqlParameter("@InvoiceDate", this.InvoiceDate);
            sql[4] = new SqlParameter("@PartyId", this.PartyId);
            sql[5] = new SqlParameter("@PartyGstinNo", this.PartyGstinNo);
            sql[6] = new SqlParameter("@SalesAccountId", this.SalesAccountId);
            sql[7] = new SqlParameter("@PlaceOfSupply", this.PlaceOfSupply);
            sql[8] = new SqlParameter("@Description", this.Description);
            sql[9] = new SqlParameter("@TranscationDocId", this.TranscationDocId);
            sql[10] = new SqlParameter("@CreatedBy", this.CreatedBy);
            sql[11] = new SqlParameter("@ReciptRefNo", this.ReciptRefNo);
            sql[12] = new SqlParameter("@item_XML", this.item_XML);
           

            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "SaleVoucher_Operations", sql);
        }

    }
}
