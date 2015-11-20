using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTApp.Models;

namespace RESTApp.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private DBContext context;

        public ProductRepository()
        {
            context = new DBContext();
        }

        public virtual IEnumerable<Product> GetAll()
        {
            return context.Products;
        }
        public virtual Product GetById(int id)
        {
            return context.Products.Find(id);
        }
        public virtual Product Add(Product prod)
        {
            context.Products.Add(prod);
            return prod;
        }
        public virtual void Update(int id, Product prod)
        {
            Product p1 = context.Products.Where(p => p.ProductId == id).FirstOrDefault();
            p1.ProductName = prod.ProductName;
            p1.ProductDetails = prod.ProductDetails;
        }
        public void Delete(int id)
        {
            Product prod = context.Products.Find(id);
            context.Products.Remove(prod);
        }

        public virtual void Save()
        {
            context.SaveChanges();
        }
        
    }
}