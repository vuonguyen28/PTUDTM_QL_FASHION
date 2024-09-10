using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_App.Model;
using Connect_Mysql;
using System.Data;
using MySql.Data.MySqlClient;
using static Mysqlx.Expect.Open.Types;

namespace Project_App.DataAccess
{
    internal class ProductItem_DAO
    {
        private ConnectMysql _dbconnectMysql;
        public ProductItem_DAO()
        {
            _dbconnectMysql = new ConnectMysql("Server=localhost;Port=3306;Database=ql_vtb;User ID=root;Password=;");
        }

        public List<ProductItem> GetAllProductItem()
        {
            List<ProductItem> listProductItem = new List<ProductItem>();

            string query = "SELECT * FROM chitietsanpham";
            DataTable dataTable = _dbconnectMysql.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows) 
            {
                ProductItem item = new ProductItem
                {
                    MaChiTiet = Convert.ToInt32(row["MaChiTiet"]),
                    MaSP = Convert.ToInt32(row["MaSP"]),
                    MaKichThuoc = Convert.ToInt32(row["MaKichThuoc"]),
                    MaMau = Convert.ToInt32(row["MaMau"]),
                    SoLuongTon = Convert.ToInt32(row["SoLuongTon"]),
                };
                listProductItem.Add(item);
            }
            return listProductItem;
        }

        public void AddProductItem(ProductItem item)
        {
            string tableName = "chitietsanpham";
            string[] columns = { "MaSP", "MaKichThuoc", "MaMau", "SoLuongTon" };
            object[] values = { item.MaSP, item.MaKichThuoc, item.MaMau, item.SoLuongTon };
            _dbconnectMysql.Insert(tableName, columns, values);
        }

        public void UpdateProductItem(ProductItem item)
        {
            string tableName = "chitietsanpham";
            string setClause = $"MaMau = '{item.MaMau}', MaKichThuoc = '{item.MaKichThuoc}', SoLuongTon = '{item.SoLuongTon}'";
            string condition = $"MaChiTiet = '{item.MaChiTiet}'";
            _dbconnectMysql.Update(tableName, setClause, condition);
        }

        public void DeleteProductItem(int id) 
        {
            string tableName = "chitietsanpham";
            string condition = $"MaChiTiet = '{id}'";
            _dbconnectMysql.Delete(tableName,  condition);
        }



    }
}
