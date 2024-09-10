using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Connect_Mysql;
using Project_App.DataAccess;
using Project_App.Model;
using Project_App.Services;

namespace Project_App.GUI.Category_GUI
{
    public partial class Form_Category_Items : Form
    {


        private List<Category> _allCategories;
        private Category_DAO categoryDAO;
        private Category_Services _categoryServices;


        // khởi tạo biến đang ở chế độ tạo mới hay không tạo mới
        private bool _isCreatingNew = false;


        public Form_Category_Items()
        {
            InitializeComponent();
            categoryDAO = new Category_DAO();
            _categoryServices = new Category_Services(categoryDAO);
        }

        private void Form_Category_Items_Load(object sender, EventArgs e)
        {
            _allCategories = _categoryServices.getAllCategory();

            DataGridView_Data.DataSource = _allCategories;

            functionVisible();
        }

        private void functionVisible()
        {
            // ẩn các nút không cần thiết ban đầu
            textBox_MaDanhMuc.Visible = false;
            textBox_TenDanhMuc.Visible = false;
            label_MaDanhMuc.Visible = false;
            label_TenDanhMuc.Visible = false;

            // textbox không được phép nhập
            textBox_MaDanhMuc.ReadOnly = true;

            // ẩn các button ban đầu
            btn_create.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_save.Visible = false;
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            var category_Services = new Category_Services(categoryDAO);
            // Lấy văn bản từ TextBox
            string searchText = textBox_Search.Text.ToLower();

            // Lọc danh sách danh mục dựa trên văn bản tìm kiếm
            var filteredCategories = category_Services.GetCategoriesBySearch(searchText);

            // Cập nhật DataGridView
            DataGridView_Data.DataSource = filteredCategories;
        }

        private void textBox_TenDanhMuc_TextChanged(object sender, EventArgs e)
        {
            if (_isCreatingNew != true)
            {
                if (!string.IsNullOrEmpty(textBox_TenDanhMuc.Text))
                {
                    btn_update.Enabled = true;
                }
                else
                {
                    btn_update.Enabled = false;
                }
            }
        }

        private void DataGridView_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

            // đặt biến cờ khi ấn vào thì nó đang ở chế độ tạo mới
            _isCreatingNew = true;

            // Ẩn TextBox và Label cho MaDanhMuc
            textBox_MaDanhMuc.Visible = false;
            label_MaDanhMuc.Visible = false;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            // Hiển thị TextBox và Label cho TenDanhMuc
            textBox_TenDanhMuc.Visible = true;
            label_TenDanhMuc.Visible = true;

            // Xóa nội dung trong các TextBox
            textBox_TenDanhMuc.Text = "";
            textBox_MaDanhMuc.Text = "";

            btn_save.Visible = true;
        }

        private void DataGridView_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Kiểm tra xem có hàng nào đang được chọn không (đảm bảo không chọn header)
            if (e.RowIndex >= 0)
            {

                textBox_MaDanhMuc.Visible = true;
                textBox_TenDanhMuc.Visible = true;
                label_MaDanhMuc.Visible = true;
                label_TenDanhMuc.Visible = true;

                btn_save.Visible = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;

                // đặt lại trạng thái creat
                _isCreatingNew = true;
                // Lấy hàng hiện tại
                DataGridViewRow row = DataGridView_Data.Rows[e.RowIndex];

                // Đổ dữ liệu từ hàng vào các TextBox
                textBox_MaDanhMuc.Text = row.Cells["MaDanhMuc"].Value.ToString();
                textBox_TenDanhMuc.Text = row.Cells["TenDanhMuc"].Value.ToString();

            }
        }
    }
}
