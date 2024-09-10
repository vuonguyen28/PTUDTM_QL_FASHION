using Project_App.DataAccess;
using Project_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Services
{
    internal class Size_Services
    {
        private readonly Size_DAO _sizeDAO;
        public Size_Services(Size_DAO sizeDAO)
        {
            _sizeDAO = sizeDAO;
        }

        public List<Size> GetSizeBySearch(string searchText)
        {
            try
            {
                var allCategories = _sizeDAO.GetAllSize();
                return allCategories
                    .Where(c => c.TenDanhMuc.ToLower().Contains(searchText.ToLower()))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving categories.", ex);
            }
        }


        public List<Size> getAllSize()
        {
            try
            {
                return _sizeDAO.GetAllSize();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving products.", ex);
            }
        }
    }
}
