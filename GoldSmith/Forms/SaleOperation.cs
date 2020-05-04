using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldSmith.Forms
{
    public partial class SaleOperation : Form
    {
        int id = 0;
        Modules.Class.Sale sale = new Modules.Class.Sale();
        public SaleOperation(int id)
        {
            InitializeComponent();
            sale.GetSaleInfo(dataGridView1);
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sale.AddNewSale(comboBox1, dateTimePicker1, txt_StoreName, txt_SalerName, txt_BuyerName, txt_GoldPrice, txt_SaleAmount, txt_SalePrice);
            sale.GetSaleInfo(dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sale.Txt_Change(txt_GoldPrice, comboBox1, txt_SaleAmount, txt_SalePrice);
        }

        private void txt_SaleAmount_TextChanged(object sender, EventArgs e)
        {
            sale.Txt_Change(txt_GoldPrice, comboBox1, txt_SaleAmount, txt_SalePrice);
        }

        private void SaleOperation_Load(object sender, EventArgs e)
        {
                sale.SetSalerName(txt_SalerName, id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sale.DeleteSale(dataGridView1);
            sale.GetSaleInfo(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sale.UpdateSale(dataGridView1, comboBox1, dateTimePicker1, txt_StoreName, txt_SalerName, txt_BuyerName, txt_GoldPrice, txt_SaleAmount, txt_SalePrice);
            sale.GetSaleInfo(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];

                string buyerName = selectedRow.Cells["BuyerName"].Value.ToString();
                string goldPrice = selectedRow.Cells["GoldPrice"].Value.ToString();
                string saleAmount = selectedRow.Cells["SaleAmount"].Value.ToString();
                string salePrice = selectedRow.Cells["SalePrice"].Value.ToString();
                string salerName = selectedRow.Cells["SalerName"].Value.ToString();
                string storeName = selectedRow.Cells["StoreName"].Value.ToString();
                string goldType = selectedRow.Cells["GoldTypeName"].Value.ToString();
                string saleDateAndTime = selectedRow.Cells["SaleDateAndTime"].Value.ToString();


                txt_BuyerName.Text = buyerName;
                txt_GoldPrice.Text = goldPrice;
                txt_SaleAmount.Text = saleAmount;
                txt_SalePrice.Text = salePrice;
                txt_SalerName.Text = salerName;
                txt_StoreName.Text = storeName;
                comboBox1.SelectedItem = goldType;
                dateTimePicker1.Text = saleDateAndTime;

            }
        }
    }
}
