using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connect_Mysql;
using Project_App.Model;
using Connect_Mysql;
using System.Collections.Generic;
using System.Data;
using System;


namespace Project_App.DataAccess
{
    internal class ImageProduct_DAO
    {
        private ConnectMysql _dbConnection;
        public ImageProduct_DAO()
        {
            _dbConnection = new ConnectMysql("Server=localhost;Port=3306;Database=ql_vtb;User ID=root;Password=;");
        }

        public List<ImageProduct> GetAllImage()
        {
            List<ImageProduct> imageList = new List<ImageProduct>();

            string query = "SELECT * FROM HinhAnh";
            DataTable dataTable = _dbConnection.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                ImageProduct img = new ImageProduct
                {
                    MaHinhAnh = Convert.ToInt32(row["MaHinhAnh"]),
                    MaSP = Convert.ToInt32(row["MaSp"]),
                    Url_Img = row["hinhanh"].ToString(),

                };
                imageList.Add(img);
            }

            return imageList;
        }

        public void AddImageProduct(ImageProduct img)
        {
            string tableName = "hinhanh";
            string[] columns = { "MaSP","hinhanh" };
            object[] values = { img.MaSP, img.Url_Img };
            _dbConnection.Insert(tableName, columns, values);

        }

        public void DeleteImageProduct(int id) 
        {
            string tableName = "hinhanh";
            string condition = "MaHinhAnh ='" + id + "'";
            _dbConnection.Delete(tableName, condition);
        }

    }
}
