using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class top_bare : UserControl
    {
        public top_bare()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
    
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

        }
        
        private void top_bare_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
          
           
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
         
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
        

        }

        private void bunifuImageButton6_Click_1(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm");
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
           
        }
    }
}
