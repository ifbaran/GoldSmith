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
    public partial class CustomerOperations : Form
    {
        Modules.CustomerModule customerModule = new Modules.CustomerModule();
        Modules.Class.Customer customer = new Modules.Class.Customer();
        public CustomerOperations()
        {
            InitializeComponent();
        }

        private void CustomerOperations_Load(object sender, EventArgs e)
        {
            GetCustomer();
        }
        private void grdCustomer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            grdCustomer.ClearSelection();
        }

        private void GetCustomer()
        {
            grdCustomer.DataSource = customerModule.GetCustomer();
        }

        private void Clear()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            richtxtAddress.Text = "";
            txtCellPhone.Text = "";
            txtEmail.Text = "";
        }

        private bool SaveValidations()
        {

            if (string.IsNullOrEmpty(txtName.Text) ||
                string.IsNullOrEmpty(txtSurname.Text) || string.IsNullOrEmpty(richtxtAddress.Text) || string.IsNullOrEmpty(txtCellPhone.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;

            customer.name = txtName.Text;
            customer.Surname = txtSurname.Text;
            customer.address = richtxtAddress.Text;
            customer.Number = txtCellPhone.Text;
            customer.email = txtEmail.Text;

            if (SaveValidations())
            {
                if (grdCustomer.SelectedRows?.Count > 0)
                {
                    customer.id = Convert.ToInt32(grdCustomer.SelectedRows[0].Cells[0].Value);

                    if (customerModule.Update(customer))
                    {
                        isSuccess = true;
                    }
                }
                else
                {
                    if (customerModule.Insert(customer))
                    {
                        isSuccess = true;
                    }
                }

                if (isSuccess)
                {
                    MessageBox.Show("Başarılı bir şekilde eklendi.");
                    GetCustomer();
                }
                else
                {
                    MessageBox.Show("Ekleme başarısız.");
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grdCustomer.ClearSelection();
            Clear();
            btnSave.Text = "Kaydet";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            customer.email = txtEmail.Text;
            if (grdCustomer.SelectedRows?.Count > 0)
            {
                SendMail sendform = new SendMail();
                customer.id = Convert.ToInt32(grdCustomer.SelectedRows[0].Cells[0].Value);
                sendform.txtWhom.Text = customer.email.ToString();
                sendform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen mail atmak istediğiniz şirketi seçiniz.");
            }
        }

        private void grdCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index > -1)
            {
                DataGridViewRow selectedRow = grdCustomer.Rows[index];

                string customerName = selectedRow.Cells["CustomerName"].Value.ToString();
                string customerSurname = selectedRow.Cells["CustomerSurname"].Value.ToString();
                string customerAddress = selectedRow.Cells["CustomerAddress"].Value.ToString();
                string customerNumber = selectedRow.Cells["CustomerNumber"].Value.ToString();
                string customerEmail = selectedRow.Cells["CustomerEmail"].Value.ToString();

                txtName.Text = customerName;
                txtSurname.Text = customerSurname;
                richtxtAddress.Text = customerAddress;
                txtCellPhone.Text = customerNumber;
                txtEmail.Text = customerEmail;

                btnSave.Text = "Güncelle";
            }
        }
        private void Search()
        {
            int id = 0;

            if (!string.IsNullOrEmpty(txtAramaID.Text))
            {
                id = Convert.ToInt32(txtAramaID.Text);
            }

            string soyisim = txtAramaSoyad.Text.Trim();

            grdCustomer.DataSource = customerModule.Search(id, soyisim);
        }

        private void txtArama(object sender, EventArgs e)
        {
            Search();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (grdCustomer.SelectedRows?.Count > 0)
            {
                customer.id = Convert.ToInt32(grdCustomer.SelectedRows[0].Cells[0].Value);
                grdCustomer.DataSource = customerModule.Delete(customer.id);
                GetCustomer();
                grdCustomer.ClearSelection();
                Clear();
            }

            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz şirketi seçiniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
