using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project
{
    public partial class parametre : UserControl
    {
        public parametre()
        {
            InitializeComponent();
        }

        private void parametre_Load(object sender, EventArgs e)
        {
            ComboBox1.Items.Add("COM1");
            ComboBox1.Items.Add("COM2");
            ComboBox1.Items.Add("COM3");
            ComboBox1.Items.Add("COM4");
            ComboBox1.Items.Add("COM5");
            ComboBox1.Items.Add("COM6");
            ComboBox1.Items.Add("COM7");
            ComboBox1.Items.Add("COM8");
            ComboBox1.Items.Add("COM9");
            ComboBox1.Items.Add("COM10");
            ComboBox1.Items.Add("COM11");
            ComboBox1.Items.Add("COM12");
            ComboBox1.Items.Add("COM13");
            comboBox2.Items.Add("587");
            DataSet ds = new DataSet();
            ds.ReadXml("message.xml");
            BunifuCustomDataGrid1.DataSource = ds.Tables[0];
            BunifuMetroTextbox1.Text = BunifuCustomDataGrid1.Rows[0].Cells[0].Value.ToString();
            ComboBox1.Text = BunifuCustomDataGrid1.Rows[0].Cells[1].Value.ToString();
            bool a = Convert.ToBoolean(BunifuCustomDataGrid1.Rows[0].Cells[2].Value);
            bunifuSwitch1.Value = a;
            Cco.url= BunifuCustomDataGrid1.Rows[0].Cells[3].Value.ToString();



            //email
            DataSet ds2 = new DataSet();
            ds2.ReadXml("Email.xml");
            bunifuCustomDataGrid2.DataSource = ds2.Tables[0];
            bunifuMetroTextbox2.Text = bunifuCustomDataGrid2.Rows[0].Cells[0].Value.ToString();
            bunifuMetroTextbox4.Text = bunifuCustomDataGrid2.Rows[0].Cells[1].Value.ToString();
            bunifuMetroTextbox3.Text = bunifuCustomDataGrid2.Rows[0].Cells[2].Value.ToString();
            comboBox2.Text = bunifuCustomDataGrid2.Rows[0].Cells[3].Value.ToString();
            bool a1 = Convert.ToBoolean(bunifuCustomDataGrid2.Rows[0].Cells[4].Value);
            bunifuSwitch2.Value = a1;
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml("message.xml");
            DataRow dr1 = ds.Tables[0].Rows[0];
            dr1["port"] = ComboBox1.Text;
            ds.WriteXml("message.xml");
            DataRow dr2 = ds.Tables[0].Rows[0];
            dr2["sms"] = BunifuMetroTextbox1.Text;
            ds.WriteXml("message.xml");
            MessageBox.Show("update message et port");
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1.ReadXml("Email.xml");
            DataRow dr1 = ds1.Tables[0].Rows[0];
            DataRow dr2 = ds1.Tables[0].Rows[0];
            DataRow dr3 = ds1.Tables[0].Rows[0];
            DataRow dr4 = ds1.Tables[0].Rows[0];
            dr1["email0"] = bunifuMetroTextbox2.Text;
            dr1["msg"] = bunifuMetroTextbox4.Text;
            dr1["pass"] = bunifuMetroTextbox3.Text;
            dr1["port"] = comboBox2.Text;
            ds1.WriteXml("Email.xml");
            MessageBox.Show("update message et port");
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            filiere f = new filiere();
            f.Show();



        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            module m = new module();
            m.Show();
        }
    }
}
