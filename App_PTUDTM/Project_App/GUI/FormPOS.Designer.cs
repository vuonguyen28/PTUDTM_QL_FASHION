namespace Project_App.GUI
{
    partial class FormPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPOS));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.icon_exit = new System.Windows.Forms.Label();
            this.panel_contentProduct = new System.Windows.Forms.Panel();
            this.textBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Pay = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.lable_timeNow1 = new ClassLibrary.lable_timeNow();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.POS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2GradientTileButton3 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton2 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton4 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientTileButton5 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.POS);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lable_timeNow1);
            this.panel2.Controls.Add(this.icon_exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 40);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.Controls.Add(this.btn_Pay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1042, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 647);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.guna2GradientTileButton5);
            this.panel4.Controls.Add(this.guna2GradientTileButton3);
            this.panel4.Controls.Add(this.guna2GradientTileButton4);
            this.panel4.Controls.Add(this.guna2GradientTileButton2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 606);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1042, 81);
            this.panel4.TabIndex = 3;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.AutoRoundedCorners = true;
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Red;
            this.guna2ComboBox1.BorderRadius = 17;
            this.guna2ComboBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FillColor = System.Drawing.Color.PaleTurquoise;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.DeepPink;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "category"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(420, 10);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(262, 36);
            this.guna2ComboBox1.TabIndex = 21;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.guna2ComboBox1);
            this.panel5.Controls.Add(this.textBox_Search);
            this.panel5.Location = new System.Drawing.Point(0, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1042, 55);
            this.panel5.TabIndex = 3;
            // 
            // icon_exit
            // 
            this.icon_exit.AutoSize = true;
            this.icon_exit.BackColor = System.Drawing.Color.Transparent;
            this.icon_exit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icon_exit.ForeColor = System.Drawing.Color.Red;
            this.icon_exit.Location = new System.Drawing.Point(1315, 6);
            this.icon_exit.Name = "icon_exit";
            this.icon_exit.Size = new System.Drawing.Size(31, 29);
            this.icon_exit.TabIndex = 11;
            this.icon_exit.Text = "X";
            this.icon_exit.Click += new System.EventHandler(this.icon_exit_Click);
            // 
            // panel_contentProduct
            // 
            this.panel_contentProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_contentProduct.BackColor = System.Drawing.Color.White;
            this.panel_contentProduct.Location = new System.Drawing.Point(0, 92);
            this.panel_contentProduct.Name = "panel_contentProduct";
            this.panel_contentProduct.Size = new System.Drawing.Size(1042, 514);
            this.panel_contentProduct.TabIndex = 2;
            this.panel_contentProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contentProduct_Paint);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Animated = true;
            this.textBox_Search.AutoRoundedCorners = true;
            this.textBox_Search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox_Search.BorderRadius = 17;
            this.textBox_Search.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.textBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Search.DefaultText = "";
            this.textBox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_Search.IconRight = ((System.Drawing.Image)(resources.GetObject("textBox_Search.IconRight")));
            this.textBox_Search.Location = new System.Drawing.Point(6, 10);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PasswordChar = '\0';
            this.textBox_Search.PlaceholderText = "search product name";
            this.textBox_Search.SelectedText = "";
            this.textBox_Search.ShadowDecoration.BorderRadius = 30;
            this.textBox_Search.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.textBox_Search.Size = new System.Drawing.Size(408, 36);
            this.textBox_Search.TabIndex = 20;
            // 
            // btn_Pay
            // 
            this.btn_Pay.Animated = true;
            this.btn_Pay.AutoRoundedCorners = true;
            this.btn_Pay.BackColor = System.Drawing.Color.Transparent;
            this.btn_Pay.BorderRadius = 23;
            this.btn_Pay.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btn_Pay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Pay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Pay.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Pay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Pay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Pay.FillColor2 = System.Drawing.Color.Lime;
            this.btn_Pay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Pay.Font = new System.Drawing.Font("Verdana", 18F);
            this.btn_Pay.ForeColor = System.Drawing.Color.White;
            this.btn_Pay.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btn_Pay.Location = new System.Drawing.Point(20, 566);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(312, 49);
            this.btn_Pay.TabIndex = 0;
            this.btn_Pay.Text = "Pay ";
            this.btn_Pay.UseTransparentBackground = true;
            // 
            // lable_timeNow1
            // 
            this.lable_timeNow1.AutoSize = true;
            this.lable_timeNow1.BackColor = System.Drawing.Color.Transparent;
            this.lable_timeNow1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_timeNow1.ForeColor = System.Drawing.Color.White;
            this.lable_timeNow1.Location = new System.Drawing.Point(1080, 3);
            this.lable_timeNow1.Name = "lable_timeNow1";
            this.lable_timeNow1.Size = new System.Drawing.Size(65, 14);
            this.lable_timeNow1.TabIndex = 12;
            this.lable_timeNow1.Text = "01:40:33";
            this.lable_timeNow1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // POS
            // 
            this.POS.AutoSize = true;
            this.POS.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POS.ForeColor = System.Drawing.Color.White;
            this.POS.Location = new System.Drawing.Point(48, 9);
            this.POS.Name = "POS";
            this.POS.Size = new System.Drawing.Size(54, 23);
            this.POS.TabIndex = 14;
            this.POS.Text = "POS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1080, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1042, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // guna2GradientTileButton3
            // 
            this.guna2GradientTileButton3.Animated = true;
            this.guna2GradientTileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientTileButton3.FillColor2 = System.Drawing.Color.Red;
            this.guna2GradientTileButton3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientTileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientTileButton3.Location = new System.Drawing.Point(857, 18);
            this.guna2GradientTileButton3.Name = "guna2GradientTileButton3";
            this.guna2GradientTileButton3.Size = new System.Drawing.Size(137, 52);
            this.guna2GradientTileButton3.TabIndex = 2;
            this.guna2GradientTileButton3.Text = "CANCEL";
            // 
            // guna2GradientTileButton2
            // 
            this.guna2GradientTileButton2.Animated = true;
            this.guna2GradientTileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientTileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientTileButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientTileButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientTileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientTileButton2.Location = new System.Drawing.Point(688, 17);
            this.guna2GradientTileButton2.Name = "guna2GradientTileButton2";
            this.guna2GradientTileButton2.Size = new System.Drawing.Size(137, 52);
            this.guna2GradientTileButton2.TabIndex = 4;
            this.guna2GradientTileButton2.Text = "PRINT";
            this.guna2GradientTileButton2.UseTransparentBackground = true;
            // 
            // guna2GradientTileButton4
            // 
            this.guna2GradientTileButton4.Animated = true;
            this.guna2GradientTileButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton4.FillColor = System.Drawing.Color.Aqua;
            this.guna2GradientTileButton4.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientTileButton4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientTileButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton4.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.guna2GradientTileButton4.Location = new System.Drawing.Point(506, 17);
            this.guna2GradientTileButton4.Name = "guna2GradientTileButton4";
            this.guna2GradientTileButton4.Size = new System.Drawing.Size(137, 52);
            this.guna2GradientTileButton4.TabIndex = 5;
            this.guna2GradientTileButton4.Text = "REPORT";
            this.guna2GradientTileButton4.Click += new System.EventHandler(this.guna2GradientTileButton4_Click);
            // 
            // guna2GradientTileButton5
            // 
            this.guna2GradientTileButton5.Animated = true;
            this.guna2GradientTileButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientTileButton5.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientTileButton5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.guna2GradientTileButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientTileButton5.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientTileButton5.Location = new System.Drawing.Point(330, 17);
            this.guna2GradientTileButton5.Name = "guna2GradientTileButton5";
            this.guna2GradientTileButton5.Size = new System.Drawing.Size(137, 52);
            this.guna2GradientTileButton5.TabIndex = 6;
            this.guna2GradientTileButton5.Text = "CHECK OUT";
            this.guna2GradientTileButton5.Click += new System.EventHandler(this.guna2GradientTileButton5_Click);
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 687);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_contentProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPOS";
            this.Text = "FormPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPOS_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label icon_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private System.Windows.Forms.Panel panel_contentProduct;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Pay;
        private ClassLibrary.lable_timeNow lable_timeNow1;
        private System.Windows.Forms.Label POS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton3;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton4;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton2;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton5;
    }
}