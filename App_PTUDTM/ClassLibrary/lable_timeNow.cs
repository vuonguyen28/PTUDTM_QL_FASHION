using System;
using System.Windows.Forms;
using System.Drawing;

namespace ClassLibrary
{
    public class lable_timeNow : System.Windows.Forms.Label
    {
        private Timer timer;

        public lable_timeNow()
        {
            // Thiết lập thuộc tính cho Label
            this.AutoSize = true;
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Khởi tạo và cấu hình Timer
            timer = new Timer();
            timer.Interval = 1000; // Cập nhật mỗi giây
            timer.Tick += Timer_Tick;
            timer.Start();

            // Cập nhật thời gian ngay khi khởi tạo
            UpdateTime();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            this.Text = DateTime.Now.ToString("HH:mm:ss"); // Định dạng giờ:phút:giây
        }
    }
}
