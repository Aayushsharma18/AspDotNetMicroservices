using Catalog.API.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public IConfiguration _configuration;
        public CatalogContext(IConfiguration configuration)
        {
            _configuration = configuration;
            var client = new MongoClient(_configuration["dbConnection:ConnectionString"]);
            var dataBase = client.GetDatabase(_configuration["dbConnection:DataBaseName"]);
            Products = dataBase.GetCollection<Product>(_configuration["dbConnection:CollectionName"]);

            CatalogContextSeed.SeedData(Products);

        }
        public IMongoCollection<Product> Products { get; set; }
    }
}
