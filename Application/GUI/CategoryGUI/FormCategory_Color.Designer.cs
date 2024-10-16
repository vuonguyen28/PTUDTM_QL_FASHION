﻿namespace GUI.CategoryGUI
{
    partial class FormCategory_Color
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory_Color));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.DataGridView_Data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_HexcodeColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_hexcodeColor = new System.Windows.Forms.Label();
            this.textBox_MaDanhMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_TenDanhMuc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_TenDanhMuc = new System.Windows.Forms.Label();
            this.label_MaDanhMuc = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_create = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Data)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Search
            // 
            this.textBox_Search.Animated = true;
            this.textBox_Search.AutoRoundedCorners = true;
            this.textBox_Search.BorderColor = System.Drawing.Color.Red;
            this.textBox_Search.BorderRadius = 18;
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
            this.textBox_Search.Location = new System.Drawing.Point(70, 60);
            this.textBox_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.PasswordChar = '\0';
            this.textBox_Search.PlaceholderText = "";
            this.textBox_Search.SelectedText = "";
            this.textBox_Search.ShadowDecoration.BorderRadius = 30;
            this.textBox_Search.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.textBox_Search.Size = new System.Drawing.Size(568, 39);
            this.textBox_Search.TabIndex = 19;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2ShadowPanel1.Controls.Add(this.DataGridView_Data);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(70, 130);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(568, 489);
            this.guna2ShadowPanel1.TabIndex = 18;
            // 
            // DataGridView_Data
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView_Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Data.ColumnHeadersHeight = 40;
            this.DataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Data.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Data.Location = new System.Drawing.Point(4, 4);
            this.DataGridView_Data.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView_Data.Name = "DataGridView_Data";
            this.DataGridView_Data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Data.RowHeadersVisible = false;
            this.DataGridView_Data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DataGridView_Data.Size = new System.Drawing.Size(560, 481);
            this.DataGridView_Data.TabIndex = 0;
            this.DataGridView_Data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView_Data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView_Data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView_Data.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Data.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView_Data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView_Data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DataGridView_Data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView_Data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView_Data.ThemeStyle.HeaderStyle.Height = 40;
            this.DataGridView_Data.ThemeStyle.ReadOnly = false;
            this.DataGridView_Data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView_Data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView_Data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DataGridView_Data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView_Data.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridView_Data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView_Data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_HexcodeColor);
            this.panel1.Controls.Add(this.label_hexcodeColor);
            this.panel1.Controls.Add(this.textBox_MaDanhMuc);
            this.panel1.Controls.Add(this.textBox_TenDanhMuc);
            this.panel1.Controls.Add(this.label_TenDanhMuc);
            this.panel1.Controls.Add(this.label_MaDanhMuc);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Location = new System.Drawing.Point(680, 132);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 489);
            this.panel1.TabIndex = 17;
            // 
            // txt_HexcodeColor
            // 
            this.txt_HexcodeColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HexcodeColor.DefaultText = "";
            this.txt_HexcodeColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_HexcodeColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_HexcodeColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HexcodeColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HexcodeColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HexcodeColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HexcodeColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HexcodeColor.Location = new System.Drawing.Point(0, 204);
            this.txt_HexcodeColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_HexcodeColor.Name = "txt_HexcodeColor";
            this.txt_HexcodeColor.PasswordChar = '\0';
            this.txt_HexcodeColor.PlaceholderText = "";
            this.txt_HexcodeColor.SelectedText = "";
            this.txt_HexcodeColor.Size = new System.Drawing.Size(579, 39);
            this.txt_HexcodeColor.TabIndex = 10;
            // 
            // label_hexcodeColor
            // 
            this.label_hexcodeColor.AutoSize = true;
            this.label_hexcodeColor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hexcodeColor.Location = new System.Drawing.Point(4, 185);
            this.label_hexcodeColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_hexcodeColor.Name = "label_hexcodeColor";
            this.label_hexcodeColor.Size = new System.Drawing.Size(80, 17);
            this.label_hexcodeColor.TabIndex = 9;
            this.label_hexcodeColor.Text = "Hexcode:";
            // 
            // textBox_MaDanhMuc
            // 
            this.textBox_MaDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_MaDanhMuc.DefaultText = "";
            this.textBox_MaDanhMuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_MaDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_MaDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_MaDanhMuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_MaDanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_MaDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_MaDanhMuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_MaDanhMuc.Location = new System.Drawing.Point(0, 52);
            this.textBox_MaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_MaDanhMuc.Name = "textBox_MaDanhMuc";
            this.textBox_MaDanhMuc.PasswordChar = '\0';
            this.textBox_MaDanhMuc.PlaceholderText = "";
            this.textBox_MaDanhMuc.SelectedText = "";
            this.textBox_MaDanhMuc.Size = new System.Drawing.Size(579, 39);
            this.textBox_MaDanhMuc.TabIndex = 4;
            // 
            // textBox_TenDanhMuc
            // 
            this.textBox_TenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_TenDanhMuc.DefaultText = "";
            this.textBox_TenDanhMuc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_TenDanhMuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_TenDanhMuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_TenDanhMuc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_TenDanhMuc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_TenDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_TenDanhMuc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_TenDanhMuc.Location = new System.Drawing.Point(0, 127);
            this.textBox_TenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenDanhMuc.Name = "textBox_TenDanhMuc";
            this.textBox_TenDanhMuc.PasswordChar = '\0';
            this.textBox_TenDanhMuc.PlaceholderText = "";
            this.textBox_TenDanhMuc.SelectedText = "";
            this.textBox_TenDanhMuc.Size = new System.Drawing.Size(579, 39);
            this.textBox_TenDanhMuc.TabIndex = 3;
            // 
            // label_TenDanhMuc
            // 
            this.label_TenDanhMuc.AutoSize = true;
            this.label_TenDanhMuc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenDanhMuc.Location = new System.Drawing.Point(4, 107);
            this.label_TenDanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenDanhMuc.Name = "label_TenDanhMuc";
            this.label_TenDanhMuc.Size = new System.Drawing.Size(124, 17);
            this.label_TenDanhMuc.TabIndex = 1;
            this.label_TenDanhMuc.Text = "Tên Danh Mục:";
            // 
            // label_MaDanhMuc
            // 
            this.label_MaDanhMuc.AutoSize = true;
            this.label_MaDanhMuc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MaDanhMuc.Location = new System.Drawing.Point(4, 32);
            this.label_MaDanhMuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaDanhMuc.Name = "label_MaDanhMuc";
            this.label_MaDanhMuc.Size = new System.Drawing.Size(117, 17);
            this.label_MaDanhMuc.TabIndex = 0;
            this.label_MaDanhMuc.Text = "Mã Danh Mục:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.Teal;
            this.btn_save.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_save.Location = new System.Drawing.Point(215, 284);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(131, 41);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "SAVE";
            this.btn_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_delete.Location = new System.Drawing.Point(1121, 60);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(139, 41);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.Teal;
            this.btn_update.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_update.Location = new System.Drawing.Point(912, 60);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(139, 41);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "UPDATE";
            this.btn_update.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.Transparent;
            this.btn_create.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_create.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_create.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_create.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_create.FillColor = System.Drawing.Color.Teal;
            this.btn_create.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Image = ((System.Drawing.Image)(resources.GetObject("btn_create.Image")));
            this.btn_create.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_create.Location = new System.Drawing.Point(681, 60);
            this.btn_create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(139, 41);
            this.btn_create.TabIndex = 14;
            this.btn_create.Text = "CREATE";
            this.btn_create.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // FormCategory_Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 681);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_create);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategory_Color";
            this.Text = "FormCategory_Color";
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Data)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox textBox_Search;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView_Data;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_HexcodeColor;
        private System.Windows.Forms.Label label_hexcodeColor;
        private Guna.UI2.WinForms.Guna2TextBox textBox_MaDanhMuc;
        private Guna.UI2.WinForms.Guna2TextBox textBox_TenDanhMuc;
        private System.Windows.Forms.Label label_TenDanhMuc;
        private System.Windows.Forms.Label label_MaDanhMuc;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_create;
    }
}