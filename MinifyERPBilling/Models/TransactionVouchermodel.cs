using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLHelper;
using System.Data;
using System.Data.SqlClient;

namespace MinifyERPBilling.Models
{
    class TransactionVouchermodel:DbContext
    {
        public string Action { get; set; }
        public int? TranscationDocId { get; set; }
        public DateTime? TranscationDate { get; set; }
        public string CrDr { get; set; }
        public string VoucherNo { get; set; }
        public string Narration { get; set; }
        public int? CreatedBy { get; set; }
        public string AccountHeadId { get; set; }
        public string xmlStr { get; set; }

        public DataSet TransactionOperation()
        {
            SqlParameter[] sql = new SqlParameter[8];
            sql[0] = new SqlParameter("@Action", this.Action);
            sql[1] = new SqlParameter("@TranscationDocId", this.TranscationDocId);
            sql[2] = new SqlParameter("@TranscationDate", this.TranscationDate);
            sql[3] = new SqlParameter("@CrDr", this.CrDr);
            sql[4] = new SqlParameter("@Narration", this.Narration);
            sql[5] = new SqlParameter("@CreatedBy", this.CreatedBy);
            sql[6] = new SqlParameter("@AccountHeadId", this.AccountHeadId);
            sql[7] = new SqlParameter("@xmlStr", this.xmlStr);

            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "Accounts_TranscationDocMaster_Operations", sql);
        }
    }

}
