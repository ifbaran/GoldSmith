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
    public partial class AdminOperations : Form
    {
        AdminAuthorityModule adminAuthorityModule = new AdminAuthorityModule();
        public AdminOperations()
        {
            InitializeComponent();
        }

        private void AdminOperations_Load(object sender, EventArgs e)
        {
            GetPersonalForAuthority();
        }

        private void GetPersonalForAuthority()
        {
            grdPersonal.DataSource = adminAuthorityModule.GetPersonalForAuthority();
        }
        private void AdminSearch()
        {

            string tcKimlikNumarasi = null;
            string surname = null;

            if (!string.IsNullOrEmpty(txtAramaTcNo.Text))
            {
                tcKimlikNumarasi = txtAramaTcNo.Text.ToString();
            }
            if (!string.IsNullOrEmpty(txtAramaSurname.Text))
            {
                surname = txtAramaSurname.Text.Trim();
            }

            grdPersonal.DataSource = adminAuthorityModule.Search(tcKimlikNumarasi, surname);
        }
        private void txtAramaTcNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            AdminSearch();
        }

        private void txtAramaSurname_TextChanged(object sender, EventArgs e)
        {
            AdminSearch();
        }
    }
}
