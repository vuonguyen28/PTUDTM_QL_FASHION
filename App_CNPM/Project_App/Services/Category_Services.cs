using Project_App.DataAccess;
using Project_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Services
{
    internal class Category_Services
    {
        private readonly Category_DAO _categoryDAO;
        public Category_Services(Category_DAO categoryDAO)
        {
            _categoryDAO = categoryDAO;
        }

        public List<Category> GetCategoriesBySearch(string searchText)
        {
            try
            {
                var allCategories = _categoryDAO.GetAllCategory();
                return allCategories
                    .Where(c => c.TenDanhMuc.ToLower().Contains(searchText.ToLower()))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving categories.", ex);
            }
        }


        public List<Category> getAllCategory()
        {
            try
            {
                return _categoryDAO.GetAllCategory();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving products.", ex);
            }
        }
    }
}
