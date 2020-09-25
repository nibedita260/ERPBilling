using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SQLHelper;

namespace MinifyERPBilling.Models
{
    class ItemMasterModel:DbContext
    {
        public string Action { get; set; }
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public string HSNCode { get; set; }
        public string RateOfGST { get; set; }
        public string UnitOfMeasurment { get; set; }
        public string ReorderingLabel { get; set; }
        public decimal? SalesPrice { get; set; }
        public decimal? PurchasePrice { get; set; }
        public string CurrentStock { get; set; }

        public DataSet ItemOperation()
        {
            SqlParameter[] p = new SqlParameter[10];
            p[0] = new SqlParameter("@Action", this.Action);
            p[1] = new SqlParameter("@ItemId", this.ItemId);
            p[2] = new SqlParameter("@ItemName", this.ItemName);
            p[3] = new SqlParameter("@HSNCode", this.HSNCode);
            p[4] = new SqlParameter("@RateOfGST", this.RateOfGST);
            p[5] = new SqlParameter("@UnitOfMeasurment", this.UnitOfMeasurment);
            p[6] = new SqlParameter("@ReorderingLabel", this.ReorderingLabel);
            p[7] = new SqlParameter("SalesPrice", this.SalesPrice);
            p[8] = new SqlParameter("PurchasePrice", this.PurchasePrice);
            p[9] = new SqlParameter("CurrentStock", this.CurrentStock);
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "ItemMaster_Operation",p);



        }
    }

    
}
