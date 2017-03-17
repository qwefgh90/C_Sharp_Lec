using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mod8WCFClient.FourthCoffeeDataService;

namespace Mod8WCFClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FourthCoffeeEntities db = new FourthCoffeeEntities(new Uri("http://localhost:59620/FourthCoffeeDataService.svc"));
            var r = from a in db.Employees
                    select a;
            foreach(Employees ee in r){
                listBox1.Items.Add(ee.EmployeeID + "\t" + ee.FirstName);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            FourthCoffeeEntities db = new FourthCoffeeEntities(new Uri("http://localhost:59620/FourthCoffeeDataService.svc"));
            
            var es = db.Execute<Employees>(new Uri("http://localhost:59620/FourthCoffeeDataService.svc/AllEmployees"));
            foreach (Employees ee in es)
            {
                listBox1.Items.Add(ee.EmployeeID + "\t" + ee.FirstName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            FourthCoffeeEntities db = new FourthCoffeeEntities(new Uri("http://localhost:59620/FourthCoffeeDataService.svc"));
            var es = db.Execute<Employees>(new Uri("http://localhost:59620/FourthCoffeeDataService.svc/EmployeesByID?id="+textBox1.Text));
            foreach (Employees ee in es)
            {
                listBox1.Items.Add(ee.EmployeeID + "\t" + ee.FirstName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FourthCoffeeEntities db = new FourthCoffeeEntities(new Uri("http://localhost:59620/FourthCoffeeDataService.svc"));
            Employees ee = new Employees();
            ee.FirstName = "hog";
            ee.LastName = "hog";
            ee.EmployeeID = 99;
            db.AddToEmployees(ee);
            db.SaveChanges();
            button1.PerformClick();

        }
    }
}
