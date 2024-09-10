using System;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;

namespace Connect_Mysql
{
    public class ConnectMysql
    {
        private readonly string _connectionString;

        public ConnectMysql(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Phương thức kết nối cơ sở dữ liệu
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    connection.Open();
                    return connection.State == ConnectionState.Open;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Lỗi khi kết nối cơ sở dữ liệu: " + ex.Message);
                return false;
            }
        }

        // Phương thức thực hiện một câu lệnh SQL và trả về DataTable
        public DataTable ExecuteQuery(string query)
        {
            using (MySqlConnection connection = GetConnection())
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi khi thực hiện truy vấn: " + ex.Message);
                }
                return dataTable;
            }
        }

        // Phương thức thực hiện một câu lệnh SQL không trả về dữ liệu
        public void ExecuteNonQuery(string query)
        {
            using (MySqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("Lỗi khi thực hiện câu lệnh: " + ex.Message);
                }
            }
        }

        // Phương thức thêm dữ liệu vào cơ sở dữ liệu
        public void Insert(string tableName, string[] columns, object[] values)
        {
            if (columns.Length != values.Length)
            {
                throw new ArgumentException("Số cột không khớp với số giá trị.");
            }

            var columnsList = string.Join(", ", columns);
            var valuesList = string.Join(", ", values.Select(v => $"'{v}'"));
            var query = $"INSERT INTO {tableName} ({columnsList}) VALUES ({valuesList})";

            ExecuteNonQuery(query);
        }

        // Phương thức xóa dữ liệu từ cơ sở dữ liệu
        public void Delete(string tableName, string condition)
        {
            var query = $"DELETE FROM {tableName} WHERE {condition}";
            ExecuteNonQuery(query);
        }

        // Phương thức cập nhật dữ liệu trong cơ sở dữ liệu
        public void Update(string tableName, string setClause, string condition)
        {
            var query = $"UPDATE {tableName} SET {setClause} WHERE {condition}";
            ExecuteNonQuery(query);
        }
    }
}
