using GraduateProject.Logic.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Interfaces
{
    public interface IProductsInterface
    {
        Task<bool> InsertProduct(Product productToInsert);
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductByProductCode(long productCode);
        Task<Product> RemoveProduct(ObjectId id);
        Task<ReplaceOneResult> UpdateProduct(Product productToUpdate, int quantity = 0);
    }
}
