using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod3Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<int> al = new List<int>();
            //ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(10);
            al.Add(10);
            al.Add(10);
            foreach(int i in al)
            {
                listBox1.Items.Add(i);
            }

            ///ArrayList list = new ArrayList();
            List<string> list = new List<string>();
            list.Add("apple");
            list.Add("bear");
            list.Add("car");
            foreach (string s in list)
                listBox1.Items.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> table = new Dictionary<int, string>();
            //Hashtable table = new Hashtable();
            table.Add(1, "hong");
            table.Add(3, "park");
            table.Add(2, "lee");
            //table.Add(2, "lee");
            foreach (KeyValuePair<int,string> d in table)
                listBox1.Items.Add(d.Key + "\t" + d.Value);
            if (table.ContainsValue("park"))
            {
                listBox1.Items.Add("park is found");
            }else
            {
                listBox1.Items.Add("park is not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            listBox1.Items.Add(s.Pop());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("apple");
            q.Enqueue("banana");
            q.Enqueue("car");
            listBox1.Items.Add(q.Dequeue());
        }
    }
}
