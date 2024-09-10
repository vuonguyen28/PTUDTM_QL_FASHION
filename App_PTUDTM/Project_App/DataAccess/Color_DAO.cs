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
    internal class Color_DAO
    {
        private ConnectMysql _dbConnection;
        public Color_DAO()
        {
            _dbConnection = new ConnectMysql("Server=localhost;Port=3306;Database=ql_vtb;User ID=root;Password=;");
        }

        public List<Color> GetAllColor()
        {
            List<Color> ColorList = new List<Color>();

            string query = "SELECT * FROM mausac";
            DataTable dataTable = _dbConnection.ExecuteQuery(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Color color = new Color
                {
                    MaMau = Convert.ToInt32(row["MaMau"]),
                    TenMau = row["TenMau"].ToString(),
                    HEXCODE = row["HEXCODE"].ToString(),

                };
                ColorList.Add(color);
            }

            return ColorList;
        }
    }
}
