using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Data;
using GoldSmith.Forms;
using System.Windows.Forms;

namespace GoldSmith.Class
{
    public class GoldType
    {
        int goldTypeID;
        string goldTypeName;
        public string GoldTypeName { get => goldTypeName; set => goldTypeName = value; }
        public int GoldTypeID { get => goldTypeID; set => goldTypeID = value; }

        public void GetGoldTypeInfo(DataGridView dataGridView)
        {
            try
            {
                string query = "SELECT * FROM GoldType";
                Database.Database database = new Database.Database();
                dataGridView.DataSource = database.ShowDataInGridView(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateGoldType(DataGridView dataGridView, ComboBox comboBox)
        {
            GoldTypeID = comboBox.SelectedIndex;
            GoldTypeName = comboBox.SelectedItem.ToString();
            try
            {
                int old_GoldTypeID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                string query = string.Format("UPDATE GoldType SET GoldTypeName = '{0}', GoldTypeID = '{1}' WHERE GoldTypeID = '{2}'", GoldTypeName,GoldTypeID,old_GoldTypeID );
                Database.Database database = new Database.Database();
                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AddNewGoldType(ComboBox comboBox)
        {
            GoldTypeID = comboBox.SelectedIndex;
            GoldTypeName = comboBox.SelectedItem.ToString();
            try
            {
                if (comboBox.SelectedIndex != 0)
                {
                    string query = string.Format("INSERT INTO GoldType(GoldTypeName,GoldTypeID) VALUES('{0}',{1})", GoldTypeName, GoldTypeID);
                    Database.Database database = new Database.Database();
                    database.ExecuteQueries(query);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bu Altın Tipi daha önce eklendi");
            }
        }
        public void DeleteGoldType(DataGridView dataGridView)
        {
            try
            {
                GoldTypeID = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                string query = string.Format("DELETE FROM GoldType WHERE GoldTypeID = {0}", GoldTypeID);
                Database.Database database = new Database.Database();
                database.ExecuteQueries(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        public DataTable Search(int id, string goldName)
        {
            Database.Database database = new Database.Database();

            string query = "SELECT * FROM GoldType ";
            string options = string.Empty;

            if (id > 0 && string.IsNullOrEmpty(goldName))
            {
                options = "WHERE GoldTypeID =" + id;
            }
            else if (id == 0 && !string.IsNullOrEmpty(goldName))
            {
                options = "WHERE GoldTypeName LIKE '%" + goldName + "%'";
            }
            else if (id > 0 && !string.IsNullOrEmpty(goldName))
            {
                options = "WHERE GoldTypeID = '" + id + "' AND GoldTypeName LIKE '%" + goldName + "%'";
            }

            query = query + options;

            var gold = database.ShowDataInGridView(query);

            return gold;
        }

    }
}
