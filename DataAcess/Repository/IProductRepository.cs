using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> getProductList();

        Product GetProductByID(int id);
        void InsertProduct(Product product);
        void updateProduct(Product product);
        void deleteProduct(int id);
    }
}
