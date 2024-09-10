using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_App.DataAccess;
using Project_App.Model;


namespace Project_App.Services
{
    internal class ProductItem_Service
    {
        private ProductItem_DAO _productItem_DAO;
        
        public ProductItem_Service(ProductItem_DAO productItem_DAO)
        {
            _productItem_DAO = productItem_DAO;
        }

        public List<ProductItem> getAllProductItemByMaSP(int MaSP)
        {
            return _productItem_DAO.GetAllProductItem().Where(n => n.MaSP == MaSP).ToList();
        }


    }
}
