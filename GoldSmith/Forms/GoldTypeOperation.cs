using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldSmith.Class;
namespace GoldSmith.Forms
{
    public partial class GoldTypeOperation : Form
    {
        GoldType goldType = new GoldType();
        public GoldTypeOperation()
        {
            InitializeComponent();

        }
        private void GoldTypeOperation_Load(object sender, EventArgs e)
        {
            
            goldType.GetGoldTypeInfo(grdGoldType);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            goldType.AddNewGoldType(comboBox1);
            Clear();
            goldType.GetGoldTypeInfo(grdGoldType);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            
            goldType.DeleteGoldType(grdGoldType);
            goldType.GetGoldTypeInfo(grdGoldType);
        }

        
        private void grdGoldType_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdGoldType.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            goldType.UpdateGoldType(grdGoldType, comboBox1);
            goldType.GetGoldTypeInfo(grdGoldType);
            Clear();
        }

        private void Search()
        {
            try
            {
                int id = 0;

                if (!string.IsNullOrEmpty(txtSearchID.Text))
                {
                    id = Convert.ToInt32(txtSearchID.Text);
                }

                string gold = txtSearchGold.Text.Trim();

                grdGoldType.DataSource = goldType.Search(id, gold);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            comboBox1.SelectedIndex = default;
        }

        private void txtSearch(object sender, EventArgs e)
        {
            Search();
        }
    }
}

