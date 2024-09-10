using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class Uc_Image : UserControl
    {
        private string urlImage;

        public string UrlImage { get => urlImage; set => urlImage = value; }

        public Uc_Image()
        {
            InitializeComponent();
        }


        private void Uc_Image_Load(object sender, EventArgs e)
        {
            pictureBox_image.Load(UrlImage);
        }
    }
}
