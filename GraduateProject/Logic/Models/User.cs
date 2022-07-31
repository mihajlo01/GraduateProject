using System;
using System.Collections.Generic;
using MongoDB.Bson;

namespace GraduateProject.Models
{
    public class User
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string CompanyName { get; set; }
        public string Password { get; set; }
        public List<string> EnteredProductCodes { get; set; }
        public List<string> RemovedProductCodes { get; set; }
        public List<string> SelledProductCodes { get; set; }
        public bool EditUserPermission { get; set; }
        public bool AddProductPermission { get; set; }
        public bool RemoveProductPermission { get; set; }
        public bool ProductDashboardPermission { get; set; }
    }
}
