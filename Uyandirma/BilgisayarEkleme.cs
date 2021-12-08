using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyandirma
{
    public partial class BilgisayarEkleme : Form
    {
        DataTable dt = null;
        int SonID = 0;
        public BindingSource bindingSource1 = new BindingSource();
        public BilgisayarEkleme()
        {
            InitializeComponent();
        }
 
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BilgisayarEkleme_Load(object sender, EventArgs e)
        {
            //string json = File.ReadAllText(System.AppDomain.CurrentDomain.BaseDirectory + "App_Data\\" + download_file[0]);

            string json = File.ReadAllText("Ayar.json");
            dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            dataGridView1.DataSource = dt;
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
            {
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                if (rowView != null && rowView.Row != null)
                {
                    // Removing row from the table created at the Form level.
                    txtBilgisayarAdi.Text = Convert.ToString(rowView.Row[1]);
                    txtMACAdresi.Text = Convert.ToString(rowView[2]);
                }
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Tabloya yeni pc eklendi  
            SonID = dt.Rows.Count;
            DataRow row = dt.NewRow();
            row[0] = SonID +1;
            row[1] = txtBilgisayarAdi.Text;
            row[2] = txtMACAdresi.Text;
            dt.Rows.Add(row);

            DataTableToJSONSave(); 
        }

        public void DataTableToJSONSave( )
        {
            List<Bilgisayar> BilgisayarListesi = new List<Bilgisayar>();
            foreach (DataRow dataRow in dt.Rows )
            {
                Bilgisayar b = new Bilgisayar();
                b.ID = Convert.ToInt32( dataRow["ID"].ToString());
                b.BilgisayarAdi =Convert.ToString( dataRow["BilgisayarAdi"]);
                b.MAC= Convert.ToString(dataRow["MAC"]);  

                BilgisayarListesi.Add(b);
            }

            string json = JsonConvert.SerializeObject(BilgisayarListesi.ToArray());

            //write string to file
            System.IO.File.WriteAllText("Ayar.json", json);
        }



        private void btnSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
            {
                DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

                if (rowView != null && rowView.Row != null)
                {
                    // Removing row from the table created at the Form level.
                    dt.Rows.Remove(rowView.Row);
                }
            }

            dataGridView1.Refresh();
            DataTableToJSONSave();
        }

        private void dataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }
    }
}
