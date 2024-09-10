using Project_App.DataAccess;
using Project_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Services
{
    internal class Color_Services
    {
        private readonly Color_DAO _colorDao;
        public Color_Services(Color_DAO colorDao)
        {
            _colorDao = colorDao;
        }
        public List<Color> GetAllColor()
        {
            try
            {
                return _colorDao.GetAllColor();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving products.", ex);
            }
        }

        public List<Color> GetColorBySearch(string searchText)
        {
            try
            {
                var allCategories = _colorDao.GetAllColor();
                return allCategories
                    .Where(c => c.TenMau.ToLower().Contains(searchText.ToLower()))
                    .Where(c => c.HEXCODE.ToLower().Contains(searchText.ToLower()))
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving categories.", ex);
            }
        }

        public Color GetColorById(int id)
        {
            return _colorDao.GetAllColor().Where(n => n.MaMau == id).First();
        }


    }
}
