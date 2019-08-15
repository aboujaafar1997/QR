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
    public partial class principale : Form
    {
        public emplois emplois2 = new emplois();
        //public static add add1 = new add(); 
        public principale()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        private void left_bare1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void principale_Load(object sender, EventArgs e)

        {
            Bunifu.Framework.UI.BunifuDragControl e1 = new Bunifu.Framework.UI.BunifuDragControl();
            Bunifu.Framework.UI.BunifuDragControl e2 = new Bunifu.Framework.UI.BunifuDragControl();
            e1.TargetControl = panel1;
            e2.TargetControl = panel1;
            Bunifu.Framework.UI.BunifuDragControl e3 = new Bunifu.Framework.UI.BunifuDragControl();
            e2.TargetControl = Form1.p1.left_bare1;
            /////////////////////
            this.panel2.Controls.Add(add1); 
            this.add1.Location  = new System.Drawing.Point(-1, -4);
            add1.Name = "add1";
            add1.Size = new System.Drawing.Size(906, 624);
            add1.TabIndex = 15;
            ///////////////////////
            
            this.panel2.Controls.Add(emplois2);
            this.emplois2.Location = new System.Drawing.Point(-1, -4);
            emplois2.Name = "emplois2";
            emplois2.Size = new System.Drawing.Size(906, 624);
            emplois2.TabIndex = 16;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parametre1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            

        }
    }
}
