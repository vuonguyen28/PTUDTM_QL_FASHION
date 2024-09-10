using Project_App.DataAccess;
using Project_App.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_App
{
    

    public class ComboBox_ProductColor:ComboBox
    {
        public class ComboBoxItem
        {
            public int MaMau { get; set; }
            public string TenMau { get; set; }

            public ComboBoxItem(int maMau, string tenMau)
            {
                MaMau = maMau;
                TenMau = tenMau;
            }

            public override string ToString()
            {
                return TenMau;
            }
        }
        public ComboBox_ProductColor()
        {
            var colorService = new Color_Services(new Color_DAO());
            var colors = colorService.GetAllColor();

            this.Items.Clear();
            foreach (var color in colors)
            {
                // Thêm ComboBoxItem chứa cả MaMau và TenMau vào ComboBox
                this.Items.Add(new ComboBoxItem(color.MaMau, color.TenMau));
            }

            if (this.Items.Count > 0)
            {
                this.SelectedIndex = 0;
            }
        }

        public void SelectByMaMau(int maMau)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                var item = this.Items[i] as ComboBoxItem;
                if (item != null && item.MaMau == maMau)
                {
                    this.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
