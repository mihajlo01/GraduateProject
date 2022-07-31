using GraduateProject.Logic.Interfaces;
using GraduateProject.Logic.Models;
using GraduateProject.Repository.Controllers;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateProject.Logic.Controllers
{
    public class ProductsController : IProductsInterface
    {
        IMongoDbInterface mongoInterface;
        IMongoCollection<Product> product;
        IMongoDatabase database;

        public void Initialize()
        {
            mongoInterface = new MongoDbController();
            database = mongoInterface.Database();
            product = database.GetCollection<Product>("Product");
        }

        public async Task<bool> InsertProduct(Product productToInsert)
        {
            Initialize();
            await product.InsertOneAsync(productToInsert);

            return true;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            Initialize();
            List<Product> products = await product.Find(x => true).ToListAsync();
            return products;
        }

        public async Task<Product> GetProductByProductCode(string productCode)
        {
            Initialize();
            var fetchedProduct = await product.Find(x => x.ProductCode == productCode).FirstOrDefaultAsync();

            if (fetchedProduct != null)
                return fetchedProduct;

            return null;
        }

        public async Task<Product> RemoveProduct(ObjectId id)
        {
            Initialize();
            var filter = Builders<Product>.Filter.Eq(s => s.Id, id);
            var removedProduct = await product.FindOneAndDeleteAsync(filter);
            if (removedProduct != null)
                return removedProduct;
            else
                return null;
        }

        public async Task<ReplaceOneResult> UpdateProduct(Product productToUpdate, int quantity = 0)
        {
            Initialize();
            var filter = Builders<Product>.Filter.Eq(x => x.Id, productToUpdate.Id);
            if (quantity != 0)
                productToUpdate.Quantity = quantity;

            return await product.ReplaceOneAsync(filter, productToUpdate);
        }
    }
}
