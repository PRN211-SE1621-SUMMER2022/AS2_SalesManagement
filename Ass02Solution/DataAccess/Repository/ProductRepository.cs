using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAllProduct() => ProductDAO.Instance.GetAllProduct();

        public IEnumerable<Product> GetFilteredProduct(string tag)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId) => ProductDAO.Instance.GetProductById(productId);

        public void InsertProduct(Product product) => ProductDAO.Instance.InsertProduct(product);

        public void RemoveProduct(Product product) => ProductDAO.Instance.RemoveProduct(product);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
