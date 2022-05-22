using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       


        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(@"http://www.tcmb.gov.tr/kurlar/" + dateTimePicker1.Text + ".xml");
            dataGridView1.DataSource = dataSet.Tables[1];
            dataGridView1.Columns[0].HeaderText = "Birim";
            dataGridView1.Columns[1].HeaderText = "Döviz Cinsi";
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Döviz Alış";
            dataGridView1.Columns[4].HeaderText = "Döviz Satış";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        

            comboBox1.DataSource = dataSet.Tables[1];
            comboBox1.DisplayMember = "Isim";




        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
