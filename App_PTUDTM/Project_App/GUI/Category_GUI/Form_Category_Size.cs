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
    public partial class Form_Category_Size : Form
    {
        private List<Project_App.Model.Size> _allSize;
        private Size_DAO sizeDAO;
        private Size_Services _sizeServices;
        public Form_Category_Size()
        {
            InitializeComponent();

            sizeDAO = new Size_DAO();
            _sizeServices = new Size_Services(sizeDAO);
        }
        
        private void Form_Category_Size_Load(object sender, EventArgs e)
        {
            _allSize = _sizeServices.getAllSize();
            DataGridView_Size.DataSource = _allSize;
            functionVisible();
        }


        // khởi tạo biến đang ở chế độ tạo mới hay không tạo mới
        private bool _isCreatingNew = false;

        private void DataGridView_Size_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void functionVisible()
        {
            // ẩn các nút không cần thiết ban đầu
            textBox_MaSize.Visible = false;
            textBox_TenSize.Visible = false;
            label_MaSize.Visible = false;
            label_TenSize.Visible = false;

            // textbox không được phép nhập
            textBox_MaSize.ReadOnly = true;

            // ẩn các button ban đầu
            btn_create.Enabled = true;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;
            btn_save.Visible = false;
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            var size_Services = new Size_Services(sizeDAO);
            // Lấy văn bản từ TextBox
            string searchText = textBox_Search.Text.ToLower();

            // Lọc danh sách danh mục dựa trên văn bản tìm kiếm
            var filteredCategories = size_Services.GetSizeBySearch(searchText);

            // Cập nhật DataGridView
            DataGridView_Size.DataSource = filteredCategories;
        }

        private void textBox_TenSize_TextChanged(object sender, EventArgs e)
        {
            if (_isCreatingNew != true)
            {
                if (!string.IsNullOrEmpty(textBox_TenSize.Text))
                {
                    btn_update.Enabled = true;
                }
                else
                {
                    btn_update.Enabled = false;
                }
            }
        }

        private void DataGridView_Size_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có hàng nào đang được chọn không (đảm bảo không chọn header)
            if (e.RowIndex >= 0)
            {
                textBox_MaSize.Visible = true;
                textBox_TenSize.Visible = true;
                label_MaSize.Visible = true;
                label_TenSize.Visible = true;

                btn_save.Visible = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;

                // đặt lại trạng thái creat
                _isCreatingNew = true;
                // Lấy hàng hiện tại
                DataGridViewRow row = DataGridView_Size.Rows[e.RowIndex];

                // Đổ dữ liệu từ hàng vào các TextBox
                textBox_MaSize.Text = row.Cells["MaDanhMuc"].Value.ToString();
                textBox_TenSize.Text = row.Cells["TenDanhMuc"].Value.ToString();

            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            // đặt biến cờ khi ấn vào thì nó đang ở chế độ tạo mới
            _isCreatingNew = true;

            // Ẩn TextBox và Label cho MaDanhMuc
            textBox_MaSize.Visible = false;
            label_TenSize.Visible = false;
            btn_delete.Enabled = false;
            btn_update.Enabled = false;

            // Hiển thị TextBox và Label cho TenDanhMuc
            textBox_TenSize.Visible = true;
            label_TenSize.Visible = true;

            // Xóa nội dung trong các TextBox
            textBox_TenSize.Text = "";
            textBox_MaSize.Text = "";

            btn_save.Visible = true;
        }

        
    }
}
