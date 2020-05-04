using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoldSmith.Forms;
using static GoldSmith.Helper.Enums;

namespace GoldSmith
{
    public partial class Main : Form
    {
        int userId = 0;
        int personalId = 0;
        LoginType loginType;


        public Main()
        {
            InitializeComponent();
        }

        public Main(int userId, LoginType loginType)
        {
            InitializeComponent();
            this.userId = userId;
            this.personalId = userId;
            this.loginType = loginType;
        }
       
        private void Main_Load(object sender, EventArgs e)
        {
            toolAdmin.Enabled = false;
            toolAltin.Enabled = false;
            toolAltinTipiIslemleri.Enabled = false;
            toolDepo.Enabled = false;
            toolDepoIslemleri.Enabled = false;
            toolFatura.Enabled = false;
            toolFaturaIslemleri.Enabled = false;
            toolKullaniciIslemleri.Enabled = false;
            toolPersonel.Enabled = false;
            toolPersonelIslemleri.Enabled = false;
            toolSubeIslemleri.Enabled = false;
            toolSubeler.Enabled = false;
            toolToptanci.Enabled = false;
            toolToptanciIslemleri.Enabled = false;
            toolYetkilendirmeIslemleri.Enabled = false;

            if (loginType == LoginType.User)
            {
                ProcessMenu();
            }
            else if (loginType == LoginType.Personal)
            {
                ProcessMenuPersonal();
            }
        }
        private void ProcessMenu()
        {
            Database.Database database = new Database.Database();

            string query = @"SELECT
                                u.UserId,
                                u.UserName,
                                m.MenuId,
                                m.Name MenuName,
                                m.AppName
                                FROM User u
                                INNER JOIN UserRole ru ON ru.UserId = u.UserId
                                INNER JOIN Role r ON r.RoleId = ru.RoleId
                                INNER JOIN RoleMenu rm ON rm.RoleId = r.RoleId
                                INNER JOIN Menu m ON m.MenuId = rm.MenuId WHERE u.UserId = " + userId;

            var menuRoles = database.ShowDataInGridView(query);

            if (menuRoles?.Rows?.Count > 0)
            {
                for (int i = 0; i < menuRoles.Rows.Count; i++)
                {
                    string componentName = menuRoles.Rows[i]["AppName"].ToString();
                    if (!string.IsNullOrEmpty(componentName))
                    {
                        ToolStripItem[] component = menuStrip.Items.Find(componentName, true);

                        if (component?.Count() > 0)
                        {
                            component[0].Enabled = true;
                        }
                        else
                        {
                            //menuStrip.   
                        }
                    }

                }

            }
            else
            {
                menuStrip.Enabled = false;
            }
        }

        private void ProcessMenuPersonal()
        {
            Database.Database database = new Database.Database();

            string query = @"SELECT
                                p.Personalid,
                                p.PersonalName,
                                m.MenuId,
                                m.Name MenuName,
                                m.AppName
                                FROM Personal p
                                INNER JOIN PersonalRole pr ON pr.Personalid = p.Personalid
                                INNER JOIN Role r ON r.RoleId = pr.RoleId
                                INNER JOIN RoleMenu rm ON rm.RoleId = r.RoleId
                                INNER JOIN Menu m ON m.MenuId = rm.MenuId WHERE p.Personalid = " + personalId;

            var menuRoles = database.ShowDataInGridView(query);

            if (menuRoles?.Rows?.Count > 0)
            {
                for (int i = 0; i < menuRoles.Rows.Count; i++)
                {
                    string componentName = menuRoles.Rows[i]["AppName"].ToString();
                    if (!string.IsNullOrEmpty(componentName))
                    {
                        ToolStripItem[] component = menuStrip.Items.Find(componentName, true);

                        if (component?.Count() > 0)
                        {
                            component[0].Enabled = true;
                        }
                        else
                        {
                            //menuStrip.   
                        }
                    }

                }

            }
            else
            {
                menuStrip.Enabled = false;
            }
        }



        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolKullaniciIslemleri_Click(object sender, EventArgs e)
        {

        }

        private void toolToptanciIslemleri_Click(object sender, EventArgs e)
        {
            OpenControl(new SalerOperations());

        }
        //öğren
        private void Main_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
                tabForms.Visible = false;
            // If no any child form, hide tabControl 
            else
            {
                this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
                // Child form always maximized 

                // If child form is new and no has tabPage, 
                // create new tabPage
                if (this.ActiveMdiChild.Tag == null)
                {
                    // Add a tabPage to tabControl with child 
                    // form caption 
                    TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                    tp.Tag = this.ActiveMdiChild;
                    tp.Parent = tabForms;
                    tabForms.SelectedTab = tp;
                    this.ActiveMdiChild.Tag = tp;
                    this.ActiveMdiChild.FormClosed += new FormClosedEventHandler(ActiveMdiChild_FormClosed);
                }

                if (!tabForms.Visible) tabForms.Visible = true;
            }
        }

        private void ActiveMdiChild_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((tabForms.SelectedTab != null) &&
                (tabForms.SelectedTab.Tag != null))
                (tabForms.SelectedTab.Tag as Form).Select();
        }

        private void OpenControl(Form form)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == form.Name)
                {
                    isOpen = true;
                    f.Focus();
                    break;
                }
            }
            if (isOpen == false)
            {
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
        }

        private void toolAltinTipiIslemleri_Click(object sender, EventArgs e)
        {
            OpenControl(new GoldTypeOperation());
        }

        private void toolPersonelIslemleri_Click(object sender, EventArgs e)
        {
            OpenControl(new PersonalOperations());
        }

        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenControl(new CustomerOperations());
        }

        private void altınKuruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenControl(new GoldCurrencyOperation());
        }

        private void toolDepoIslemleri_Click(object sender, EventArgs e)
        {
            OpenControl(new StorageOperations());
        }

        private void toolSubeIslemleri_Click(object sender, EventArgs e)
        {
            OpenControl(new StoreOperations());
        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenControl(new SaleOperation(userId));
        }

        private void toolYetkilendirmeIslemleri_Click(object sender, EventArgs e)
        {
            OpenControl(new AdminOperations());
        }
    }
}
