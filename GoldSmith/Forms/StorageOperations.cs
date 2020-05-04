using GoldSmith.Class;
using GoldSmith.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using GoldSmith.Modules.Class;

namespace GoldSmith.Forms
{

    public partial class StorageOperations : Form
    {
        StorageModule storageModule = new StorageModule();
        Storage storage = new Storage();

        public StorageOperations()
        {
            InitializeComponent();
        }

        private void StorageOperations_Load(object sender, EventArgs e)
        {
            GetStorage();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            storage.StorageType = txtStorageType.Text;
            storage.StorageTaxNumber = txtStorageTaxNumber.Text;
            storage.StorageSize = txtStorageSize.Text;
            storage.StorageAddress = rtxtStorageAdress.Text;
            storage.StoragePhoneNumber = txtStoragePhoneNumber.Text;
            storage.StorageFaxNumber = txtStorageFaxNumber.Text;

            if (SaveValidations())
            {
                if (grdStorage.SelectedRows?.Count > 0)
                {
                    storage.StorageId = Convert.ToInt32(grdStorage.SelectedRows[0].Cells[0].Value);

                    if (storageModule.Update(storage))
                    {
                        isSuccess = true;
                    }
                }
                else
                {
                    if (storageModule.Insert(storage))
                    {
                        isSuccess = true;
                    }
                }

                if (isSuccess)
                {
                    MessageBox.Show("Veri başarılı bir şekilde eklendi.");
                    GetStorage();
                }
                else
                {
                    MessageBox.Show("Veri ekleme başarısız.");
                }
            }
        }

        private void stCleaner()
        {
            txtStorageType.Text = "";
            txtStorageTaxNumber.Text = "";
            txtStorageSize.Text = "";
            rtxtStorageAdress.Text = "";
            txtStoragePhoneNumber.Text = "";
            txtStorageFaxNumber.Text = "";

        }

        private bool SaveValidations()
        {

            if (!string.IsNullOrEmpty(txtStorageType.Text) || !string.IsNullOrEmpty(txtStorageTaxNumber.Text) || !string.IsNullOrEmpty(txtStorageSize.Text)
            || !string.IsNullOrEmpty(rtxtStorageAdress.Text) || !string.IsNullOrEmpty(txtStoragePhoneNumber.Text) || !string.IsNullOrEmpty(txtStorageFaxNumber.Text))

            {
                return true;
            }
            else
            {
                return false;
                MessageBox.Show("geçerli alanları doldurunuz.");

            }



        }

        private void GetStorage()
        {
            grdStorage.DataSource = storageModule.GetStorage();
        }

        private void btCleaner_Click(object sender, EventArgs e)
        {
            grdStorage.ClearSelection();
            stCleaner();
            btSave.Text = "Kaydet";

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (grdStorage.SelectedRows?.Count > 0)
            {
                storage.StorageId = Convert.ToInt32(grdStorage.SelectedRows[0].Cells[0].Value);
                grdStorage.DataSource = storageModule.Delete(storage.StorageId);
                GetStorage();
                grdStorage.ClearSelection();
                stCleaner();
            }

            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz depoyu seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtArama(object sender, EventArgs e)
        {
            Search();
        }


        private void Search()
        {
            long storageTaxNumber = 0;

            if (!string.IsNullOrEmpty(txtAramaVergiNo.Text))
            {
                storageTaxNumber = Convert.ToInt64(txtAramaVergiNo.Text);
            }

            string storageType = txtSearchType.Text.Trim();

            grdStorage.DataSource = storageModule.Search(storageTaxNumber, storageType);
        }
        private void txtStorageTaxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void grdStorage_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdStorage.ClearSelection();
        }

        private void grdStorage_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = grdStorage.Rows[index];

                string storageType = selectedRow.Cells["StorageType"].Value.ToString();
                string storageTaxNumber = selectedRow.Cells["StorageTaxNumber"].Value.ToString();
                string storageSize = selectedRow.Cells["StorageSize"].Value.ToString();
                string storageAddress = selectedRow.Cells["StorageAdress"].Value.ToString();
                string storagePhoneNumber = selectedRow.Cells["StoragePhoneNumber"].Value.ToString();
                string storageFaxNumber = selectedRow.Cells["StorageFaxNumber"].Value.ToString();


                txtStorageType.Text = storageType;
                txtStorageTaxNumber.Text = storageTaxNumber;
                txtStorageSize.Text = storageSize;
                rtxtStorageAdress.Text = storageAddress;
                txtStoragePhoneNumber.Text = storagePhoneNumber;
                txtStorageFaxNumber.Text = storageFaxNumber;



                btSave.Text = "Güncelle";
            }
        }
    }
}


