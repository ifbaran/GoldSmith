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
using GoldSmith.Modules;

namespace GoldSmith.Forms
{
    public partial class StoreOperations : Form
    {
        StoreModule storeModule = new StoreModule();
        Store store = new Store();
        public StoreOperations()
        {
            InitializeComponent();
        }

        private void StoreOperations_Load(object sender, EventArgs e)
        {
            GetStore();
        }
        private void GetStore()
        {
            grdStore.DataSource = storeModule.GetStore();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            store.StoreName = txtStoreName.Text;
            store.StoreAdress = txtStoreAdress.Text;
            store.StoreOpenHour = mtxtOpen.Text;
            store.StoreCloseHour = mtxtClose.Text;
            store.storeStorage = txtStoreStorage.Text;

            if (!SaveValidations())
            {
                if (grdStore.SelectedRows?.Count > 0)
                {
                    store.StoreID = Convert.ToInt32(grdStore.SelectedRows[0].Cells[0].Value);

                    if (storeModule.Update(store))
                    {
                        isSuccess = true;
                    }
                }
                else
                {
                    if (storeModule.Insert(store))
                    {
                        isSuccess = true;
                    }
                }

                if (isSuccess)
                {
                    MessageBox.Show("Başarılı bir şekilde eklendi.");
                    GetStore();
                }
                else
                {
                    MessageBox.Show("Ekleme başarısız.");
                }
            }
        }
        private bool SaveValidations()
        {
            if (string.IsNullOrEmpty(txtStoreName.Text) || string.IsNullOrEmpty(txtStoreAdress.Text) || string.IsNullOrEmpty(mtxtClose.Text) || string.IsNullOrEmpty(mtxtOpen.Text) || string.IsNullOrEmpty(txtStoreStorage.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
            }
            return false;
        }

        private void Clear()
        {
            txtStoreName.Text = "";
            txtStoreAdress.Text = "";
            mtxtOpen.Text = "";
            mtxtClose.Text = "";
            txtStoreStorage.Text = "";

            btnSave.Text = "Kaydet";
        }

        private void grdStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = grdStore.Rows[index];

                string storeName = selectedRow.Cells["StoreName"].Value.ToString();
                string storeAdress = selectedRow.Cells["StoreAdress"].Value.ToString();
                string storeOpenHour = selectedRow.Cells["StoreOpenHour"].Value.ToString();
                string storeCloseHour = selectedRow.Cells["StoreCloseHour"].Value.ToString();
                string storeStorage = selectedRow.Cells["StoreStorage"].Value.ToString();

                txtStoreName.Text = storeName;
                txtStoreAdress.Text = storeAdress;
                mtxtOpen.Text = storeOpenHour;
                mtxtClose.Text = storeCloseHour;
                txtStoreStorage.Text = storeStorage;

                btnSave.Text = "Güncelle";
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grdStore.ClearSelection();
            Clear();
            btnSave.Text = "Kaydet";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (grdStore.SelectedRows?.Count > 0)
            {
                store.StoreID = Convert.ToInt32(grdStore.SelectedRows[0].Cells[0].Value);
                grdStore.DataSource = storeModule.Delete(store.StoreID);
                GetStore();
                grdStore.ClearSelection();
                Clear();
            }

            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz mağazayı seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StoreSearch()
        {
            int StoreId = 0;
            string StoreName = null;

            if (!string.IsNullOrEmpty(txtAramaMağazaId.Text))
            {
                StoreId = int.Parse(txtAramaMağazaId.Text);
            }
            if (!string.IsNullOrEmpty(txtAramaMağazaAdi.Text))
            {
                StoreName = txtAramaMağazaAdi.Text.Trim();
            }

            grdStore.DataSource = storeModule.Search(StoreId, StoreName);
        }

        private void txtArama(object sender, EventArgs e)
        {
            StoreSearch();
        }
    }
}
