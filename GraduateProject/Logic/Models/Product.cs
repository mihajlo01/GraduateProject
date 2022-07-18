using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Models
{
    public class Product
    {
        public ObjectId Id { get; set; }
        public string ProductType { get; set; }
        public string Provider { get; set; }
        public string ProductSize { get; set; }
        public int Quantity { get; set; }
        public string Color { get; set; }
        public long ProductCode { get; set; }
        public decimal Price { get; set; }
        public bool IsProductAvailable { get; set; }
        public DateTime TimeAdded { get; set; }
        public string AddedBy { get; set; }
    }
}
