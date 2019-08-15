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
    public partial class file_d_attents : Form
    {
        int current_indx = 1;
        public file_d_attents()
        {
            InitializeComponent();
        }

        private void file_d_attents_Load(object sender, EventArgs e)
        {
            bunifuCustomDataGrid1.Visible = true;
            bunifuCustomDataGrid2.Visible = false;
            bunifuThinButton28.Visible = false;
            bunifuThinButton21.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (current_indx == 1)
            {
                bunifuCustomDataGrid1.Visible = false;
                bunifuCustomDataGrid2.Visible = true;
                bunifuThinButton28.Visible = true;
                bunifuThinButton21.Visible = false;
                current_indx++;
                label2.Text = "" + current_indx;
            }

            else if (current_indx == 2)
            {
                bunifuCustomDataGrid1.Visible = false;
                bunifuCustomDataGrid2.Visible = false;
                bunifuThinButton28.Visible = false;
                bunifuThinButton21.Visible = true;
                current_indx++;
                label2.Text = "" + current_indx;
            }

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (current_indx == 3)
            {
                bunifuCustomDataGrid1.Visible = false;
                bunifuCustomDataGrid2.Visible = true;
                bunifuThinButton28.Visible = true;
                bunifuThinButton21.Visible = false;
                current_indx--;
                label2.Text = "" + current_indx;
            }
            else if (current_indx == 2)
            {
                bunifuCustomDataGrid1.Visible = true;
                bunifuCustomDataGrid2.Visible = false;
                bunifuThinButton28.Visible = false;
                bunifuThinButton21.Visible = false;
                current_indx--;
                label2.Text = ""+ current_indx;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
