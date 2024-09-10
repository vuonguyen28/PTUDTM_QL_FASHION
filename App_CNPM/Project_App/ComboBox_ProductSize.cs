using Guna.UI2.WinForms;
using Project_App.DataAccess;
using Project_App.Services;
using System.Diagnostics;
using System.Windows.Forms;


namespace Project_App
{
    public class ComboBox_ProductSize: ComboBox
    {

        public class ComboBoxItem
        {
            public int MaKichThuoc { get; set; }
            public string TenDanhMuc { get; set; }

            public ComboBoxItem(int maKichThuoc, string tenDanhMuc)
            {
                MaKichThuoc = maKichThuoc;
                TenDanhMuc = tenDanhMuc;
            }

            public override string ToString()
            {
                return TenDanhMuc;
            }
        }


        public ComboBox_ProductSize()
        {
            var sizeService = new Size_Services(new Size_DAO());
            var sizes = sizeService.getAllSize();

            this.Items.Clear();
            foreach (var size in sizes)
            {
                this.Items.Add(new ComboBoxItem(size.MaDanhMuc, size.TenDanhMuc));
            }

            if (this.Items.Count > 0)
            {
                this.SelectedIndex = 0;
            }
        }

        public void SelectByMaKichThuoc(int maKichThuoc)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                var item = this.Items[i] as ComboBoxItem;
                if (item != null && item.MaKichThuoc == maKichThuoc)
                {
                    this.SelectedIndex = i;
                    break;
                }
            }
        }
    }

    

}






