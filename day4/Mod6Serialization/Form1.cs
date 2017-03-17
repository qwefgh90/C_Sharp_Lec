using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Soap;

namespace Mod6Serialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\config.bin", FileMode.Create);
            Config con = new Config(){IPAddress="172.1.1.1",UserName="USER1",DBServer="SERVER1"};
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fs, con);
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FileStream fs = new FileStream(@"c:\config.bin", FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            Config con = b.Deserialize(fs) as Config;
            listBox1.Items.Add(con.IPAddress);
            listBox1.Items.Add(con.UserName);
            listBox1.Items.Add(con.DBServer);
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //SoapFormatter
            FileStream fs = new FileStream(@"c:\config.soap", FileMode.Create);
            Config con = new Config() { IPAddress = "172.1.1.1", UserName = "USER1", DBServer = "SERVER1" };
            SoapFormatter b = new SoapFormatter();
            b.Serialize(fs, con);
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\config.soap", FileMode.Open);
            SoapFormatter b = new SoapFormatter();
            Config con = b.Deserialize(fs) as Config;
            listBox1.Items.Add(con.IPAddress);
            listBox1.Items.Add(con.UserName);
            listBox1.Items.Add(con.DBServer);
            fs.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //DataContractJsonSerializer
            //SoapFormatter
            FileStream fs = new FileStream(@"c:\config.json", FileMode.Create);
            Config con = new Config() { IPAddress = "172.1.1.1", UserName = "USER1", DBServer = "SERVER1" };
            DataContractJsonSerializer b = new DataContractJsonSerializer(typeof(Config));
            b.WriteObject(fs, con);
            fs.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\config.json", FileMode.Open);
            DataContractJsonSerializer b = new DataContractJsonSerializer(typeof(Config));
            Config con = b.ReadObject(fs) as Config;
            listBox1.Items.Add(con.IPAddress);
            listBox1.Items.Add(con.UserName);
            listBox1.Items.Add(con.DBServer);
            fs.Close();
        }
    }
}
