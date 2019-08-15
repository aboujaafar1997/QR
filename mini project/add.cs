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
    public partial class add : UserControl
    {
        public add()
        {
            InitializeComponent();
        }
          private void add_Load(object sender, EventArgs e)
        {
            ClassConnexion cnx = new ClassConnexion();
            label1.Text = Form1.p1.label15.Text;
            label7.Text = Cco.cin;
            bunifuDropdown1.AddItem("8");
            bunifuDropdown1.AddItem("9");
            bunifuDropdown1.AddItem("10");
            bunifuDropdown1.AddItem("11");
            bunifuDropdown1.AddItem("12");
            bunifuDropdown1.AddItem("13");
            bunifuDropdown1.AddItem("14");
            bunifuDropdown1.AddItem("15");
            bunifuDropdown1.AddItem("16");
            bunifuDropdown1.AddItem("17");
            bunifuDropdown1.AddItem("18");
            bunifuDropdown2.AddItem("8");
            bunifuDropdown2.AddItem("9");
            bunifuDropdown2.AddItem("10");
            bunifuDropdown2.AddItem("11");
            bunifuDropdown2.AddItem("12");
            bunifuDropdown2.AddItem("13");
            bunifuDropdown2.AddItem("14");
            bunifuDropdown2.AddItem("15");
            bunifuDropdown2.AddItem("16");
            bunifuDropdown2.AddItem("17");
            bunifuDropdown2.AddItem("18");
            bunifuDropdown5.AddItem("cours");
            bunifuDropdown5.AddItem("TP");
            bunifuDropdown5.AddItem("TD");
            bunifuDropdown1._BorderRadius = 50;


          

            /////////////////filiere//////////////
            DataTable dtt = cnx.GetInfo("select * from Filiere");

            foreach (DataRow dr in dtt.Rows)
            {
                bunifuDropdown4.AddItem(dr[0].ToString());
            }

        DataTable dt = cnx.GetInfo("select * from matiere");

            foreach (DataRow dr in dt.Rows)
            {
                bunifuDropdown3.AddItem(dr[1].ToString());
            }
            bunifuDropdown1.selectedIndex = 0;
            bunifuDropdown2.selectedIndex = 0;
            bunifuDropdown3.selectedIndex = 0;
            bunifuDropdown4.selectedIndex = 0;
            bunifuDropdown5.selectedIndex = 0;


        }




        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            
          //  string matiere = bunifuDropdown3.selectedValue.ToString();
            string type = bunifuDropdown5.selectedValue.ToString();
            string heur = bunifuDropdown1.selectedValue.ToString() + "-" + bunifuDropdown2.selectedValue.ToString();

           QR qr = new mini_project.QR("FR",type,heur);
            qr.Show();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        { }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
