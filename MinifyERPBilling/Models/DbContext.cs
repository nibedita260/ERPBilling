namespace MinifyERPBilling.Models
{
    using System.Configuration;

    public  class DbContext
    {
        public static string con = ConfigurationManager.ConnectionStrings["constr"].ToString();
    }
}
