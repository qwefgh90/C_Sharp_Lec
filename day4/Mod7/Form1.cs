using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mod7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = { 3, 4, 12, 5, 7, 8 };
            var n = from i in a
                    where i % 2 == 0
                    orderby i
                    select i;
            foreach (int i in n)
            {
                listBox1.Items.Add(i);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            FourthCoffeeEntities db = new FourthCoffeeEntities();
            var r = from a in db.Employees
                    select a;
            foreach (Employees ee in r)
                listBox1.Items.Add(ee.EmployeeID + "\t" + ee.FirstName);

            //binding
            dataGridView1.DataSource = r.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FourthCoffeeEntities db = new FourthCoffeeEntities();
            int num = int.Parse(textBox1.Text);
            var r = (from a in db.Employees
                     where a.EmployeeID == num
                     select a).FirstOrDefault();
            r.FirstName = "Hong";
            db.SaveChanges();
            //MessageBox.Show(r.FirstName + "\n" + r.LastName);
            button2.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //추가
            FourthCoffeeEntities db = new FourthCoffeeEntities();
            Employees em = new Employees();
            em.FirstName = "Chan";
            em.LastName = "Park";
            em.EmployeeID = 9999;
            db.Employees.Add(em);
            db.SaveChanges();

            button2.PerformClick();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }
            FourthCoffeeEntities db = new FourthCoffeeEntities();
            int id = int.Parse(listBox1.SelectedItem.ToString().Split()[0]);
            var r = db.Employees.First(ee => ee.EmployeeID == id);
            if (r != null)
            {
                db.Employees.Remove(r);
                db.SaveChanges();
                button2.PerformClick();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FourthCoffeeEntities db = new FourthCoffeeEntities();
            var emps = from a in db.Employees
                        group a by a.JobTitle into eGroup
                        select new { Job = eGroup.Key, Names = eGroup, Num = eGroup.Count() };
            foreach (var ee in emps)
            {
                listBox1.Items.Add(ee.Job);
                foreach (var name in ee.Names)
                {
                    listBox1.Items.Add(name.FirstName + "\t" + name.LastName);
                }

            }
        }
    }
}/*
이 대화 상자 대신 JIT(Just-in-time) 디버깅을 호출하는
방법에 대한 자세한 내용은 이 메시지의 뒷부분을 참조하십시오.

************** 예외 텍스트 **************
System.ArgumentNullException: 값은 null일 수 없습니다.
매개 변수 이름: item
   위치: System.Windows.Forms.ListBox.ObjectCollection.AddInternal(Object item)
   위치: System.Windows.Forms.ListBox.ObjectCollection.Add(Object item)
   위치: Mod7.Form1.button6_Click(Object sender, EventArgs e) 파일 c:\csharp\project\day4\Mod7\Form1.cs:줄 102
   위치: System.Windows.Forms.Control.OnClick(EventArgs e)
   위치: System.Windows.Forms.Button.OnClick(EventArgs e)
   위치: System.Windows.Forms.Button.OnMouseUp(MouseEventArgs mevent)
   위치: System.Windows.Forms.Control.WmMouseUp(Message& m, MouseButtons button, Int32 clicks)
   위치: System.Windows.Forms.Control.WndProc(Message& m)
   위치: System.Windows.Forms.ButtonBase.WndProc(Message& m)
   위치: System.Windows.Forms.Button.WndProc(Message& m)
   위치: System.Windows.Forms.Control.ControlNativeWindow.OnMessage(Message& m)
   위치: System.Windows.Forms.Control.ControlNativeWindow.WndProc(Message& m)
   위치: System.Windows.Forms.NativeWindow.Callback(IntPtr hWnd, Int32 msg, IntPtr wparam, IntPtr lparam)


************** 로드된 어셈블리 **************
mscorlib
    어셈블리 버전: 4.0.0.0
    Win32 버전: 4.0.30319.18408 built by: FX451RTMGREL
    코드베이스: file:///C:/Windows/Microsoft.NET/Framework/v4.0.30319/mscorlib.dll
----------------------------------------
Mod7
    어셈블리 버전: 1.0.0.0
    Win32 버전: 1.0.0.0
    코드베이스: file:///C:/csharp/project/day4/Mod7/bin/Debug/Mod7.exe
----------------------------------------
System.Windows.Forms*/