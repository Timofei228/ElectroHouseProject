using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroHouseProject
{
    public partial class Form1 : Form
    {
        public static string connectionData = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Dbshop.mdb";
        private OleDbConnection connection;
        private OleDbDataAdapter dataadapter, daStore, daCity, daCategory, daSubCategory;

        string gl = " FROM Products, ListofGoods, Store, City, Category, SubCategory ";
        string polya = "SELECT ";
        string categoryName = "Category.CategoryName ";
        string subCategoryName = ",SubCategory.SubCategoryName";
        string prodName = ",Products.ProductName";
        string quantity = ",ListofGoods.Quantity";
        string price = ",ListofGoods.Price";
        string store = ",Store.StoreName ";
        string city = ",City.CityName";
        string wh = " WHERE ";
        string sort = " ORDER BY Products.IDproduct";
        public List<string> uniqueSubCategoryList = new List<string>();
        DataTable subcategoryTab = new DataTable();
        bool flagSubCategory = false;

        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionData);
            connection.Open();       
        }

       

        

        private string GetMainZapros()
        {
            string mainZapros = "SELECT Category.CategoryName, SubCategory.SubCategoryName, Products.ProductName, ListofGoods.Quantity, ListofGoods.Price, Store.StoreName, City.CityName " +
                "FROM(Category INNER JOIN SubCategory ON Category.IDCategory = SubCategory.NumCategory)" +
                " INNER JOIN((City INNER JOIN Store ON City.IDcity = Store.NumCity) " +
                "INNER JOIN(Products INNER JOIN ListofGoods ON Products.IDproduct = ListofGoods.NumProduct) ON Store.IDstore = ListofGoods.NumStore) ON SubCategory.IDsubcategory = Products.NumSubCategory ";
            return mainZapros;
        }

              

        private void printZapros(string zapros)
        {
            OleDbCommand datacom = new OleDbCommand(zapros, connection);
            OleDbDataReader dataReader = datacom.ExecuteReader();
            int i = 1;
            int prodCount = 0;

            List<string[]> data = new List<string[]>();
            while (dataReader.Read())
            {
                dgTab.Rows.Add(
                    i.ToString(), dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(),
                    dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());
               
                i++;
                prodCount++;
            }
            //counter(cb_Store.Items.Count.ToString(), prodCount.ToString(), cb_City.Items.Count.ToString());
            dataReader.Close();
            dgTab.ReadOnly = true;
            //Заполнение таблицы
            foreach (string[] s in data)
            {
                dgTab.Rows.Add(s);
            }
            
        }

       

        private void btn_Set_Click(object sender, EventArgs e)
        {
            dgTab.Rows.Clear();                      
            var mainZapros = GetMainZapros();
            mainZapros += wh;
            lbl_QuatityStore.Text = cb_category.SelectedValue.ToString();

            if (cb_category.Text == "" && cb_subcategory.Text == "" && cb_City.Text == "")//store
            {
                mainZapros += cb_Store.SelectedValue + " = NumStore ";
            }
            if (cb_category.Text == "" && cb_Store.Text == "" && cb_City.Text == "")//subcategory
            {
                mainZapros += cb_subcategory.SelectedValue + " =NumSubCategory ";
            }
            if (cb_category.Text == "" && cb_Store.Text == "" && cb_subcategory.Text == "")//city
            {
                mainZapros += cb_City.SelectedValue + " = NumCity ";
            }

          
            if (cb_category.Text != "")
            {
                mainZapros += cb_category.SelectedValue + " =NumCategory ";
            }
            if (cb_subcategory.Text != "")
            {
                mainZapros += " AND " + cb_subcategory.SelectedValue + " =NumSubCategory ";
            }

            if (cb_Store.Text != "")
            {

                mainZapros += " AND " + cb_Store.SelectedValue + " = NumStore ";
            }
            if (cb_City.Text != "")
            {
                mainZapros += " AND " + cb_City.SelectedValue + " = NumCity ";
            }
               
            
            mainZapros += sort;
            printZapros(mainZapros);


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgTab.Rows.Clear();
            cb_category.Text = "";
            cb_City.Text = "";
            cb_Store.Text = "";
            cb_subcategory.Text = "";
            FillGrid();
            
           
        }

       

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void cb_category_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void counter(string store, string products, string cities)//счетчик под грид сеткой
        {
            lbl_QuatityStore.Text = store;
            lbl_QuatityProdName.Text = products;
            lbl_QuatityCity.Text = cities;


        }
        private void FillGrid()
        {
            var gridZapros = GetMainZapros();
            printZapros(gridZapros);
            
           
        }
        private void FillComboBoxes()
        {
            string stores = "SELECT DISTINCT IDstore, StoreName FROM Store";
            daStore = new OleDbDataAdapter(stores, connection);
            DataTable tbl = new DataTable();
            daStore.Fill(tbl);
            
            cb_Store.DisplayMember = "StoreName";
            cb_Store.ValueMember = "IDstore";
            cb_Store.DataSource = tbl;
            cb_Store.SelectedIndex = -1;


            string cityCon = "SELECT DISTINCT IDcity, CityName FROM City";
            daCity = new OleDbDataAdapter(cityCon, connection);
            DataTable cityTab = new DataTable();
            daCity.Fill(cityTab);
            
            cb_City.DisplayMember = "CityName";
            cb_City.ValueMember = "IDcity";
            cb_City.DataSource = cityTab;
            cb_City.SelectedIndex = -1;


            string categoryCon = "SELECT DISTINCT IDCategory, CategoryName FROM Category";
            daCategory = new OleDbDataAdapter(categoryCon, connection);
            DataTable categoryTab = new DataTable();
            daCategory.Fill(categoryTab);
            cb_category.DisplayMember = "CategoryName";
            cb_category.ValueMember = "IDCategory";
            cb_category.DataSource = categoryTab;
            //cb_category.SelectedIndex = -1;


            string subCategoryCon = "SELECT DISTINCT IDsubcategory, SubCategoryName FROM SubCategory";
            daSubCategory = new OleDbDataAdapter(subCategoryCon, connection);
            
            daSubCategory.Fill(subcategoryTab);

            
            cb_subcategory.DisplayMember = "SubCategoryName";
            cb_subcategory.ValueMember = "IDsubcategory";
            cb_subcategory.DataSource = subcategoryTab;
            //cb_subcategory.SelectedIndex = -1;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FillGrid();
            FillComboBoxes();
            cb_subcategory.Text = "";
            cb_category.Text = "";
            
        }

        private void cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* 
            cb_subcategory.DataSource = null;
            cb_subcategory.Items.Clear();
            uniqueSubCategoryList = new List<string>();
            string zapros = GetMainZapros();
            zapros += wh + cb_category.SelectedValue + "=NumCategory ";
            OleDbCommand command = new OleDbCommand(zapros, connection);
            var reader = command.ExecuteReader();
           
            while (reader.Read())
            {
               uniqueSubCategoryList.Add(reader[1].ToString());
            }

            uniqueSubCategoryList = uniqueSubCategoryList.Distinct().ToList();
            cb_subcategory.Items.AddRange(uniqueSubCategoryList.ToArray());
            */
    


        }

    }
}
