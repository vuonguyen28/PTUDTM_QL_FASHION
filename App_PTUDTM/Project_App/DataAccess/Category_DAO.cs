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
    internal class Category_DAO
    {
        private ConnectMysql _dbConnection;



        public Category_DAO()
        {
            _dbConnection = new ConnectMysql("Server=localhost;Port=3306;Database=ql_vtb;User ID=root;Password=;");
        }

        public List<Category> GetAllCategory()
        {
            List<Category> categoryList = new List<Category>();

            string query = "SELECT * FROM danhmuc";

            DataTable dataTable = _dbConnection.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Category category = new Category
                {
                    MaDanhMuc = Convert.ToInt32(row["MaDanhMuc"]),
                    TenDanhMuc = row["TenDanhMuc"].ToString(),
                };
                categoryList.Add(category);
            }

            return categoryList;
        }

    }
}
