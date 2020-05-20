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
        
        public List<string> uniqueSubCategoryList = new List<string>();
        public List<string> uniqueCategoryList = new List<string>();
        public List<string> uniqueStoreList = new List<string>();
        public List<string> uniqueCityList = new List<string>();

       
       

        public Form1()
        {
            InitializeComponent();
            connection = new OleDbConnection(connectionData);
            connection.Open();           
            FillGrid();
            FillComboBoxes();

        }
        
        private string GetMainZapros()
        {
            string mainZapros = "SELECT Category.CategoryName, SubCategory.SubCategoryName, Products.ProductName, ListofGoods.Quantity, ListofGoods.Price, Store.StoreName, City.CityName " +
                "FROM(Category INNER JOIN SubCategory ON Category.IDCategory = SubCategory.NumCategory)" +
                " INNER JOIN((City INNER JOIN Store ON City.IDcity = Store.NumCity) " +
                "INNER JOIN(Products INNER JOIN ListofGoods ON Products.IDproduct = ListofGoods.NumProduct) ON Store.IDstore = ListofGoods.NumStore) ON SubCategory.IDsubcategory = Products.NumSubCategory ";

            var where = " WHERE ";

            var mainQuery = mainZapros;
            if (!AreFiltersClear())
            {
                mainQuery += where + FiltersQuery();
            }
            return mainQuery;
        }

        private bool AreFiltersClear()
        {
            bool areCleared = true;
            if (cb_category.Text != "" || cb_subcategory.Text != "" || cb_City.Text != "" || cb_Store.Text != "")
            {
                areCleared = false;
            }
            return areCleared;
        }

        private string FiltersQuery()
        {
            var listFilters = new List<ComboBox>();

            listFilters.Add(cb_category);
            listFilters.Add(cb_subcategory);
            listFilters.Add(cb_Store);
            listFilters.Add(cb_City);

            var listFilledFilters = new List<ComboBox>();
            int countFilledFilters;

            for (int i = 0; i < listFilters.Count; i++)
            {
                if (listFilters[i].Text != "")
                {
                    listFilledFilters.Add(listFilters[i]);
                }
            }
            countFilledFilters = listFilledFilters.Count;

            if (!AreFiltersClear())
            {
                string query = "";
                if (cb_category.Text != "")
                {
                    var categoryID = 0;

                    if (cb_category.SelectedIndex > 0)
                    {
                        categoryID = cb_category.SelectedIndex;
                    }
                    
                    query += $"CategoryName = '{uniqueCategoryList[categoryID]}' ";
                    countFilledFilters--;
                    if (countFilledFilters > 0)
                        query += "AND ";
                }
                if (cb_subcategory.Text != "")
                {
                    var subCategoryID = 0;

                    if (cb_subcategory.SelectedIndex > 0)
                    {
                        subCategoryID = cb_subcategory.SelectedIndex;
                    }
                    query += $"SubCategoryName = '{uniqueSubCategoryList[subCategoryID]}' ";
                    countFilledFilters--;
                    if (countFilledFilters > 0)
                        query += "AND ";
                }
                if (cb_Store.Text != "")
                {
                    var storeID = 0;

                    if (cb_Store.SelectedIndex > 0)
                    {
                        storeID = cb_Store.SelectedIndex;
                    }

                    query += $"StoreName = '{uniqueStoreList[storeID]}' ";
                    countFilledFilters--;
                    if (countFilledFilters > 0)
                        query += "AND ";
                }
                if (cb_City.Text != "")
                {
                    var cityID = 0;

                    if (cb_City.SelectedIndex > 0)
                    {
                        cityID = cb_City.SelectedIndex;
                    }
                    query += $"CityName = '{uniqueCityList[cityID]}' ";
                    countFilledFilters--;
                    if (countFilledFilters > 0)
                        query += "AND ";
                }
                return query;
            }
            return "";
        }
              

        private void ClearComboBoxes()
        {
            cb_category.Text = "";
            cb_subcategory.Text = "";
            cb_Store.Text = "";
            cb_City.Text = "";

            cb_category.Items.Clear();
            cb_subcategory.Items.Clear();
            cb_Store.Items.Clear();
            cb_City.Items.Clear();

            uniqueCategoryList = new List<string>();
            uniqueSubCategoryList = new List<string>();
            uniqueStoreList = new List<string>();
            uniqueCityList = new List<string>();
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            dgTab.Rows.Clear();
            FillGrid();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dgTab.Rows.Clear();
            ClearComboBoxes();
            FillGrid();
            FillComboBoxes();
            

        }

       

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void counter(string store, string cities)//счетчик под грид сеткой
        {
            lbl_QuatityStore.Text = store;
            lbl_QuatityCity.Text = cities;
        }

        private void cb_category_TextChanged(object sender, EventArgs e)
        {
            string mainQuery = GetMainZapros();
            cb_subcategory.Items.Clear();
            cb_Store.Items.Clear();
            cb_City.Items.Clear();

            uniqueSubCategoryList = new List<string>();
            uniqueStoreList = new List<string>();
            uniqueCityList = new List<string>();

            
            OleDbCommand command = new OleDbCommand(mainQuery, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                uniqueSubCategoryList.Add(reader[1].ToString());
                uniqueStoreList.Add(reader[5].ToString());
                uniqueCityList.Add(reader[6].ToString());
            }
            uniqueSubCategoryList = uniqueSubCategoryList.Distinct().ToList();
            uniqueStoreList = uniqueStoreList.Distinct().ToList();
            uniqueCityList = uniqueCityList.Distinct().ToList();

            cb_subcategory.Items.AddRange(uniqueSubCategoryList.ToArray());
            cb_Store.Items.AddRange(uniqueStoreList.ToArray());
            cb_City.Items.AddRange(uniqueCityList.ToArray());
            
            counter(cb_Store.Items.Count.ToString(), cb_City.Items.Count.ToString());
            

            
        }

       

        private void cb_subcategory_TextChanged(object sender, EventArgs e)
        {
            string mainQuery = GetMainZapros();
            cb_category.Items.Clear();
            cb_City.Items.Clear();          
            cb_Store.Items.Clear();

            uniqueCategoryList = new List<string>();
            uniqueCityList = new List<string>();
            uniqueStoreList = new List<string>();

            

            OleDbCommand command = new OleDbCommand(mainQuery, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                uniqueCategoryList.Add(reader[0].ToString());
                uniqueStoreList.Add(reader[5].ToString());
                uniqueCityList.Add(reader[6].ToString());
            }

            uniqueCategoryList = uniqueCategoryList.Distinct().ToList();
            uniqueCityList = uniqueCityList.Distinct().ToList();
            uniqueStoreList = uniqueStoreList.Distinct().ToList();

            cb_category.Items.AddRange(uniqueCategoryList.ToArray());
            cb_City.Items.AddRange(uniqueCityList.ToArray());
            cb_Store.Items.AddRange(uniqueStoreList.ToArray());

            counter(cb_Store.Items.Count.ToString(), cb_City.Items.Count.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            counter(cb_Store.Items.Count.ToString(), cb_City.Items.Count.ToString());
        }

        private void cb_Store_TextChanged(object sender, EventArgs e)
        {
            string mainQuery = GetMainZapros();
            cb_category.Items.Clear();
            cb_subcategory.Items.Clear();
            cb_City.Items.Clear();

            uniqueCategoryList = new List<string>();
            uniqueCityList = new List<string>();
            uniqueSubCategoryList = new List<string>();

            
            OleDbCommand command = new OleDbCommand(mainQuery, connection);
            var reader = command.ExecuteReader();
           
            while (reader.Read())
            {
                uniqueCategoryList.Add(reader[0].ToString());
                uniqueSubCategoryList.Add(reader[1].ToString());
                uniqueCityList.Add(reader[6].ToString());
            }

            uniqueCategoryList = uniqueCategoryList.Distinct().ToList();
            uniqueCityList = uniqueCityList.Distinct().ToList();
            uniqueSubCategoryList = uniqueSubCategoryList.Distinct().ToList();

            cb_subcategory.Items.AddRange(uniqueSubCategoryList.ToArray());
            cb_category.Items.AddRange(uniqueCategoryList.ToArray());
            cb_City.Items.AddRange(uniqueCityList.ToArray());

            counter(cb_Store.Items.Count.ToString(), cb_City.Items.Count.ToString());
        }

        private void cb_City_TextChanged(object sender, EventArgs e)
        {
            string mainQuery = GetMainZapros();

            cb_category.Items.Clear();
            cb_subcategory.Items.Clear();
            cb_Store.Items.Clear();
           

            uniqueStoreList = new List<string>();
            uniqueCategoryList = new List<string>();
            uniqueSubCategoryList = new List<string>();

            
            OleDbCommand command = new OleDbCommand(mainQuery, connection);
            var reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                uniqueCategoryList.Add(reader[0].ToString());
                uniqueSubCategoryList.Add(reader[1].ToString());
                uniqueStoreList.Add(reader[5].ToString());
            }

            uniqueStoreList = uniqueStoreList.Distinct().ToList();
            uniqueCategoryList = uniqueCategoryList.Distinct().ToList();
            uniqueSubCategoryList = uniqueSubCategoryList.Distinct().ToList();

            cb_subcategory.Items.AddRange(uniqueSubCategoryList.ToArray());
            cb_category.Items.AddRange(uniqueCategoryList.ToArray());
            cb_Store.Items.AddRange(uniqueStoreList.ToArray());

            counter(cb_Store.Items.Count.ToString(), cb_City.Items.Count.ToString());

        }

        private void FillGrid()
        {
            var gridZapros = GetMainZapros();
            OleDbCommand datacom = new OleDbCommand(gridZapros, connection);
            OleDbDataReader dataReader = datacom.ExecuteReader();
            int i = 1;
            int prodCount = 0;


            while (dataReader.Read())
            {
                dgTab.Rows.Add(
                    i.ToString(), dataReader[0].ToString(), dataReader[1].ToString(), dataReader[2].ToString(),
                    dataReader[3].ToString(), dataReader[4].ToString(), dataReader[5].ToString(), dataReader[6].ToString());

                i++;
                prodCount++;
            }
            lbl_QuatityProdName.Text = prodCount.ToString();
            counter(cb_Store.Items.Count.ToString(), cb_City.Items.Count.ToString());


        }
        private void FillComboBoxes()
        {
            var mainQuery = GetMainZapros();
            OleDbCommand command = new OleDbCommand(mainQuery, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                uniqueCategoryList.Add(reader[0].ToString());
                uniqueSubCategoryList.Add(reader[1].ToString());
                uniqueStoreList.Add(reader[5].ToString());
                uniqueCityList.Add(reader[6].ToString());
            }

            uniqueCategoryList = uniqueCategoryList.Distinct().ToList();
            uniqueSubCategoryList = uniqueSubCategoryList.Distinct().ToList();
            uniqueStoreList = uniqueStoreList.Distinct().ToList();
            uniqueCityList = uniqueCityList.Distinct().ToList();

            cb_category.Items.AddRange(uniqueCategoryList.ToArray());
            cb_subcategory.Items.AddRange(uniqueSubCategoryList.ToArray());
            cb_Store.Items.AddRange(uniqueStoreList.ToArray());
            cb_City.Items.AddRange(uniqueCityList.ToArray());

            


            

        }

    }
}
