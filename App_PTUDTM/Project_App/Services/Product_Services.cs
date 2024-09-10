using Project_App.DataAccess;
using Project_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Services
{
    internal class Product_Services
    {
        private readonly Product_DAO _productDao;
        public Product_Services(Product_DAO productDao)
        {
            _productDao = productDao;
        }
        public List<Product> GetAllProducts()
        {
            try
            {
                return _productDao.GetAllProducts();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving products.", ex);
            }
        }
        public Product GetProductById(int id)
        {
            var getProductByID = _productDao.GetAllProducts().Where(n=>n.MaSP == id).First();
            return getProductByID;
        }

    }
}
