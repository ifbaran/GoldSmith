using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace GoldSmith.Forms
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            Modules.Class.SendMailModule sendMail = new Modules.Class.SendMailModule();
            sendMail.SendMail(txtWhom.Text,txtSubject.Text,richtxtContent.Text);
        }
        //ipek
    }

}


