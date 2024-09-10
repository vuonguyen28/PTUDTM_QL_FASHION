using Project_App.GUI.Category_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_App
{
    public partial class Form_Category : Form
    {
        public Form_Category()
        {
            InitializeComponent();
        }

        private void guna2GradientTileButton3_Click(object sender, EventArgs e)
        {

        }

        private void btn_CategoryProduct_Click(object sender, EventArgs e)
        {
            LoadCategoryItemsForm();
        }

        private void LoadCategoryItemsForm()
        {
            // Đóng form con hiện tại nếu có
            if (this.Panel_content_category.Controls.Count > 0)
                this.Panel_content_category.Controls[0].Dispose();

            // Tạo instance của Form_Product
            GUI.Category_GUI.Form_Category_Items formCategoryColor = new GUI.Category_GUI.Form_Category_Items();

            // Thiết lập form con
            formCategoryColor.TopLevel = false;
            formCategoryColor.FormBorderStyle = FormBorderStyle.None;
            formCategoryColor.Dock = DockStyle.Fill;

            // Thêm form con vào panel_content
            this.Panel_content_category.Controls.Add(formCategoryColor);
            this.Panel_content_category.Tag = formCategoryColor;
            formCategoryColor.Show();

        }

        private void Panel_content_category_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Product_color_Click(object sender, EventArgs e)
        {
            LoadProductColorForm();
        }

        private void LoadProductColorForm()
        {
            // Đóng form con hiện tại nếu có
            if (this.Panel_content_category.Controls.Count > 0)
                this.Panel_content_category.Controls[0].Dispose();

            // Tạo instance của Form_Product
            GUI.Category_GUI.Form_Category_Color formCategoryColor = new GUI.Category_GUI.Form_Category_Color();

            // Thiết lập form con
            formCategoryColor.TopLevel = false;
            formCategoryColor.FormBorderStyle = FormBorderStyle.None;
            formCategoryColor.Dock = DockStyle.Fill;

            // Thêm form con vào panel_content
            this.Panel_content_category.Controls.Add(formCategoryColor);
            this.Panel_content_category.Tag = formCategoryColor;
            formCategoryColor.Show();

        }

        private void btn_productSize_Click(object sender, EventArgs e)
        {
            LoadProductSizeForm();
        }

        private void LoadProductSizeForm()
        {
            // Đóng form con hiện tại nếu có
            if (this.Panel_content_category.Controls.Count > 0)
                this.Panel_content_category.Controls[0].Dispose();

            // Tạo instance của Form_Product
            GUI.Category_GUI.Form_Category_Size formCategorySize = new GUI.Category_GUI.Form_Category_Size();

            // Thiết lập form con
            formCategorySize.TopLevel = false;
            formCategorySize.FormBorderStyle = FormBorderStyle.None;
            formCategorySize.Dock = DockStyle.Fill;

            // Thêm form con vào panel_content
            this.Panel_content_category.Controls.Add(formCategorySize);
            this.Panel_content_category.Tag = formCategorySize;
            formCategorySize.Show();

        }
    }
}
