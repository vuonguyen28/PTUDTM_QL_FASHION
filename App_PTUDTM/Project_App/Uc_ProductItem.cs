using Project_App.GUI.Product_GUI;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class Uc_ProductItem : UserControl
    {
        private Form _parentForm;
        private Panel _overlayPanel; // Thêm Panel để làm mờ

        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Sale { get; set; }
        public decimal Gia { get; set; }

        public Uc_ProductItem()
        {
            InitializeComponent();
            _parentForm = null;
            _overlayPanel = new Panel(); // Khởi tạo Panel làm mờ
        }

        public Uc_ProductItem(Form defaultForm)
        {
            InitializeComponent();
            _parentForm = defaultForm;
            _overlayPanel = new Panel(); // Khởi tạo Panel làm mờ
        }

        public void SetParentForm(Form parentForm)
        {
            _parentForm = parentForm;
        }

        private void Uc_ProductItem_Load(object sender, EventArgs e)
        {
            label_Price.Text = Gia.ToString("C");
            label_Sale.Text = Sale.ToString("P");
            Lable_NameProduct.Text = TenSP;
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (_parentForm == null)
            {
                _parentForm = this.FindForm();
            }

            if (_parentForm != null)
            {
                // Tạo và cấu hình Panel để làm mờ
                _overlayPanel.Size = _parentForm.ClientSize;
                _overlayPanel.Location = new Point(0, 0);

                // Thêm Panel vào form cha
                _parentForm.Controls.Add(_overlayPanel);
                _overlayPanel.BringToFront(); // Đảm bảo panel ở trên cùng

                // Tạo và hiển thị Form_ProductDetail
                Form_ProductDetail form = new Form_ProductDetail(MaSP);

                // Đăng ký sự kiện FormClosed để loại bỏ Panel và khôi phục trạng thái khi form con đóng
                form.FormClosed += (s, args) =>
                {
                    _parentForm.Controls.Remove(_overlayPanel);
                };

                form.ShowDialog();
            }



        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ProductQuatity_Click(object sender, EventArgs e)
        {
            Form_ProductQuantity from = new Form_ProductQuantity(MaSP);
            from.Show();
        }
    }
}
