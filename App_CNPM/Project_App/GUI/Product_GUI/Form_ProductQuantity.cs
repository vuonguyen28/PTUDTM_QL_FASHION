using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_App.DataAccess;
using Project_App.Services;
using Project_App.Model;

namespace Project_App.GUI.Product_GUI
{
    public partial class Form_ProductQuantity : Form
    {
        ProductItem_Service productItemService;
        ProductItem_DAO productItemDAO;

        private int _MaSP;
        public Form_ProductQuantity(int MaSP)
        {
            _MaSP = MaSP;
            InitializeComponent();

            
        }

        private void Form_ProductQuantity_Load(object sender, EventArgs e)
        {
            productItemDAO = new ProductItem_DAO();
            productItemService = new ProductItem_Service(productItemDAO);
            List<ProductItem> listData = productItemService.getAllProductItemByMaSP(_MaSP);

            DataGridView_ListProductQuantity.DataSource = listData;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_ListProductQuantity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // hiển chị các chức năng cần thiết khi dữ liệu được đổ ra textbox và combobox
                btn_edit.Visible = true;
                btn_save.Visible = false;
                btn_edit.Enabled = true;
                btn_update.Visible = false;
                btn_delete.Visible = true;
                textBo_Quantity.Enabled = false;
                comboBox_Size.Enabled = false;
                comboBox_Color.Enabled = false;


                DataGridViewRow row = DataGridView_ListProductQuantity.Rows[e.RowIndex];
                int selectedId = Convert.ToInt32(row.Cells["MaChiTiet"].Value);
                int selectedColorId = Convert.ToInt32(row.Cells["MaMau"].Value);
                int selectedSize = Convert.ToInt32(row.Cells["MaKichThuoc"].Value); 
                string selectedQuantity = row.Cells["SoLuongTon"].Value.ToString();

                ComboBox_ProductColor comboBox_ProductColor = this.Controls.OfType<ComboBox_ProductColor>().FirstOrDefault();
                if (comboBox_ProductColor != null)
                {
                    comboBox_ProductColor.SelectByMaMau(selectedColorId);
                }

                ComboBox_ProductSize comboBox_ProductSize = this.Controls.OfType<ComboBox_ProductSize>().FirstOrDefault();
                if (comboBox_ProductSize != null)
                {
                    comboBox_ProductSize.SelectByMaKichThuoc(selectedSize);
                }


                textBo_Quantity.Text = selectedQuantity;
                txt_MaChiTiet.Text = selectedId.ToString();
            }
        }

       

        private void btn_save_Click(object sender, EventArgs e)
        {
            Save_Update_DeleteProductItem(checkFunction: 0);
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            textBo_Quantity.Enabled = true;
            comboBox_Color.Enabled = true;
            comboBox_Size.Enabled = true;

            btn_update.Visible = false;
            btn_edit.Visible = false;
            btn_save.Visible = true;
            btn_delete.Visible = false;

            textBo_Quantity.Text = string.Empty; 
            comboBox_Color.SelectedIndex = -1;
            comboBox_Size.SelectedIndex = -1;

        }
        private void btn_edit_Click(object sender, EventArgs e)
        {

            textBo_Quantity.Enabled = true;
            comboBox_Color.Enabled = true;
            comboBox_Size.Enabled = true;

            btn_update.Visible = true;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {

            textBo_Quantity.Enabled = false;
            comboBox_Color.Enabled = false;
            comboBox_Size.Enabled = false;
            btn_update.Visible = false;
            Save_Update_DeleteProductItem(checkFunction: 1);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Save_Update_DeleteProductItem(checkFunction: 2);
        }
        private void Save_Update_DeleteProductItem(int checkFunction)
        {
            int maKichThuoc = 0;
            int maMau = 0;
            int soLuongTon = 0;
            int id = 0;
            // Lấy MaKichThuoc từ ComboBox_ProductSize
            ComboBox_ProductSize comboBox_ProductSize = this.Controls.OfType<ComboBox_ProductSize>().FirstOrDefault();
            if (comboBox_ProductSize != null && comboBox_ProductSize.SelectedItem != null)
            {
                var selectedItemSize = comboBox_ProductSize.SelectedItem as ComboBox_ProductSize.ComboBoxItem;
                if (selectedItemSize != null)
                {
                    maKichThuoc = selectedItemSize.MaKichThuoc;
                }
            }

            // Lấy MaMau từ ComboBox_ProductColor
            ComboBox_ProductColor comboBox_ProductColor = this.Controls.OfType<ComboBox_ProductColor>().FirstOrDefault();
            if (comboBox_ProductColor != null && comboBox_ProductColor.SelectedItem != null)
            {
                var selectedItemColor = comboBox_ProductColor.SelectedItem as ComboBox_ProductColor.ComboBoxItem;
                if (selectedItemColor != null)
                {
                    maMau = selectedItemColor.MaMau;
                }
            }

            if (!int.TryParse(textBo_Quantity.Text, out soLuongTon))
            {
                MessageBox.Show("Số lượng tồn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txt_MaChiTiet.Text, out id))
            {
                MessageBox.Show("id không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (checkFunction == 1)
            {
                ProductItem item = new ProductItem
                {
                    MaChiTiet = id,
                    MaKichThuoc = maKichThuoc,
                    MaMau = maMau,
                    SoLuongTon = soLuongTon,
                };

                productItemDAO.UpdateProductItem(item);
                MessageBox.Show("Đã cập nhật thành công sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (checkFunction == 2)
            {
                productItemDAO.DeleteProductItem(id);
                MessageBox.Show("Đã xóa thành công sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            if (checkFunction == 0)
            {
                ProductItem item = new ProductItem
                {
                    MaChiTiet = 1,
                    MaSP = _MaSP,
                    MaKichThuoc = maKichThuoc,
                    MaMau = maMau,
                    SoLuongTon = soLuongTon,
                };

                // Lưu sản phẩm mới
                productItemDAO.AddProductItem(item);
                MessageBox.Show("Đã lưu thành công sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Cập nhật lại danh sách sản phẩm trong DataGridView
            List<ProductItem> listData = productItemService.getAllProductItemByMaSP(_MaSP);
            DataGridView_ListProductQuantity.DataSource = listData;
        }

        private void DataGridView_ListProductQuantity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
