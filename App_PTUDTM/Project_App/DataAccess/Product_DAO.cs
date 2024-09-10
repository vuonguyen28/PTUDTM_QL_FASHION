using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connect_Mysql;
using Project_App.Model;
using Connect_Mysql;


namespace Project_App.DataAccess
{
    internal class Product_DAO
    {
        private ConnectMysql _dbConnection;
        public Product_DAO()
        {
            _dbConnection = new ConnectMysql("Server=localhost;Port=3306;Database=ql_vtb;User ID=root;Password=;");
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            string query = "SELECT * FROM sanpham";
            DataTable dataTable = _dbConnection.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Product product = new Product
                {
                    MaSP = Convert.ToInt32(row["MaSP"]),
                    TenSP = row["TenSP"].ToString(),
                    Gia = Convert.ToDecimal(row["Gia"]),
                    MoTa = row["MoTa"].ToString(),
                    PhanTramGiamGia = Convert.ToDouble(row["PhanTramGiamGia"]),
                    MaDanhMuc = Convert.ToInt32(row["MaDanhMuc"]),
                    MaNhaCungCap = Convert.ToInt32(row["MaNhaCungCap"]),
                    TrinhTrang = row["TrinhTrang"].ToString()
                };
                products.Add(product);
            }

            return products;
        }

        

    }
}
