using Project_App.DataAccess;
using Project_App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Services
{
    internal class ImageProduct_Services
    {
        private readonly ImageProduct_DAO _imgProduct;
        public ImageProduct_Services(ImageProduct_DAO imgDao)
        {
            _imgProduct = imgDao;
        }
        public List<ImageProduct> GetAllImage()
        {
            try
            {
                return _imgProduct.GetAllImage();
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving products.", ex);
            }
        }

        public ImageProduct GetFirstImageByMaSP(int maSP)
        {
            List<ImageProduct> images = _imgProduct.GetAllImage();

            if (images != null && images.Count > 0)
            {
                ImageProduct firstImage = images.FirstOrDefault(img => img.MaSP == maSP);

                return firstImage;
            }
            else
            {
                return null; 
            }
        }

        public List<ImageProduct> GetImageByMaSP(int maSP)
        {
            List<ImageProduct> ListImage = _imgProduct.GetAllImage().Where(img => img.MaSP == maSP).ToList();
            return ListImage;
        }

    }
}
