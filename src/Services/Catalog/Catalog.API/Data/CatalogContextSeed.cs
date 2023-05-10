using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool isProductExist = productCollection.Find(p => true).Any();

            if (!isProductExist)
            {
                productCollection.InsertManyAsync(GetPreConfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreConfiguredProducts()
        {
            return new List<Product>() {
            new Product()
            {
                Id="1",
                Name= "IPhone X",
                Summary= "IPhone X Summmary",
                Description= "IPhone X Des",
                ImageFile= "IPhone-X.jpg",
                Price= 950.00M,
                Category= "Smart Phone"
            },
            new Product()
            {
                Id="2",
                Name= "IPhone 11",
                Summary= "IPhone 11 Summmary",
                Description= "IPhone 11 Des",
                ImageFile= "IPhone-11.jpg",
                Price= 750.00M,
                Category= "Smart Phone"
            },
            new Product()
            {
                Id="3",
                Name= "IPhone 12",
                Summary= "IPhone 12 Summmary",
                Description= "IPhone 12 Des",
                ImageFile= "IPhone-12.jpg",
                Price= 850.00M,
                Category= "Smart Phone"
            },
             new Product()
            {
                Id="4",
                Name= "IPhone 13",
                Summary= "IPhone 13 Summmary",
                Description= "IPhone 13 Des",
                ImageFile= "IPhone-13.jpg",
                Price= 1150.00M,
                Category= "Smart Phone"
            },

            };
        }
    }
}
