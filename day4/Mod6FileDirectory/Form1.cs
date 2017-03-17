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

namespace Mod6FileDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text.Trim());
            if (!dir.Exists)
            {
                if (MessageBox.Show("해당 디렉토리가 없습니다.", "?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    dir.Create();
                else
                    return;
            }
            //파일 정보
            FileInfo[] files = dir.GetFiles();
            listBox1.Items.Clear();
            foreach (FileInfo f in files)
                listBox1.Items.Add(f.FullName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo d in dirs)
                listBox1.Items.Add(d.FullName);
            MessageBox.Show(string.Format("{0}개의 파일이 존재합니다.", files.Length + dirs.Length));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //삭제
            if (listBox1.SelectedIndex >= 0)
            {
                string path = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());
                if (Directory.Exists(path))
                    Directory.Delete(path);
                else if (File.Exists(path))
                    File.Delete(path);

                button1.PerformClick();
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //복사
            //File.Copy(@"..\..\Form1.cs", @"C:\Form1.cs");
            FileInfo f = new FileInfo(@"..\..\Form1.cs");
            if (f.Exists)
            {
                DirectoryInfo dir = new DirectoryInfo(@"c:\temp");
                if (dir.Exists)
                    f.CopyTo(Path.Combine(dir.FullName, f.Name), true);
                else
                    MessageBox.Show("해당 디렉토리가 없습니다.");
            }
            else
            {
                MessageBox.Show("해당 디렉토리가 없습니다.");
            }
        }
    }
}
