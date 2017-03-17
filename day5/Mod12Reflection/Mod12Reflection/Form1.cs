using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;//<===== 
namespace Mod12Reflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Assembly assembly = Assembly.LoadFrom("filepath");
            Assembly a = Assembly.GetExecutingAssembly();
            
            Type t = a.GetType();
            MemberInfo[] mem = t.GetMethods ();
            foreach (MemberInfo m in mem)
                listBox1.Items.Add(m.Name);
        }
    }
}
