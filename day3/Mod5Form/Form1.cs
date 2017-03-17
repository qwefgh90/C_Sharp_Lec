using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod5Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();// this.Dispose
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("정말로 종료?", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
                base.OnFormClosing(e);
            else
                e.Cancel = true;
        }
    }
}
