using System.Net.Http.Headers;
using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

// wijziging voor pull request
namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        //C# list 
        private readonly List<Product> products;
        public ProductRepository()
        {
            //products lists consists products
            products = [

                new Product(1, "melk", 300),
                new Product(2, "kaas", 100),
                new Product(3, "brood", 400),
                new Product(4, "cornflakes", 0)

                ];
        }
        public List<Product> GetAll()
        {
            return products; //wijzig dit in de gemaakte lijst uit de constructor
        }

        public Product? Get(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}
