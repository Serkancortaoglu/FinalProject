using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnıtPrice=15,UnıtsInStock=15 },
                new Product{ProductId=2,CategoryId=1,ProductName="kamera",UnıtPrice=500 ,UnıtsInStock=3 },
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnıtPrice=1500,UnıtsInStock=2 },
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnıtPrice=150,UnıtsInStock=65}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            Product productDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategoryIdd(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
        }
    }
}
