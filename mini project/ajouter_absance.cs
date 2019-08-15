using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project
{
    public partial class ajouter_absance : Form
    {
        public ajouter_absance()
        {
            InitializeComponent();
        }

        private void ajouter_absance_Load(object sender, EventArgs e)
        {
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

        }
    }
}
