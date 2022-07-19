using GraduateProject.Logic.Interfaces;
using GraduateProject.Logic.Models;
using GraduateProject.Repository.Controllers;
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
    }
}
