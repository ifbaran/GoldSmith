using System;
using GoldSmith.Class;
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
    public partial class PersonalOperations : Form
    {
        Modules.PersonalModule personalModule = new Modules.PersonalModule();
        Modules.Class.Personal personal = new Modules.Class.Personal();
        public PersonalOperations()
        {
            InitializeComponent();
        }

        private void PersonalOperations_Load(object sender, EventArgs e)
        {
            GetPersonal();
        }

        private void GetPersonal()
        {
            grdPersonal.DataSource = personalModule.GetPersonal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            personal.PersonalName = txtPersonalName.Text;
            personal.PersonalSurname = txtPersonalSurname.Text;
            personal.PersonalNationalNumber = txtPersonalNationalNumber.Text;
            personal.PersonalAddress = txtAddress.Text;
            personal.PersonalNumber = txtPersonalNumber.Text;
            personal.PersonalEmail = txtPersonalEmail.Text;
            personal.PersonalNickName = txtPersonalNickName.Text;
            personal.PersonalPassword = txtPersonalPassword.Text;
            personal.PersonalAutID = txtAut.Text;
            if (rdbtnPersonel.Checked )
            {
                personal.PersonalTitle = rdbtnPersonel.Text;
            }
            else if (rdbtnMudur.Checked)
            {
                personal.PersonalTitle = rdbtnMudur.Text;

            }
            

            if (SaveValidations())
            {
                if (grdPersonal.SelectedRows?.Count > 0)
                {
                    personal.PersonalId = Convert.ToInt32(grdPersonal.SelectedRows[0].Cells[0].Value);

                    if (personalModule.Update(personal))
                    {
                        isSuccess = true;
                    }
                }
                else
                {
                    if (rdbtnMudur.Checked)
                    {
                        int roleID = 2;
                        personalModule.Insert(personal, roleID);
                        isSuccess = true;
                    }
                    else if (rdbtnPersonel.Checked)
                    {
                        int roleID = 3;
                        personalModule.Insert(personal, roleID);
                        isSuccess = true;
                    }
                }
                if (isSuccess)
                {
                    MessageBox.Show("Başarılı bir şekilde eklendi.");
                    GetPersonal();
                }
                else
                {
                    MessageBox.Show("Ekleme başarısız.");
                }
            }
        }
        private bool SaveValidations()
        {

            if ((string.IsNullOrEmpty(txtPersonalName.Text) ||
                string.IsNullOrEmpty(txtPersonalSurname.Text) ||
                string.IsNullOrEmpty(txtPersonalNationalNumber.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtPersonalNumber.Text) ||
                string.IsNullOrEmpty(txtPersonalEmail.Text)) || (rdbtnPersonel.Checked == false && rdbtnMudur.Checked == false))
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz !");
            }
            else
            {
                if (!Helper.Helper.IsEmail(txtPersonalEmail.Text))
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

        private void Clear()
        {
            txtPersonalName.Text = "";
            txtPersonalSurname.Text = "";
            txtPersonalNationalNumber.Text = "";
            txtAddress.Text = "";
            txtPersonalNumber.Text = "";
            txtPersonalEmail.Text = "";
            rdbtnMudur.Checked = false;
            rdbtnPersonel.Checked = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grdPersonal.ClearSelection();
            Clear();
            btnSave.Text = "Kaydet";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            personal.PersonalEmail = txtPersonalEmail.Text;
            if (grdPersonal.SelectedRows?.Count > 0)
            {
                SendMail sendform = new SendMail();
                personal.PersonalId = Convert.ToInt32(grdPersonal.SelectedRows[0].Cells[0].Value);
                sendform.txtWhom.Text = personal.PersonalEmail.ToString();
                sendform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen mail atmak istediğiniz şirketi seçiniz.");
            }
        }

        private void grdPersonal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdPersonal.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdPersonal.SelectedRows?.Count > 0)
            {
                personal.PersonalId = Convert.ToInt32(grdPersonal.SelectedRows[0].Cells[0].Value);
                grdPersonal.DataSource = personalModule.Delete(personal.PersonalId);
                GetPersonal();
                grdPersonal.ClearSelection();
                Clear();
            }

            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz şirketi seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdPersonal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = grdPersonal.Rows[index];

                string personalName = selectedRow.Cells["PersonalName"].Value.ToString();
                string personalSurname = selectedRow.Cells["PersonalSurname"].Value.ToString();
                string personalNationalNumber = selectedRow.Cells["PersonalNationalNumber"].Value.ToString();
                string personalAddress = selectedRow.Cells["PersonalAddress"].Value.ToString();
                string personalNumber = selectedRow.Cells["PersonalNumber"].Value.ToString();
                string personalEmail = selectedRow.Cells["PersonalEmail"].Value.ToString();
                string personalNickName = selectedRow.Cells["PersonalNickName"].Value.ToString();
                string personalPassword = selectedRow.Cells["PersonalPassword"].Value.ToString();


                txtPersonalName.Text = personalName;
                txtPersonalSurname.Text = personalSurname;
                txtPersonalNationalNumber.Text = personalNationalNumber;
                txtAddress.Text = personalAddress;
                txtPersonalNumber.Text = personalNumber;
                txtPersonalEmail.Text = personalEmail;
                txtPersonalNickName.Text = personalNickName;
                txtPersonalPassword.Text = personalPassword;

                btnSave.Text = "Güncelle";
            }
        }

        private void txtArama(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            long tcKimlik = 0;

            if (!string.IsNullOrEmpty(txtAramaTC.Text))
            {
                tcKimlik = Convert.ToInt64(txtAramaTC.Text);
            }

            string soyisim = txtAramaSoyisim.Text.Trim();

            grdPersonal.DataSource = personalModule.Search(tcKimlik, soyisim);
        }

    }
}
