namespace ElectroHouseProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgTab = new System.Windows.Forms.DataGridView();
            this.ColNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubCategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Set = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_QuatityProdName = new System.Windows.Forms.Label();
            this.lbl_QuatityStore = new System.Windows.Forms.Label();
            this.lbl_QuatityCity = new System.Windows.Forms.Label();
            this.gb_Filter = new System.Windows.Forms.GroupBox();
            this.cb_City = new System.Windows.Forms.ComboBox();
            this.lbl_FilCity = new System.Windows.Forms.Label();
            this.cb_Store = new System.Windows.Forms.ComboBox();
            this.lbl_FilStore = new System.Windows.Forms.Label();
            this.lbl_endOfTrackbar = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.lbl_StartTrackbar = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.cb_subcategory = new System.Windows.Forms.ComboBox();
            this.lbl_SubCategory = new System.Windows.Forms.Label();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTab)).BeginInit();
            this.gb_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTab
            // 
            this.dgTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumber,
            this.CategoryCol,
            this.SubCategoryCol,
            this.ColProdName,
            this.ColQuantity,
            this.ColPrice,
            this.ColStore,
            this.ColCity});
            this.dgTab.Location = new System.Drawing.Point(12, 12);
            this.dgTab.Name = "dgTab";
            this.dgTab.RowHeadersVisible = false;
            this.dgTab.RowTemplate.Height = 24;
            this.dgTab.Size = new System.Drawing.Size(1483, 395);
            this.dgTab.TabIndex = 0;
            this.dgTab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColNumber
            // 
            this.ColNumber.HeaderText = "№";
            this.ColNumber.Name = "ColNumber";
            this.ColNumber.ReadOnly = true;
            this.ColNumber.Width = 30;
            // 
            // CategoryCol
            // 
            this.CategoryCol.HeaderText = "Категория";
            this.CategoryCol.Name = "CategoryCol";
            this.CategoryCol.ReadOnly = true;
            this.CategoryCol.Width = 130;
            // 
            // SubCategoryCol
            // 
            this.SubCategoryCol.HeaderText = "Подкатегория";
            this.SubCategoryCol.Name = "SubCategoryCol";
            this.SubCategoryCol.ReadOnly = true;
            this.SubCategoryCol.Width = 150;
            // 
            // ColProdName
            // 
            this.ColProdName.HeaderText = "Название продукта";
            this.ColProdName.Name = "ColProdName";
            this.ColProdName.ReadOnly = true;
            this.ColProdName.Width = 320;
            // 
            // ColQuantity
            // 
            this.ColQuantity.HeaderText = "Количество";
            this.ColQuantity.Name = "ColQuantity";
            this.ColQuantity.ReadOnly = true;
            // 
            // ColPrice
            // 
            this.ColPrice.HeaderText = "Цена";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            this.ColPrice.Width = 90;
            // 
            // ColStore
            // 
            this.ColStore.HeaderText = "Магазин";
            this.ColStore.Name = "ColStore";
            this.ColStore.ReadOnly = true;
            this.ColStore.Width = 120;
            // 
            // ColCity
            // 
            this.ColCity.HeaderText = "Город";
            this.ColCity.Name = "ColCity";
            this.ColCity.ReadOnly = true;
            this.ColCity.Width = 150;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1369, 579);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(127, 44);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Выход";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Set
            // 
            this.btn_Set.Location = new System.Drawing.Point(1368, 427);
            this.btn_Set.Name = "btn_Set";
            this.btn_Set.Size = new System.Drawing.Size(127, 44);
            this.btn_Set.TabIndex = 2;
            this.btn_Set.Text = "Установить";
            this.btn_Set.UseVisualStyleBackColor = true;
            this.btn_Set.Click += new System.EventHandler(this.btn_Set_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(1369, 529);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(127, 44);
            this.btn_Print.TabIndex = 3;
            this.btn_Print.Text = "Печать";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(1369, 477);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(127, 44);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Снять";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_QuatityProdName
            // 
            this.lbl_QuatityProdName.AutoSize = true;
            this.lbl_QuatityProdName.Location = new System.Drawing.Point(383, 427);
            this.lbl_QuatityProdName.Name = "lbl_QuatityProdName";
            this.lbl_QuatityProdName.Size = new System.Drawing.Size(16, 17);
            this.lbl_QuatityProdName.TabIndex = 5;
            this.lbl_QuatityProdName.Text = "0";
            // 
            // lbl_QuatityStore
            // 
            this.lbl_QuatityStore.AutoSize = true;
            this.lbl_QuatityStore.Location = new System.Drawing.Point(885, 427);
            this.lbl_QuatityStore.Name = "lbl_QuatityStore";
            this.lbl_QuatityStore.Size = new System.Drawing.Size(16, 17);
            this.lbl_QuatityStore.TabIndex = 8;
            this.lbl_QuatityStore.Text = "0";
            // 
            // lbl_QuatityCity
            // 
            this.lbl_QuatityCity.AutoSize = true;
            this.lbl_QuatityCity.Location = new System.Drawing.Point(1005, 427);
            this.lbl_QuatityCity.Name = "lbl_QuatityCity";
            this.lbl_QuatityCity.Size = new System.Drawing.Size(16, 17);
            this.lbl_QuatityCity.TabIndex = 10;
            this.lbl_QuatityCity.Text = "0";
            // 
            // gb_Filter
            // 
            this.gb_Filter.Controls.Add(this.cb_City);
            this.gb_Filter.Controls.Add(this.lbl_FilCity);
            this.gb_Filter.Controls.Add(this.cb_Store);
            this.gb_Filter.Controls.Add(this.lbl_FilStore);
            this.gb_Filter.Controls.Add(this.lbl_endOfTrackbar);
            this.gb_Filter.Controls.Add(this.lbl_Price);
            this.gb_Filter.Controls.Add(this.lbl_StartTrackbar);
            this.gb_Filter.Controls.Add(this.trackBar1);
            this.gb_Filter.Controls.Add(this.cb_subcategory);
            this.gb_Filter.Controls.Add(this.lbl_SubCategory);
            this.gb_Filter.Controls.Add(this.cb_category);
            this.gb_Filter.Controls.Add(this.lbl_Category);
            this.gb_Filter.Location = new System.Drawing.Point(12, 457);
            this.gb_Filter.Name = "gb_Filter";
            this.gb_Filter.Size = new System.Drawing.Size(1350, 152);
            this.gb_Filter.TabIndex = 11;
            this.gb_Filter.TabStop = false;
            this.gb_Filter.Text = "Фильтр";
            // 
            // cb_City
            // 
            this.cb_City.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_City.FormattingEnabled = true;
            this.cb_City.Location = new System.Drawing.Point(1223, 36);
            this.cb_City.Name = "cb_City";
            this.cb_City.Size = new System.Drawing.Size(121, 24);
            this.cb_City.TabIndex = 11;
            // 
            // lbl_FilCity
            // 
            this.lbl_FilCity.AutoSize = true;
            this.lbl_FilCity.Location = new System.Drawing.Point(1169, 40);
            this.lbl_FilCity.Name = "lbl_FilCity";
            this.lbl_FilCity.Size = new System.Drawing.Size(48, 17);
            this.lbl_FilCity.TabIndex = 10;
            this.lbl_FilCity.Text = "Город";
            // 
            // cb_Store
            // 
            this.cb_Store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_Store.FormattingEnabled = true;
            this.cb_Store.Location = new System.Drawing.Point(1042, 37);
            this.cb_Store.Name = "cb_Store";
            this.cb_Store.Size = new System.Drawing.Size(121, 24);
            this.cb_Store.TabIndex = 9;
            // 
            // lbl_FilStore
            // 
            this.lbl_FilStore.AutoSize = true;
            this.lbl_FilStore.Location = new System.Drawing.Point(973, 40);
            this.lbl_FilStore.Name = "lbl_FilStore";
            this.lbl_FilStore.Size = new System.Drawing.Size(63, 17);
            this.lbl_FilStore.TabIndex = 8;
            this.lbl_FilStore.Text = "Магазин";
            // 
            // lbl_endOfTrackbar
            // 
            this.lbl_endOfTrackbar.AutoSize = true;
            this.lbl_endOfTrackbar.Location = new System.Drawing.Point(895, 40);
            this.lbl_endOfTrackbar.Name = "lbl_endOfTrackbar";
            this.lbl_endOfTrackbar.Size = new System.Drawing.Size(72, 17);
            this.lbl_endOfTrackbar.TabIndex = 7;
            this.lbl_endOfTrackbar.Text = "10000000";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(598, 39);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(43, 17);
            this.lbl_Price.TabIndex = 6;
            this.lbl_Price.Text = "Цена";
            // 
            // lbl_StartTrackbar
            // 
            this.lbl_StartTrackbar.AutoSize = true;
            this.lbl_StartTrackbar.Location = new System.Drawing.Point(646, 40);
            this.lbl_StartTrackbar.Name = "lbl_StartTrackbar";
            this.lbl_StartTrackbar.Size = new System.Drawing.Size(16, 17);
            this.lbl_StartTrackbar.TabIndex = 5;
            this.lbl_StartTrackbar.Text = "0";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(668, 33);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(221, 56);
            this.trackBar1.TabIndex = 4;
            // 
            // cb_subcategory
            // 
            this.cb_subcategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_subcategory.FormattingEnabled = true;
            this.cb_subcategory.Location = new System.Drawing.Point(374, 33);
            this.cb_subcategory.Name = "cb_subcategory";
            this.cb_subcategory.Size = new System.Drawing.Size(201, 24);
            this.cb_subcategory.TabIndex = 3;
            // 
            // lbl_SubCategory
            // 
            this.lbl_SubCategory.AutoSize = true;
            this.lbl_SubCategory.Location = new System.Drawing.Point(267, 36);
            this.lbl_SubCategory.Name = "lbl_SubCategory";
            this.lbl_SubCategory.Size = new System.Drawing.Size(101, 17);
            this.lbl_SubCategory.TabIndex = 2;
            this.lbl_SubCategory.Text = "Подкатегория";
            // 
            // cb_category
            // 
            this.cb_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(92, 33);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(169, 24);
            this.cb_category.TabIndex = 1;
            this.cb_category.SelectedIndexChanged += new System.EventHandler(this.cb_category_SelectedIndexChanged);
            this.cb_category.TextChanged += new System.EventHandler(this.cb_category_TextChanged);
            // 
            // lbl_Category
            // 
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(9, 33);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(77, 17);
            this.lbl_Category.TabIndex = 0;
            this.lbl_Category.Text = "Категория";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 653);
            this.Controls.Add(this.gb_Filter);
            this.Controls.Add(this.lbl_QuatityCity);
            this.Controls.Add(this.lbl_QuatityStore);
            this.Controls.Add(this.lbl_QuatityProdName);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Set);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.dgTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBshop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTab)).EndInit();
            this.gb_Filter.ResumeLayout(false);
            this.gb_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTab;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Set;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_QuatityProdName;
        private System.Windows.Forms.Label lbl_QuatityStore;
        private System.Windows.Forms.Label lbl_QuatityCity;
        private System.Windows.Forms.GroupBox gb_Filter;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ComboBox cb_subcategory;
        private System.Windows.Forms.Label lbl_SubCategory;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.Label lbl_StartTrackbar;
        private System.Windows.Forms.ComboBox cb_City;
        private System.Windows.Forms.Label lbl_FilCity;
        private System.Windows.Forms.ComboBox cb_Store;
        private System.Windows.Forms.Label lbl_FilStore;
        private System.Windows.Forms.Label lbl_endOfTrackbar;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubCategoryCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCity;
    }
}

