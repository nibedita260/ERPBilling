using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace MinifyERPBilling.Models
{
    class AccountGroupModel
    {
        [BsonId]
        public int _id { get; set; }
        public string accountgroupname { get; set; }
        public int primary { get; set; }
        public string definitiontype { get; set; }
       
    }
}
