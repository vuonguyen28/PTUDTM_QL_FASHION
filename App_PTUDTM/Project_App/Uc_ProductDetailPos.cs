using System;
using System.Windows.Forms;

namespace Project_App
{
    public partial class Uc_ProductDetailPos : UserControl
    {
        private int id;
        private int id_color;
        private int id_size;
        private int id_QuantityStock;
        private int id_SoLuongTon;
       

        public int Id { get => id; set => id = value; }
        public int Id_color { get => id_color; set => id_color = value; }
        public int Id_size { get => id_size; set => id_size = value; }
        public int Id_QuantityStock { get => id_QuantityStock; set => id_QuantityStock = value; }
        public int Id_SoLuongTon { get => id_SoLuongTon; set => id_SoLuongTon = value; }


        private readonly Color_Services _colorService;
        private readonly Size_Services _sizeService;

        public Uc_ProductDetailPos()
        {
            InitializeComponent();
            _colorService = new Color_Services(new Color_DAO());
            _sizeService = new Size_Services(new Size_DAO());
        }
        private void LoadProductDetails()
        {
            var color = _colorService.GetColorById(id_color);
            label_Color.Text = color != null ? color.TenMau : "Unknown";

            var size = _sizeService.GetSizeById(id_size);
            label_Size.Text = size != null ? size.TenDanhMuc : "Unknown";

            txt_Number.Text = id_QuantityStock.ToString();
            lable_IDProduct.Text = Id.ToString();
            label_SoLuongTon.Text = Id_SoLuongTon.ToString();
        }

        private void Uc_ProductDetailPos_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
        }
    }
}
