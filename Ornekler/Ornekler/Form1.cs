using Ornekler.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornekler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TSQLDATAEntities db = new TSQLDATAEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Where(x => x.custid == 85 && x.empid == 2).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Where(x => x.shipcountry == "USA" && x.shipcity == "Seattle" && x.empid == 3).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Orders.Where(x => x.shipregion != "WA").ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.OrderByDescending(x => x.unitprice).Skip(10).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.Where(x => x.productname.Contains("a")).ToList();
        }
    }
}
