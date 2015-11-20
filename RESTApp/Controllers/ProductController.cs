using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTApp.Models;
using RESTApp.Repository;

namespace RESTApp.Controllers
{
    public class ProductController : ApiController
    {
        private ProductRepository repo = new ProductRepository();

        public ProductController() { }

        public ProductController(ProductRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return repo.GetAll();
        }
        public Product GetProductById(int id)
        {
            return repo.GetById(id);
        }
        public HttpResponseMessage PostProduct(Product prod)
        {
            repo.Add(prod);
            repo.Save();
            return new HttpResponseMessage();
        }

        public HttpResponseMessage PutProduct(int id, Product prod)
        {
            repo.Update(id, prod);
            repo.Save();
            return new HttpResponseMessage();
        }
        public HttpResponseMessage DeleteProductById(int id)
        {
            repo.Delete(id);
            repo.Save();
            return new HttpResponseMessage();
        }
    }
}
