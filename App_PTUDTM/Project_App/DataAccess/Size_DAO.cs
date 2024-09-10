using Connect_Mysql;
using Project_App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.DataAccess
{
    internal class Size_DAO
    {
        private ConnectMysql _dbConnection;
        public Size_DAO()
        {
            _dbConnection = new ConnectMysql("Server=localhost;Port=3306;Database=ql_vtb;User ID=root;Password=;");
        }

        public List<Size> GetAllSize()
        {
            List<Size> SizeList = new List<Size>();

            string query = "SELECT * FROM kichthuoc";
            DataTable dataTable = _dbConnection.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Size size = new Size
                {
                    MaDanhMuc = Convert.ToInt32(row["MaKichThuoc"]),
                    TenDanhMuc = row["TenKichThuoc"].ToString(),
                };
                SizeList.Add(size);
            }

            return SizeList;
        }
    }
}
