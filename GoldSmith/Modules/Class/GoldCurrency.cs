using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace GoldSmith.Modules.Class
{
    public class GoldCurrency
    {
        string goldType;
        string goldID;
        string goldCurrencyBuying;
        string goldCurrencySelling;

        public string GoldType { get => goldType; set => goldType = value; }
        public string GoldID { get => goldID; set => goldID = value; }
        public string GoldCurrencyBuying { get => goldCurrencyBuying; set => goldCurrencyBuying = value; }
        public string GoldCurrencySelling { get => goldCurrencySelling; set => goldCurrencySelling = value; }

        private string SetQuery()
        {
            string query = String.Format("UPDATE GoldCurrency SET GoldCurrencyBuying = '{0}' , GoldCurrencySelling = '{1}' WHERE GoldType = '{2}' ", GoldCurrencyBuying, GoldCurrencySelling, GoldType);
            return query;
        }

        public void GetGoldCurrencyInfo(DataGridView dataGridView)
        {
            try
            {
                SetGoldCurrencyInfo();
                string query = "SELECT *FROM GoldCurrency";
                Database.Database database = new Database.Database();

                dataGridView.DataSource = database.ShowDataInGridView(query);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        private void SetGoldCurrencyInfo()
        {
            string query;
            Database.Database database = new Database.Database();

            FullGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            GramGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            Ons();
            query = SetQuery();
            database.ExecuteQueries(query);

            QuarterGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            FourteenCaratGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            EighteenCaratGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            TwoAndHalfGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            FivesGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            GremseGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            TwentyTwoCaratGoldBracelet();
            query = SetQuery();
            database.ExecuteQueries(query);

            CumhuriyetGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);

            HalfGoldCoin();
            query = SetQuery();
            database.ExecuteQueries(query);
        }

        private void QuarterGoldCoin()
        {
            GoldType = "Çeyrek Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/ceyrek-altin\">              < span class=\"flag icon icon-\"></span>              Ceyrek Altın            </a>          </td>          <td>...,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/ceyrek-altin\">              < span class=\"flag icon icon-\"></span>              Ceyrek Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/ceyrek-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/ceyrek-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);

        }
        private void FullGoldCoin()
        {
            GoldType = "Tam Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/tam-altin\">              < span class=\"flag icon icon-\"></span>              Tam Altın            </a>          </td>          <td>.....,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/tam-altin\">              < span class=\"flag icon icon-\"></span>              Tam Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/tam-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/tam-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);
        }
        private void GramGoldCoin()
        {
            GoldType = "Gram Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/gram-altin\">              < span class=\"flag icon icon-\"></span>              Gram Altın            </a>          </td>          <td>...,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/gram-altin\">              < span class=\"flag icon icon-\"></span>              Gram Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/gram-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/gram-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);

        }
        private void Ons()
        {
            GoldType = "Ons";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/ons\">              < span class=\"flag icon icon-\"></span>              Ons            </a>          </td>          <td>.....,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/ons\">              < span class=\"flag icon icon-\"></span>              Ons            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/ons\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/ons\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);

        }
        private void FourteenCaratGoldCoin()
        {
            GoldType = "14 Ayar Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/14-ayar-altin\">              < span class=\"flag icon icon-\"></span>              14 Ayar Altın            </a>          </td>          <td>...,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/14-ayar-altin\">              < span class=\"flag icon icon-\"></span>              14 Ayar Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/14-ayar-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/14-ayar-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);

        }
        private void EighteenCaratGoldCoin()
        {
            GoldType = "18 Ayar Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/18-ayar-altin\">              < span class=\"flag icon icon-\"></span>              18 Ayar Altın            </a>          </td>          <td>...,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/18-ayar-altin\">              < span class=\"flag icon icon-\"></span>              18 Ayar Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/18-ayar-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/18-ayar-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);
        }
        private void TwoAndHalfGoldCoin()
        {
            GoldType = "İkibuçuk Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/ikibucuk-altin\">              < span class=\"flag icon icon-\"></span>              İkiBuçuk Altın            </a>          </td>          <td>.....,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/ikibucuk-altin\">              < span class=\"flag icon icon-\"></span>              İkiBuçuk Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/ikibucuk-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/ikibucuk-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);
        }
        private void FivesGoldCoin()
        {
            GoldType = "Beşli Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/besli-altin\">              < span class=\"flag icon icon-\"></span>              Beşli Altın            </a>          </td>          <td>.....,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/besli-altin\">              < span class=\"flag icon icon-\"></span>              Beşli Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/besli-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/besli-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);
        }
        private void GremseGoldCoin()
        {
            GoldType = "Gremse Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/gremse-altin\">              < span class=\"flag icon icon-\"></span>              Gremse Altın            </a>          </td>          <td>.....,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/gremse-altin\">              < span class=\"flag icon icon-\"></span>              Gremse Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/gremse-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/gremse-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);
        }
        private void TwentyTwoCaratGoldBracelet()
        {
            GoldType = "22 Ayar Bilezik";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/22-ayar-bilezik\">              < span class=\"flag icon icon-\"></span>              22 Ayar Bilezik            </a>          </td>          <td>...,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/22-ayar-bilezik\">              < span class=\"flag icon icon-\"></span>              22 Ayar Bilezik            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/22-ayar-bilezik\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/22-ayar-bilezik\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);
        }
        private void CumhuriyetGoldCoin()
        {
            GoldType = "Cumhuriyet Altını";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/cumhuriyet-altini\">              < span class=\"flag icon icon-\"></span>              Cumhuriyet Altını            </a>          </td>          <td>.....,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/cumhuriyet-altini\">              < span class=\"flag icon icon-\"></span>              Cumhuriyet Altını            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/cumhuriyet-altini\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/cumhuriyet-altini\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);
        }
        private void HalfGoldCoin()
        {
            GoldType = "Yarım Altın";
            string adres = "http://altin.doviz.com";
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string gelen = donenBilgiler.ReadToEnd();

            string AltinSatisIndex = "     <a href=\"//altin.doviz.com/yarim-altin\">              < span class=\"flag icon icon-\"></span>              Yarım Altın            </a>          </td>          <td>...,..</td>          <td>";
            string AltinAlisIndex = "    <a href=\"//altin.doviz.com/yarim-altin\">              < span class=\"flag icon icon-\"></span>              Yarım Altın            </a>          </td>          <td>";

            int titleIndexBaslangici = gelen.IndexOf("<a href=\"//altin.doviz.com/yarim-altin\">") + AltinAlisIndex.Length;
            int titleIndexBitisi = gelen.Substring(titleIndexBaslangici).IndexOf("</td>");

            GoldCurrencyBuying = gelen.Substring(titleIndexBaslangici, titleIndexBitisi);

            int titleIndexBaslangici2 = gelen.IndexOf("<a href=\"//altin.doviz.com/yarim-altin\">") + AltinSatisIndex.Length;
            int titleIndexBitisi2 = gelen.Substring(titleIndexBaslangici2).IndexOf("</td>");

            GoldCurrencySelling = gelen.Substring(titleIndexBaslangici2, titleIndexBitisi2);
        }

    }
}
