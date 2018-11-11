using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RjmLogin
{
    public partial class Form1 : Form
    {
        DataTable StockData = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Stock s = new Stock
            {
               no = Convert.ToInt16(txtNo.Text),
                name = txtName.Text,
                vendor = comvendor.ToString(),
                cost = Convert.ToInt16(txtCost.Text)
            };

            StockData = s.CreatData(StockData);
            dataGridView1.DataSource = StockData;
            txtNo.Text = Convert.ToInt16(s.CreatNo(StockData)).ToString();
        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stock s = new Stock();
            s.AddColumns(StockData);
            txtNo.Text = Convert.ToInt16(s.CreatNo(StockData)).ToString();

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
