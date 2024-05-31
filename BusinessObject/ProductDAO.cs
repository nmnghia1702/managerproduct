using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;

        private static readonly object instanceLock = new object();

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
                    return instance;
                }
            }
        }

        public IEnumerable<Product> getProducts()
        {
            var products = new List<Product>();

            try
            {
                using var context = new Ass02Context();
                products = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public Product GetProductByID(int ? productID)
        {
            Product products = null;
            try
            {
                using var context = new Ass02Context();
                products = context.Products.SingleOrDefault(p => p.ProductId == productID);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }

        public void addNew(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product == null)
                {
                    using var context = new Ass02Context();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else throw new Exception("The product is already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Product product)
        {
            try
            {
                Product _product = GetProductByID(product.ProductId);
                if (_product != null)
                {
                    using var context = new Ass02Context();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
                else throw new Exception("The product does not already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Remove(int productID)
        {
            try
            {
                Product product = GetProductByID(productID);
                var detail = OrderDetailDAO.Instance.GetOrderDetailByProductId(productID);
                if (product != null)
                {
                    using var context = new Ass02Context();
                    context.Products.Remove(product);
                    foreach (var item in detail)
                    {
                        context.OrderDetails.Remove(item);
                    }
                    context.SaveChanges();
                }
                else throw new Exception("The product does not already exist!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
