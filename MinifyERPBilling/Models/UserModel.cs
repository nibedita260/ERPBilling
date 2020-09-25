namespace MinifyERPBilling.Models
{
    using System.Data;
    using System.Data.SqlClient;
    using SQLHelper;
    class UserModel : DbContext
    {
        public string Action { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string ContactNo { get; set; }
        public string Role { get; set; }
        public int? CreatedBy { get; set; }
        public string Newpassword { get; set; }

        //Operation Function
        public DataSet UserOpration()
        {
            SqlParameter[] p = new SqlParameter[10];
            p[0] = new SqlParameter("@Action", this.Action);
            p[1] = new SqlParameter("@UserId", this.UserId);
            p[2] = new SqlParameter("@UserName", this.UserName);
            p[3] = new SqlParameter("@Password", this.Password);
            p[4] = new SqlParameter("@Name", this.Name);
            p[5] = new SqlParameter("@EmailId", this.EmailId);
            p[6] = new SqlParameter("@ContactNo", this.ContactNo);
            p[7] = new SqlParameter("@Role", this.Role);
            p[8] = new SqlParameter("@CreatedBy", this.CreatedBy);
            p[9] = new SqlParameter("@Newpassword", this.Newpassword);
            return SqlHelper.ExecuteDataset(con, CommandType.StoredProcedure, "UserMaster_Operation", p);
        }
    }
}
