using Newtonsoft.Json;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

namespace Uyandirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>

        public class WOLClass : UdpClient
        {
            public WOLClass() : base()
            { }
            //this is needed to send broadcast packet
            public void SetClientToBrodcastMode()
            {
                if (this.Active)
                    this.Client.SetSocketOption(SocketOptionLevel.Socket,
                                              SocketOptionName.Broadcast, 0);
            }
        }

        //now use this class
        //MAC_ADDRESS should  look like '013FA049'
        private void WakeFunction(string MAC_ADDRESS)
        {
            WOLClass client = new WOLClass();
            client.Connect(new
               IPAddress(0xffffffff),  //255.255.255.255  i.e broadcast
               0x2fff); // port=12287 let's use this one 
            client.SetClientToBrodcastMode();
            //set sending bites
            int counter = 0;
            //buffer to be send
            byte[] bytes = new byte[1024];   // more than enough :-)
                                             //first 6 bytes should be 0xFF
            for (int y = 0; y < 6; y++)
                bytes[counter++] = 0xFF;
            //now repeate MAC 16 times
            for (int y = 0; y < 16; y++)
            {
                int i = 0;
                for (int z = 0; z < 6; z++)
                {
                    bytes[counter++] =
                        byte.Parse(MAC_ADDRESS.Substring(i, 2),
                        NumberStyles.HexNumber);
                    i += 3;
                }
            }

            //now send wake up packet
            int reterned_value = client.Send(bytes, 1024);
        }

        private void btnUyandir_Click(object sender, EventArgs e)
        {
            string secim = ((KeyValuePair<string, string>)cmbxPC.SelectedItem).Key;
            WakeFunction(secim);
            MessageBox.Show(((KeyValuePair<string, string>)cmbxPC.SelectedItem).Value + " isimli bilgisayara uyandýrma komutu gönderildi");
        }

        public void BilgisayarlariYukle()
        {
            cmbxPC.DataSource = null;
            List<Bilgisayar> items = null;
            using (StreamReader r = new StreamReader("Ayar.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Bilgisayar>>(json);
            }

            // Görünen, Value  
            Dictionary<string, string> item = new Dictionary<string, string>();
            item.Clear();
            foreach (Bilgisayar bilgi in items)
            {
                item.Add(bilgi.MAC, bilgi.BilgisayarAdi);
            }

            cmbxPC.DataSource = new BindingSource(item, null);
            cmbxPC.DisplayMember = "Value";
            cmbxPC.ValueMember = "Key";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BilgisayarlariYukle();
            //return; 

            //List<Bilgisayar> items = null; 
            //using (StreamReader r = new StreamReader("Ayar.json"))
            //{
            //    string json = r.ReadToEnd();
            //    items = JsonConvert.DeserializeObject<List<Bilgisayar>>(json);
            //}

            //List<Bilgisayar> ýstasyonBilgis = new List<Bilgisayar>();
            
           


            //// Görünen, Value  
            //Dictionary<string, string> item = new Dictionary<string, string>();
            //foreach (Bilgisayar bilgi in items)
            //{
            //    item.Add(bilgi.MAC, bilgi.BilgisayarAdi);
            //}



            ////item.Add("90:2B:34:33:77:22", "Yazýlým ana");
            ////item.Add("1C:6F:65:D1:98:3A", "Yazýlým Sanal");
            ////item.Add("A8:5E:45:6A:79:81", "KAYIT-14");
            ////item.Add("1C:6F:65:48:C9:43", "KAYIT-07");
            ////item.Add("1C:6F:65:AF:BA:20", "KAYIT-06");
            ////item.Add("1C:6F:65:D0:8C:52", "KAYIT-02");
            ////item.Add("1C:6F:65:D1:98:B1", "KAYIT-09");

            ////int i = 0;
            ////foreach (var eleman in item)
            ////{
            ////    i++;
            ////    ýstasyonBilgis.Add(new IstasyonBilgi()
            ////    {
            ////        ID = i,  
            ////        IstasyonAdi = eleman.Value,
            ////        MAC = eleman.Key
            ////    });
                
            ////}
            ////string json = JsonConvert.SerializeObject(ýstasyonBilgis.ToArray());

            //////write string to file
            ////System.IO.File.WriteAllText("Ayar.json", json);

            //cmbxPC.DataSource = new BindingSource(item, null);
            //cmbxPC.DisplayMember = "Value";
            //cmbxPC.ValueMember = "Key";
        }

        private void btnBilgisayarListesi_Click(object sender, EventArgs e)
        {
            BilgisayarEkleme bilgisayarEkleme = new BilgisayarEkleme();
            bilgisayarEkleme.ShowDialog();
            BilgisayarlariYukle(); 

        }
    }
}