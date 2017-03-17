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

namespace Mod6ReaderWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter w = new StreamWriter(@"c:\text.txt", true, Encoding.UTF8);
            w.Write("Hello");
            w.WriteLine("gOOD");
            w.WriteLine("안녕");
            w.WriteLine("i={0:c} j={1:d5} pi={2:f2}", 10, 20, 1.1234);
            w.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StreamReader r = new StreamReader(@"c:\text.txt");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\text.bin", FileMode.Create);
            BinaryWriter w = new BinaryWriter(fs);
            w.Write(100);

                        w.Write("hello");
            w.Write("안녕");
            w.Write(3.14);
            w.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"c:\text.bin", FileMode.Open, FileAccess.Read) ;
            BinaryReader r = new BinaryReader(fs);
            listBox1.Items.Add(r.ReadInt32());
            listBox1.Items.Add(r.ReadString());
            listBox1.Items.Add(r.ReadString());
            listBox1.Items.Add(r.ReadDouble());
            r.Close();

        }
    }
}
