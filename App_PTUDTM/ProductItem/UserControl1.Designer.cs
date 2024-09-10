namespace ProductItem
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.btn_cart = new System.Windows.Forms.PictureBox();
            this.label_Price = new System.Windows.Forms.Label();
            this.lable_discount = new System.Windows.Forms.Label();
            this.Lable_NameProduct = new System.Windows.Forms.Label();
            this.pictureBox_Url_Img = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Url_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cart
            // 
            this.btn_cart.Image = ((System.Drawing.Image)(resources.GetObject("btn_cart.Image")));
            this.btn_cart.Location = new System.Drawing.Point(166, 285);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(46, 41);
            this.btn_cart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cart.TabIndex = 9;
            this.btn_cart.TabStop = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Price.Location = new System.Drawing.Point(14, 308);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(83, 13);
            this.label_Price.TabIndex = 8;
            this.label_Price.Text = "198000 vnd";
            this.label_Price.Click += new System.EventHandler(this.label_Price_Click);
            // 
            // lable_discount
            // 
            this.lable_discount.AutoSize = true;
            this.lable_discount.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_discount.Location = new System.Drawing.Point(14, 285);
            this.lable_discount.Name = "lable_discount";
            this.lable_discount.Size = new System.Drawing.Size(83, 13);
            this.lable_discount.TabIndex = 7;
            this.lable_discount.Text = "198000 vnd";
            this.lable_discount.Click += new System.EventHandler(this.lable_discount_Click);
            // 
            // Lable_NameProduct
            // 
            this.Lable_NameProduct.AutoSize = true;
            this.Lable_NameProduct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_NameProduct.Location = new System.Drawing.Point(14, 252);
            this.Lable_NameProduct.Name = "Lable_NameProduct";
            this.Lable_NameProduct.Size = new System.Drawing.Size(159, 14);
            this.Lable_NameProduct.TabIndex = 6;
            this.Lable_NameProduct.Text = "ÁO THUNG THỎ 1 MÀU";
            this.Lable_NameProduct.Click += new System.EventHandler(this.Lable_NameProduct_Click);
            // 
            // pictureBox_Url_Img
            // 
            this.pictureBox_Url_Img.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Url_Img.Image")));
            this.pictureBox_Url_Img.Location = new System.Drawing.Point(17, 14);
            this.pictureBox_Url_Img.Name = "pictureBox_Url_Img";
            this.pictureBox_Url_Img.Size = new System.Drawing.Size(195, 216);
            this.pictureBox_Url_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Url_Img.TabIndex = 5;
            this.pictureBox_Url_Img.TabStop = false;
            this.pictureBox_Url_Img.Click += new System.EventHandler(this.pictureBox_Url_Img_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(174, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "20%";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cart);
            this.Controls.Add(this.label_Price);
            this.Controls.Add(this.lable_discount);
            this.Controls.Add(this.Lable_NameProduct);
            this.Controls.Add(this.pictureBox_Url_Img);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(236, 345);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Url_Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_cart;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label lable_discount;
        private System.Windows.Forms.Label Lable_NameProduct;
        private System.Windows.Forms.PictureBox pictureBox_Url_Img;
        private System.Windows.Forms.Label label1;
    }
}
