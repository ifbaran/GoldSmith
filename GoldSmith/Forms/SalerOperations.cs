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

namespace GoldSmith.Forms
{
    public partial class SalerOperations : Form
    {
        SalerModule salerModule = new SalerModule();
        Saler saler = new Saler();

        public SalerOperations()
        {
            InitializeComponent();
        }

        private void SalerOperations_Load(object sender, EventArgs e)
        {

            GetSaler();
        }

        #region Kaydet butonu
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            saler.FirmName = txtFirmName.Text;
            saler.FirmTitle = txtFirmTitle.Text;
            saler.TaxNumber = txtTaxNumber.Text;
            saler.TaxOffice = txtTaxOffice.Text;
            saler.Address = txtAddress.Text;
            saler.WorkPhone = txtWorkPhone1.Text;
            saler.CellPhone = txtCellPhone1.Text;
            saler.FaxNumber = txtFaxNumber.Text;
            saler.Email = txtEmail.Text;

            if (SaveValidations())
            {
                if (grdSaler.SelectedRows?.Count > 0)
                {
                    saler.SalerId = Convert.ToInt32(grdSaler.SelectedRows[0].Cells[0].Value);

                    if (salerModule.Update(saler))
                    {
                        isSuccess = true;
                    }
                }
                else
                {
                    if (salerModule.Insert(saler))
                    {
                        isSuccess = true;
                    }
                }

                if (isSuccess)
                {
                    MessageBox.Show("Başarılı bir şekilde eklendi.");
                    GetSaler();
                }
                else
                {
                    MessageBox.Show("Ekleme başarısız.");
                }
            }
        }
        #endregion

        #region Textboxların içini boşaltan yardımcı fonksiyon
        private void Clear()
        {
            txtFirmName.Text = "";
            txtFirmTitle.Text = "";
            txtTaxNumber.Text = "";
            txtTaxOffice.Text = "";
            txtAddress.Text = "";
            txtWorkPhone1.Text = "";
            txtCellPhone1.Text = "";
            txtFaxNumber.Text = "";
            txtEmail.Text = "";
            btnSave.Text = "Kaydet";
        }
        #endregion

        #region SaveValidations : Textboxların boş olup olmadığını ve e-mailin doğru olup olmadığını kontrol eden yardımcı fonksiyon
        private bool SaveValidations()
        {

            if (string.IsNullOrEmpty(txtFirmName.Text) ||
                string.IsNullOrEmpty(txtFirmTitle.Text) || string.IsNullOrEmpty(txtTaxNumber.Text) || string.IsNullOrEmpty(txtTaxOffice.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtWorkPhone1.Text) ||
                string.IsNullOrEmpty(txtCellPhone1.Text) || string.IsNullOrEmpty(txtFaxNumber.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
            }
            else
            {
                if (!Helper.Helper.IsEmail(txtEmail.Text))
                {
                    MessageBox.Show("E-Mail'in doğru olduğundan emin olunuz! ");
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
        #endregion

        #region DataGridViewda satır seçen işlem
        public void grdSaler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = grdSaler.Rows[index];

                string firmName = selectedRow.Cells["FirmName"].Value.ToString();
                string firmTitle = selectedRow.Cells["FirmTitle"].Value.ToString();
                string taxNumber = selectedRow.Cells["TaxNumber"].Value.ToString();
                string taxOffice = selectedRow.Cells["TaxOffice"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string workPhone = selectedRow.Cells["WorkPhone"].Value.ToString();
                string cellPhone = selectedRow.Cells["CellPhone"].Value.ToString();
                string faxNumber = selectedRow.Cells["FaxNumber"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();

                txtFirmName.Text = firmName;
                txtFirmTitle.Text = firmTitle;
                txtTaxNumber.Text = taxNumber;
                txtTaxOffice.Text = taxOffice;
                txtAddress.Text = address;
                txtWorkPhone1.Text = workPhone;
                txtCellPhone1.Text = cellPhone;
                txtFaxNumber.Text = faxNumber;
                txtEmail.Text = email;

                btnSave.Text = "Güncelle";
            }
        }
        #endregion

        #region GetSaler : Görüntüleme işlemi
        private void GetSaler()
        {
            grdSaler.DataSource = salerModule.GetSaler();
        }

        #endregion

        #region Yeni butonuna basınca formu düzenleyen yardımcı fonksiyon
        private void btnNew_Click(object sender, EventArgs e)
        {
            grdSaler.ClearSelection();
            Clear();
            btnSave.Text = "Kaydet";
        }
        #endregion

        #region Seçili olan şirketi silen işlem
        private void btnDel_Click(object sender, EventArgs e)
        {

            if (grdSaler.SelectedRows?.Count > 0)
            {
                saler.SalerId = Convert.ToInt32(grdSaler.SelectedRows[0].Cells[0].Value);
                grdSaler.DataSource = salerModule.Delete(saler.SalerId);
                GetSaler();
                grdSaler.ClearSelection();
                Clear();
            }

            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz şirketi seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region Seçilen satır'ın mail hücresinden bilgiyi alıp mail formunda mail atılacak kişi doldurmasnı sağlayan işlem.
        private void LblMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            saler.Email = txtEmail.Text;
            if (grdSaler.SelectedRows?.Count > 0)
            {
                SendMail sendform = new SendMail();
                saler.SalerId = Convert.ToInt32(grdSaler.SelectedRows[0].Cells[0].Value);
                sendform.txtWhom.Text = saler.Email.ToString();
                sendform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen mail atmak istediğiniz şirketi seçiniz.");
            }

        }
        #endregion

        #region Toptancı işlemleri açıldığında DataGridView'da herhangi bir satır'ın seçili olmasını engelleyen işlem.
        private void grdSaler_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdSaler.ClearSelection();
        }
        #endregion

        #region Arama işlemi.
        // ID ve Firma ismiyle aramanın event'ini birleştirdik kod fazlalığı olmasın diye.
        private void txtArama(object sender, EventArgs e)
        {
            Search();
        }
        #endregion

        #region Search : Arama Fonksiyonu
        private void Search()
        {
            int taxNumber = 0;

            if (!string.IsNullOrEmpty(txtAramaId.Text))
            {
                taxNumber = Convert.ToInt32(txtAramaId.Text);
            }

            string firmName = txtAramaFirmaAdi.Text.Trim();

            grdSaler.DataSource = salerModule.Search(taxNumber, firmName);
        }
        #endregion

        #region Vergi Numarası textbox'ına sadece rakam girilmesini sağlayan event
        private void txtTaxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

    }
}