using Project_App.GUI;
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
    public partial class Form_Item : Form
    {
        public Form_Item()
        {
            InitializeComponent();
        }
        private void Form_Item_Load(object sender, EventArgs e)
        {

        }
        

        private void lable_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

     

        private void panel_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadEmployeesForm()
        {
            // Đóng form con hiện tại nếu có
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();

            // Tạo instance của Form_Product
            Form_Product productForm = new Form_Product();

            // Thiết lập form con
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;

            // Thêm form con vào panel_content
            this.panel_content.Controls.Add(productForm);
            this.panel_content.Tag = productForm;
            productForm.Show();
        }

       

        private void btn_Product_Click(object sender, EventArgs e)
        {
            LoadProductForm();
        }
        private void LoadProductForm()
        {
            // Đóng form con hiện tại nếu có
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();

            // Tạo instance của Form_Product
            Form_Product productForm = new Form_Product();

            // Thiết lập form con
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;

            // Thêm form con vào panel_content
            this.panel_content.Controls.Add(productForm);
            this.panel_content.Tag = productForm;
            productForm.Show();
        }

        private void btn_Category_Click(object sender, EventArgs e)
        {
            LoadCategoryForm();
        }

        private void LoadCategoryForm()
        {
            // Đóng form con hiện tại nếu có
            if (this.panel_content.Controls.Count > 0)
                this.panel_content.Controls[0].Dispose();

            // Tạo instance của Form_Category
            Form_Category categoryForm = new Form_Category();

            // Thiết lập form con
            categoryForm.TopLevel = false;
            categoryForm.FormBorderStyle = FormBorderStyle.None;
            categoryForm.Dock = DockStyle.Fill;

            // Thêm form con vào panel_content
            this.panel_content.Controls.Add(categoryForm);
            this.panel_content.Tag = categoryForm;
            categoryForm.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void btn_Pos_Click(object sender, EventArgs e)
        {
            LoadPoSForm();
        }

        private void LoadPoSForm()
        {
            FormPOS pos = new FormPOS();
            pos.Show();
        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
