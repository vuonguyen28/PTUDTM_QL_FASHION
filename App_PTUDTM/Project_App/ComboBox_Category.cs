using Project_App.DataAccess;
using Project_App.Services;
using System.Windows.Forms;

namespace Project_App
{
    public class ComboBox_Category : ComboBox
    {
        public ComboBox_Category()
        {
            this.TextChanged += ComboBox_Category_TextChanged;


            var categoryService = new Category_Services(new Category_DAO());
            var categories = categoryService.getAllCategory();

            // Đưa danh sách các danh mục vào ComboBox
            this.Items.Clear();
            foreach (var category in categories)
            {
                this.Items.Add(category.TenDanhMuc);
            }

            // Tùy chọn: Chọn mục đầu tiên nếu có danh sách
            if (this.Items.Count > 0)
            {
                this.SelectedIndex = 0;
            }
        }

        private void ComboBox_Category_TextChanged(object sender, System.EventArgs e)
        {
           
        }
    }
}
