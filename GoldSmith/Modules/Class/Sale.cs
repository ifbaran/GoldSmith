using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;
using GoldSmith.Forms;
using System.Windows.Forms;

namespace GoldSmith.Modules.Class
{
    class Sale
    {

        Database.Database database = new Database.Database();
        private int storeID;
        private string storeName;
        private int salerID;
        private string salerName;
        private int saleID;
        private string saleDateAndTime;
        private string buyerName;
        private int goldTypeID;
        private string goldTypeName;
        private double goldPrice;
        private int saleAmount;
        private double salePrice;

        public int StoreID { get => storeID; set => storeID = value; }
        public string StoreName { get => storeName; set => storeName = value; }
        public int SalerID { get => salerID; set => salerID = value; }
        public string SalerName { get => salerName; set => salerName = value; }
        public int SaleID { get => saleID; set => saleID = value; }
        public string SaleDateAndTime { get => saleDateAndTime; set => saleDateAndTime = value; }
        public string BuyerName { get => buyerName; set => buyerName = value; }
        public int GoldTypeID { get => goldTypeID; set => goldTypeID = value; }
        public string GoldTypeName { get => goldTypeName; set => goldTypeName = value; }
        public double GoldPrice { get => goldPrice; set => goldPrice = value; }
        public int SaleAmount { get => saleAmount; set => saleAmount = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }

        public void SetSalerName(TextBox txt_SalerName, int id)
        {
            SalerID = id;
            string query = "SELECT * FROM User";
            DataRow[] dataRows = database.ShowDataInGridView(query).Select("UserId = '" + SalerID + "'");
            string name = dataRows[0]["Name"].ToString();
            string surname = dataRows[0]["Surname"].ToString();
            SalerName = name + " " + surname;
            txt_SalerName.Text = SalerName;
        }
        public void Txt_Change(TextBox txt_GoldPrice, ComboBox comboBox, TextBox txt_SaleAmount, TextBox txt_SalePrice)
        {
            try
            {
                if (Convert.ToInt32(txt_SaleAmount.Text) > 0 && comboBox.SelectedIndex > 0)
                {
                    GoldTypeName = comboBox.SelectedItem.ToString();
                    SaleAmount = Convert.ToInt32(txt_SaleAmount.Text);
                    SetGoldPrice();
                    SetSalePrice();
                    txt_GoldPrice.Text = GoldPrice.ToString();
                    txt_SalePrice.Text = SalePrice.ToString();
                }
                else
                {
                    SalePrice = 0;
                    txt_SalePrice.Text = SalePrice.ToString();
                }
            }
            catch (Exception)
            {
                SalePrice = 0;
                txt_SalePrice.Text = SalePrice.ToString();
            }

        }
        private void SetSalePrice()
        {
            SalePrice = SaleAmount * GoldPrice;
        }
        private void SetStoreID()
        {
            try
            {
                string query = "SELECT * FROM Store";
                DataRow[] dataRows = database.ShowDataInGridView(query).Select("StoreName = '" + StoreName + "'");
                StoreID = Convert.ToInt32(dataRows[0]["StoreID"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetGoldPrice()
        {
            try
            {
                string query = "SELECT * FROM GoldCurrency";
                DataRow[] dataRows = database.ShowDataInGridView(query).Select("GoldType = '" + GoldTypeName + "'");
                GoldPrice = double.Parse(dataRows[0]["GoldCurrencySelling"].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GetSaleInfo(DataGridView dataGridView)
        {
            try
            {
                string query = "SELECT * FROM Sale";
                dataGridView.DataSource = database.ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddNewSale(ComboBox comboBox, DateTimePicker dateTimePicker, TextBox txt_StoreName, TextBox txt_SalerName, TextBox txt_BuyerName, TextBox txt_GoldPrice, TextBox txt_SaleAmount, TextBox txt_SalePrice)
        {

            try
            {
                StoreName = txt_StoreName.Text.ToString();
                SetStoreID();
                SalerName = txt_SalerName.Text.ToString();
                SaleDateAndTime = dateTimePicker.Text.ToString();
                BuyerName = txt_BuyerName.Text.ToString();
                GoldTypeID = comboBox.SelectedIndex;
                GoldTypeName = comboBox.SelectedItem.ToString();
                SetGoldPrice();
                SaleAmount = Convert.ToInt32(txt_SaleAmount.Text);
                SetSalePrice();
                if (comboBox.SelectedIndex > 0)
                {
                    string query = string.Format("INSERT INTO Sale(StoreID,StoreName,SalerID,SalerName,SaleDateAndTime,BuyerName,GoldTypeID,GoldTypeName,GoldPrice,SaleAmount,SalePrice) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", StoreID, StoreName, SalerID, SalerName, SaleDateAndTime, BuyerName, GoldTypeID, GoldTypeName, GoldPrice.ToString(), SaleAmount, SalePrice);
                    database.ExecuteQueries(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateSale(DataGridView dataGridView, ComboBox comboBox, DateTimePicker dateTimePicker, TextBox txt_StoreName, TextBox txt_SalerName, TextBox txt_BuyerName, TextBox txt_GoldPrice, TextBox txt_SaleAmount, TextBox txt_SalePrice)
        {
            try
            {
                StoreName = txt_StoreName.Text.ToString();
                SetStoreID();
                SalerName = txt_SalerName.Text.ToString();
                SaleDateAndTime = dateTimePicker.Text.ToString();
                BuyerName = txt_BuyerName.Text.ToString();
                GoldTypeID = comboBox.SelectedIndex;
                GoldTypeName = comboBox.SelectedItem.ToString();
                SetGoldPrice();
                SaleAmount = Convert.ToInt32(txt_SaleAmount.Text);
                SetSalePrice();
                int SaleID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[4].Value);
                string query = string.Format("UPDATE Sale SET StoreID ='{0}',StoreName = '{1}',SalerID = '{2}',SalerName = '{3}',SaleDateAndTime = '{4}',BuyerName = '{5}',GoldTypeID = '{6}',GoldTypeName = '{7}',GoldPrice = '{8}',SaleAmount = '{9}',SalePrice = '{10}' WHERE SaleID = '{11}'", StoreID, StoreName, SalerID, SalerName, SaleDateAndTime, BuyerName, GoldTypeID, GoldTypeName, GoldPrice.ToString(), SaleAmount, SalePrice, SaleID);
                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void DeleteSale(DataGridView dataGridView)
        {
            try
            {
                SaleID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[4].Value);
                string query = string.Format("DELETE FROM Sale WHERE SaleID = {0}", SaleID);
                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
