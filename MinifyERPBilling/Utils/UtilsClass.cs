using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace MinifyERPBilling.Utils
{
    class UtilsClass
    {
        public DataTable States()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("StateCode", typeof(string));
            dt.Columns.Add("StateName", typeof(string));
            dt.Rows.Add("1", "Jammu & Kashmir");
            dt.Rows.Add("2", "Himachal Pradesh");
            dt.Rows.Add("3", "Punjab");
            dt.Rows.Add("4", "Chandigarh");
            dt.Rows.Add("5", "Uttarakhand");
            dt.Rows.Add("6", "Haryana");
            dt.Rows.Add("7", "Delhi");
            dt.Rows.Add("8", "Rajasthan");
            dt.Rows.Add("9", "Uttar Pradesh");
            dt.Rows.Add("10", "Bihar");
            dt.Rows.Add("11", "Sikkim");
            dt.Rows.Add("12", "Arunachal Pradesh");
            dt.Rows.Add("13", "Nagaland");
            dt.Rows.Add("14", "Manipur");
            dt.Rows.Add("15", "Mizoram");
            dt.Rows.Add("16", "Haryana");
            dt.Rows.Add("17", "Tripura");
            dt.Rows.Add("18", "Rajasthan");
            dt.Rows.Add("19", "West Bengal");
            dt.Rows.Add("20", "Jharkhand");
            dt.Rows.Add("21", "Orissa");
            dt.Rows.Add("22", "Chhattisgarh");
            dt.Rows.Add("23", "Madhya Pradesh");
            dt.Rows.Add("24", "Gujarat");
            dt.Rows.Add("25", "Daman & Diu");
            dt.Rows.Add("26", "Dadra & Nagar Haveli");
            dt.Rows.Add("27", "Maharashtra");
            dt.Rows.Add("28", "Andhra Pradesh");
            dt.Rows.Add("29", "Karnataka");
            dt.Rows.Add("30", "Goa");
            dt.Rows.Add("31", "Lakshadweep");
            dt.Rows.Add("32", "Kerala");
            dt.Rows.Add("33", "Tamil Nadu");
            dt.Rows.Add("34", "Puducherry");
            dt.Rows.Add("35", "Andaman & Nicobar Islands");
            dt.Rows.Add("36", "Telangana");
            dt.Rows.Add("37", "Andhra Pradesh(New)");

            return dt;
        }
    }
}
