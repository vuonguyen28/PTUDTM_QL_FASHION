namespace Project_App
{
    partial class Uc_ProductDetailPos
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
            this.btn_Add = new Guna.UI2.WinForms.Guna2Button();
            this.label_Size = new System.Windows.Forms.Label();
            this.label_Color = new System.Windows.Forms.Label();
            this.lable_IDProduct = new System.Windows.Forms.Label();
            this.label_SoLuongTon = new System.Windows.Forms.Label();
            this.txt_Number = new ClassLibrary.TextBox_Number();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add.FillColor = System.Drawing.Color.Teal;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(493, 14);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(58, 28);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "ADD";
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Size.ForeColor = System.Drawing.Color.Black;
            this.label_Size.Location = new System.Drawing.Point(192, 19);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(38, 14);
            this.label_Size.TabIndex = 2;
            this.label_Size.Text = "SIZE";
            // 
            // label_Color
            // 
            this.label_Color.AutoSize = true;
            this.label_Color.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Color.ForeColor = System.Drawing.Color.Black;
            this.label_Color.Location = new System.Drawing.Point(92, 19);
            this.label_Color.Name = "label_Color";
            this.label_Color.Size = new System.Drawing.Size(55, 14);
            this.label_Color.TabIndex = 3;
            this.label_Color.Text = "COLOR";
            // 
            // lable_IDProduct
            // 
            this.lable_IDProduct.AutoSize = true;
            this.lable_IDProduct.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_IDProduct.ForeColor = System.Drawing.Color.Black;
            this.lable_IDProduct.Location = new System.Drawing.Point(16, 19);
            this.lable_IDProduct.Name = "lable_IDProduct";
            this.lable_IDProduct.Size = new System.Drawing.Size(51, 14);
            this.lable_IDProduct.TabIndex = 4;
            this.lable_IDProduct.Text = "#IDSP";
            // 
            // label_SoLuongTon
            // 
            this.label_SoLuongTon.AutoSize = true;
            this.label_SoLuongTon.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoLuongTon.ForeColor = System.Drawing.Color.Black;
            this.label_SoLuongTon.Location = new System.Drawing.Point(268, 19);
            this.label_SoLuongTon.Name = "label_SoLuongTon";
            this.label_SoLuongTon.Size = new System.Drawing.Size(105, 14);
            this.label_SoLuongTon.TabIndex = 5;
            this.label_SoLuongTon.Text = "SOLUONGTON";
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(388, 14);
            this.txt_Number.Multiline = true;
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(85, 28);
            this.txt_Number.TabIndex = 6;

            // 
            // Uc_ProductDetailPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.label_SoLuongTon);
            this.Controls.Add(this.lable_IDProduct);
            this.Controls.Add(this.label_Color);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.btn_Add);
            this.Name = "Uc_ProductDetailPos";
            this.Size = new System.Drawing.Size(569, 55);
            this.Load += new System.EventHandler(this.Uc_ProductDetailPos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_Add;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label_Color;
        private System.Windows.Forms.Label lable_IDProduct;
        private System.Windows.Forms.Label label_SoLuongTon;
        private ClassLibrary.TextBox_Number txt_Number;
    }
}
