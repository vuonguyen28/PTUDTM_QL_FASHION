namespace Project_App.GUI.Product_GUI
{
    partial class Form_ProductDetail_POS
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_ListProductItem = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.SuspendLayout();
            // 
            // Panel_ListProductItem
            // 
            this.Panel_ListProductItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Panel_ListProductItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Panel_ListProductItem.Location = new System.Drawing.Point(2, 3);
            this.Panel_ListProductItem.Name = "Panel_ListProductItem";
            this.Panel_ListProductItem.ShadowColor = System.Drawing.Color.Black;
            this.Panel_ListProductItem.Size = new System.Drawing.Size(616, 398);
            this.Panel_ListProductItem.TabIndex = 0;
            this.Panel_ListProductItem.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_ListProductItem_Paint);
            // 
            // Form_ProductDetail_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 401);
            this.Controls.Add(this.Panel_ListProductItem);
            this.Name = "Form_ProductDetail_POS";
            this.Text = "Form_ProductDetail_POS";
            this.Load += new System.EventHandler(this.Form_ProductDetail_POS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel Panel_ListProductItem;
    }
}