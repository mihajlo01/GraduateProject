using GraduateProject.Logic.Models;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Interfaces
{
    public interface IProductsInterface
    {
        Task<bool> InsertProduct(Product productToInsert);
        Task<List<Product>> GetAllProducts();
        Task<bool> RemoveProduct(ObjectId id);
    }
}
