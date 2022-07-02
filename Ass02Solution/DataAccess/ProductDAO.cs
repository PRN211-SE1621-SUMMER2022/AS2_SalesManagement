using BusinessObject.Models;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO : BaseDAO<Product>, IProductRepository
    {
        private static readonly object instanceLock = new object();
        public static ProductDAO instance = null;
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                }
                return instance;
            }
        }
        public IEnumerable<Product> GetAllProduct() => base.GetAllEntity();

        public IEnumerable<Product> GetFilteredProduct(string tag)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int productId) => base.GetEntityById(productId);

        public void InsertProduct(Product product) => base.SaveEntity(product);

        public void RemoveProduct(Product product) => base.DeleteEntity(product);

        public void UpdateProduct(Product product) => base.UpdateEntity(product);
    }
}
