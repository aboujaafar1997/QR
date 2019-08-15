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
    public partial class left_bare : UserControl
    {
        int a = 1;
        public left_bare()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Image img = bunifuImageButton1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            bunifuTransition1.ShowSync(bunifuImageButton1);
            bunifuImageButton1.Image = img;
            
         
            if (a == 1)
            {


                this.Size = new System.Drawing.Size(78, 850);
                Form1.p1.panel2.Location = new Point(100,50);
                Form1.p1.panel1.BringToFront();



                a = a * (-1);
            }
            else
            {

                this.Visible = false;
                bunifuTransition1.ShowSync(this);

                this.Size = new System.Drawing.Size(191, 850);
                Form1.p1.panel2.Location = new Point(200, 55);
                this.BringToFront();
                Form1.p1.panel1.BringToFront();
                a = a * (-1);
              



            }

        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton9.Top;
            Panel3.Height = bunifuFlatButton9.Height;
            Form1.p1.etudiant1.BringToFront();
            Form1.p1.etudiant1.BringToFront();
            Form1.p1.etudiant1.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.etudiant1);
            Form1.p1.etudiant1.BringToFront();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton1.Top;
            Panel3.Height = bunifuFlatButton1.Height;
            Form1.p1.profs1.BringToFront();
            Form1.p1.profs1.BringToFront();
            Form1.p1.profs1.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.profs1);
            Form1.p1.profs1.BringToFront();
        }

        private void BunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton8.Top;
            Panel3.Height = BunifuFlatButton8.Height;
            //QR qr = new mini_project.QR();
            //qr.Show();
           
            Form1.p1.add1.BringToFront();
            Form1.p1.add1.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.add1);
            Form1.p1.add1.BringToFront();

        }

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Panel3.Top = BunifuFlatButton3.Top;
            Panel3.Height = BunifuFlatButton3.Height;

            Form1.p1.historique_absance2.BringToFront();
            Form1.p1.historique_absance2.BringToFront();
            Form1.p1.historique_absance2.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.historique_absance2);
            Form1.p1.historique_absance2.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton2.Top;
            Panel3.Height = bunifuFlatButton2.Height;
            Form1.p1.adduser1.BringToFront();
            Form1.p1.adduser1.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.adduser1);
            Form1.p1.adduser1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton4.Top;
            Panel3.Height = bunifuFlatButton4.Height;
            Form1.p1.emplois2.BringToFront();
            Form1.p1.emplois2.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.emplois2);
            Form1.p1.emplois2.BringToFront();

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton5.Top;
            Panel3.Height = bunifuFlatButton5.Height;
            Form1.p1.parametre1.BringToFront();
            Form1.p1.parametre1.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.parametre1);
            Form1.p1.parametre1.BringToFront();

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton6.Top;
            Panel3.Height = bunifuFlatButton6.Height;
            Form1.p1.statistique1.BringToFront();
            Form1.p1.statistique1.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.statistique1);
            Form1.p1.statistique1.BringToFront();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton6.Top;
            Panel3.Height = bunifuFlatButton6.Height;
            Form1.p1.aceuil1.BringToFront();
            Form1.p1.aceuil1.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.aceuil1);
            Form1.p1.aceuil1.BringToFront();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Panel3.Top = bunifuFlatButton7.Top;
            Panel3.Height = bunifuFlatButton7.Height;
            Form1.p1.historique1.BringToFront();
            Form1.p1.historique1.Visible = false;
            bunifuTransition1.ShowSync(Form1.p1.historique1);
            Form1.p1.historique1.BringToFront();
        }
    }
}
