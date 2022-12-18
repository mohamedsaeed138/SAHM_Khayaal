﻿namespace Khayaal_SAHM.Main_Form_and_Children_Forms.Bills_Form_and_Mdi_Forms
{
    partial class Bills_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.From_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.To_Date_Picker = new System.Windows.Forms.DateTimePicker();
            this.Search_Serial_Number_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Total_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.From_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.To_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Count_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Count_Value_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Bills_Table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Serial_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Table_Croll_Bar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.Total_Search_Text_Box = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bills_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // From_Date_Picker
            // 
            this.From_Date_Picker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.From_Date_Picker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.From_Date_Picker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.From_Date_Picker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.From_Date_Picker.CustomFormat = "";
            this.From_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_Date_Picker.Location = new System.Drawing.Point(563, 59);
            this.From_Date_Picker.Margin = new System.Windows.Forms.Padding(2);
            this.From_Date_Picker.Name = "From_Date_Picker";
            this.From_Date_Picker.Size = new System.Drawing.Size(121, 20);
            this.From_Date_Picker.TabIndex = 7;
            this.From_Date_Picker.ValueChanged += new System.EventHandler(this.From_Date_Picker_ValueChanged);
            // 
            // To_Date_Picker
            // 
            this.To_Date_Picker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.To_Date_Picker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.To_Date_Picker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.To_Date_Picker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.To_Date_Picker.CustomFormat = "";
            this.To_Date_Picker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_Date_Picker.Location = new System.Drawing.Point(770, 59);
            this.To_Date_Picker.Margin = new System.Windows.Forms.Padding(2);
            this.To_Date_Picker.Name = "To_Date_Picker";
            this.To_Date_Picker.Size = new System.Drawing.Size(121, 20);
            this.To_Date_Picker.TabIndex = 8;
            this.To_Date_Picker.ValueChanged += new System.EventHandler(this.To_Date_Picker_ValueChanged);
            // 
            // Search_Serial_Number_Text_Box
            // 
            this.Search_Serial_Number_Text_Box.BorderRadius = 10;
            this.Search_Serial_Number_Text_Box.BorderThickness = 0;
            this.Search_Serial_Number_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_Serial_Number_Text_Box.DefaultText = "";
            this.Search_Serial_Number_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_Serial_Number_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_Serial_Number_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Serial_Number_Text_Box.DisabledState.Parent = this.Search_Serial_Number_Text_Box;
            this.Search_Serial_Number_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Serial_Number_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Search_Serial_Number_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Serial_Number_Text_Box.FocusedState.Parent = this.Search_Serial_Number_Text_Box;
            this.Search_Serial_Number_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Search_Serial_Number_Text_Box.HoverState.Parent = this.Search_Serial_Number_Text_Box;
            this.Search_Serial_Number_Text_Box.Location = new System.Drawing.Point(49, 43);
            this.Search_Serial_Number_Text_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Serial_Number_Text_Box.Name = "Search_Serial_Number_Text_Box";
            this.Search_Serial_Number_Text_Box.PasswordChar = '\0';
            this.Search_Serial_Number_Text_Box.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Search_Serial_Number_Text_Box.PlaceholderText = "Search";
            this.Search_Serial_Number_Text_Box.SelectedText = "";
            this.Search_Serial_Number_Text_Box.ShadowDecoration.Parent = this.Search_Serial_Number_Text_Box;
            this.Search_Serial_Number_Text_Box.Size = new System.Drawing.Size(264, 36);
            this.Search_Serial_Number_Text_Box.TabIndex = 9;
            this.Search_Serial_Number_Text_Box.TextChanged += new System.EventHandler(this.Search_Text_Box_TextChanged);
            this.Search_Serial_Number_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_Text_Box_KeyPress);
            // 
            // Total_Label
            // 
            this.Total_Label.BackColor = System.Drawing.Color.Transparent;
            this.Total_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Total_Label.Location = new System.Drawing.Point(352, 11);
            this.Total_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Total_Label.Name = "Total_Label";
            this.Total_Label.Size = new System.Drawing.Size(47, 27);
            this.Total_Label.TabIndex = 11;
            this.Total_Label.Text = "Total";
            // 
            // From_Label
            // 
            this.From_Label.BackColor = System.Drawing.Color.Transparent;
            this.From_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.From_Label.Location = new System.Drawing.Point(563, 11);
            this.From_Label.Margin = new System.Windows.Forms.Padding(2);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(46, 27);
            this.From_Label.TabIndex = 12;
            this.From_Label.Text = "From";
            // 
            // To_Label
            // 
            this.To_Label.BackColor = System.Drawing.Color.Transparent;
            this.To_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.To_Label.Location = new System.Drawing.Point(770, 11);
            this.To_Label.Margin = new System.Windows.Forms.Padding(2);
            this.To_Label.Name = "To_Label";
            this.To_Label.Size = new System.Drawing.Size(25, 27);
            this.To_Label.TabIndex = 13;
            this.To_Label.Text = "To";
            // 
            // Count_Label
            // 
            this.Count_Label.BackColor = System.Drawing.Color.Transparent;
            this.Count_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Count_Label.Location = new System.Drawing.Point(49, 543);
            this.Count_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Count_Label.Name = "Count_Label";
            this.Count_Label.Size = new System.Drawing.Size(64, 27);
            this.Count_Label.TabIndex = 14;
            this.Count_Label.Text = "Count : ";
            // 
            // Count_Value_Label
            // 
            this.Count_Value_Label.BackColor = System.Drawing.Color.Transparent;
            this.Count_Value_Label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Count_Value_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Count_Value_Label.Location = new System.Drawing.Point(117, 544);
            this.Count_Value_Label.Margin = new System.Windows.Forms.Padding(2);
            this.Count_Value_Label.Name = "Count_Value_Label";
            this.Count_Value_Label.Size = new System.Drawing.Size(3, 2);
            this.Count_Value_Label.TabIndex = 15;
            this.Count_Value_Label.Text = null;
            // 
            // Bills_Table
            // 
            this.Bills_Table.AllowUserToAddRows = false;
            this.Bills_Table.AllowUserToDeleteRows = false;
            this.Bills_Table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Bills_Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Bills_Table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bills_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Bills_Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Bills_Table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bills_Table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Bills_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bills_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Bills_Table.ColumnHeadersHeight = 48;
            this.Bills_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Bills_Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial_Number,
            this.Table_Number,
            this.Total_Cost,
            this.Column1,
            this.Print,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Bills_Table.DefaultCellStyle = dataGridViewCellStyle4;
            this.Bills_Table.EnableHeadersVisualStyles = false;
            this.Bills_Table.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Bills_Table.Location = new System.Drawing.Point(49, 100);
            this.Bills_Table.MultiSelect = false;
            this.Bills_Table.Name = "Bills_Table";
            this.Bills_Table.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(123)))), ((int)(((byte)(124)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Bills_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Bills_Table.RowHeadersVisible = false;
            this.Bills_Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Bills_Table.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Bills_Table.RowTemplate.Height = 37;
            this.Bills_Table.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Bills_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Bills_Table.Size = new System.Drawing.Size(875, 439);
            this.Bills_Table.TabIndex = 17;
            this.Bills_Table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Bills_Table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Bills_Table.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills_Table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Bills_Table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Bills_Table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Bills_Table.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Bills_Table.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.Bills_Table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(86)))), ((int)(((byte)(104)))));
            this.Bills_Table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Bills_Table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills_Table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Bills_Table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Bills_Table.ThemeStyle.HeaderStyle.Height = 48;
            this.Bills_Table.ThemeStyle.ReadOnly = true;
            this.Bills_Table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.Bills_Table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Bills_Table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Bills_Table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(158)))), ((int)(((byte)(163)))));
            this.Bills_Table.ThemeStyle.RowsStyle.Height = 37;
            this.Bills_Table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.Bills_Table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Bills_Table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Best_Seller_Table_RowsAdded);
            this.Bills_Table.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.Best_Seller_Table_RowsRemoved);
            // 
            // Serial_Number
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Serial_Number.DefaultCellStyle = dataGridViewCellStyle3;
            this.Serial_Number.HeaderText = "Serial Number";
            this.Serial_Number.Name = "Serial_Number";
            this.Serial_Number.ReadOnly = true;
            this.Serial_Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Table_Number
            // 
            this.Table_Number.HeaderText = "Cashier";
            this.Table_Number.Name = "Table_Number";
            this.Table_Number.ReadOnly = true;
            this.Table_Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Total_Cost
            // 
            this.Total_Cost.HeaderText = "Total Cost";
            this.Total_Cost.Name = "Total_Cost";
            this.Total_Cost.ReadOnly = true;
            this.Total_Cost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Print
            // 
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.HeaderText = "Print";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Text = "Print";
            this.Print.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Table_Croll_Bar
            // 
            this.Table_Croll_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Table_Croll_Bar.AutoRoundedCorners = true;
            this.Table_Croll_Bar.BorderRadius = 8;
            this.Table_Croll_Bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(123)))));
            this.Table_Croll_Bar.HoverState.Parent = null;
            this.Table_Croll_Bar.LargeChange = 10;
            this.Table_Croll_Bar.Location = new System.Drawing.Point(930, 151);
            this.Table_Croll_Bar.MouseWheelBarPartitions = 10;
            this.Table_Croll_Bar.Name = "Table_Croll_Bar";
            this.Table_Croll_Bar.PressedState.Parent = this.Table_Croll_Bar;
            this.Table_Croll_Bar.ScrollbarSize = 18;
            this.Table_Croll_Bar.Size = new System.Drawing.Size(18, 388);
            this.Table_Croll_Bar.TabIndex = 18;
            this.Table_Croll_Bar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(88)))), ((int)(((byte)(95)))));
            this.Table_Croll_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Table_Croll_Bar_Scroll);
            // 
            // Total_Search_Text_Box
            // 
            this.Total_Search_Text_Box.BorderRadius = 10;
            this.Total_Search_Text_Box.BorderThickness = 0;
            this.Total_Search_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Total_Search_Text_Box.DefaultText = "";
            this.Total_Search_Text_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Total_Search_Text_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Total_Search_Text_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total_Search_Text_Box.DisabledState.Parent = this.Total_Search_Text_Box;
            this.Total_Search_Text_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total_Search_Text_Box.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(52)))), ((int)(((byte)(67)))));
            this.Total_Search_Text_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total_Search_Text_Box.FocusedState.Parent = this.Total_Search_Text_Box;
            this.Total_Search_Text_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total_Search_Text_Box.HoverState.Parent = this.Total_Search_Text_Box;
            this.Total_Search_Text_Box.Location = new System.Drawing.Point(352, 44);
            this.Total_Search_Text_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Total_Search_Text_Box.Name = "Total_Search_Text_Box";
            this.Total_Search_Text_Box.PasswordChar = '\0';
            this.Total_Search_Text_Box.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Total_Search_Text_Box.PlaceholderText = "< = Total";
            this.Total_Search_Text_Box.SelectedText = "";
            this.Total_Search_Text_Box.ShadowDecoration.Parent = this.Total_Search_Text_Box;
            this.Total_Search_Text_Box.Size = new System.Drawing.Size(131, 36);
            this.Total_Search_Text_Box.TabIndex = 23;
            this.Total_Search_Text_Box.TextChanged += new System.EventHandler(this.Total_Search_Text_Box_TextChanged);
            this.Total_Search_Text_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Total_Search_Text_Box_KeyPress);
            // 
            // Bills_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(974, 581);
            this.Controls.Add(this.Total_Search_Text_Box);
            this.Controls.Add(this.Table_Croll_Bar);
            this.Controls.Add(this.Bills_Table);
            this.Controls.Add(this.Count_Value_Label);
            this.Controls.Add(this.Count_Label);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.Total_Label);
            this.Controls.Add(this.Search_Serial_Number_Text_Box);
            this.Controls.Add(this.To_Date_Picker);
            this.Controls.Add(this.From_Date_Picker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bills_Form";
            this.Text = "Best_Seller_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Bills_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker From_Date_Picker;
        private System.Windows.Forms.DateTimePicker To_Date_Picker;
        private Guna.UI2.WinForms.Guna2TextBox Search_Serial_Number_Text_Box;
        private Guna.UI2.WinForms.Guna2HtmlLabel Total_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel From_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel To_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Count_Label;
        private Guna.UI2.WinForms.Guna2HtmlLabel Count_Value_Label;
        private Guna.UI2.WinForms.Guna2DataGridView Bills_Table;
        private Guna.UI2.WinForms.Guna2VScrollBar Table_Croll_Bar;
        private Guna.UI2.WinForms.Guna2TextBox Total_Search_Text_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}