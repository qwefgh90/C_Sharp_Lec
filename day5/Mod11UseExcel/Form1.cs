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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace Mod11UseExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
            Excel.Workbook wb = excelApp.Workbooks.Add();
            Excel.Worksheet sheet = wb.Worksheets.get_Item(1) as Excel.Worksheet;
            sheet.Cells[1, 1] = "Hello";
            sheet.Cells[1, 2] = "World";

            FileInfo f = new FileInfo(@"c:\test.xls");
            if (f.Exists)
                f.Delete();
            sheet.SaveAs(f.FullName);
            wb.Close();
            excelApp.Quit();
        }

        [DllImport("user32.dll", EntryPoint="MessageBox")]
        public static extern int APIMessageBox(int h, string text, string caption, uint type);
        
        private void button2_Click(object sender, EventArgs e)
        {
            APIMessageBox(0, "Hello", "Test", 0);
        }
    }
}
