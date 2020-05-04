using GoldSmith.Modules.Class;
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
    public partial class GoldCurrencyOperation : Form
    {
        GoldCurrency goldCurrency = new GoldCurrency();
        public GoldCurrencyOperation()
        {
            InitializeComponent();
        }

        private void GoldCurrencyOperation_Load(object sender, EventArgs e)
        {
            goldCurrency.GetGoldCurrencyInfo(grdGoldCurrency);
        }

    }
}
