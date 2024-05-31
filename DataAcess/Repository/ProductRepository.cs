using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void InsertProduct(Product product) => ProductDAO.Instance.addNew(product);


        public void deleteProduct(int id) => ProductDAO.Instance.Remove(id);


        public Product GetProductByID(int id) => ProductDAO.Instance.GetProductByID(id);


        public IEnumerable<Product> getProductList() => ProductDAO.Instance.getProducts();


        public void updateProduct(Product product) => ProductDAO.Instance.Update(product);


    }
}
