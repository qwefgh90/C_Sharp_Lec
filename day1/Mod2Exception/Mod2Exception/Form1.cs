using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod2Exception
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);
                if (y < 0 || y > 100)
                {
                    throw new ArgumentOutOfRangeException("1-100 사이의 숫자를 입력하세요.");
                }
                int r = x / y;
                label1.Text = r.ToString();
            }
            catch (DivideByZeroException ex)
            {
                label1.Text = ex.Message;
            }
            catch (Exception ex)
            {
                label1.Text = ex.Message;
            }
            catch
            {

            }
            finally
            {

            }
            MessageBox.Show("Good Job");
        }
    }
}
