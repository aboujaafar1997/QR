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
    public partial class QR : Form
    {
        string url1;



        public QR(string matiere,string type,string heur )
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = Screen.PrimaryScreen.Bounds.Width / 2;
            this.Location = new Point(0, 0);
            url1 = Cco.url + "?cinp=" + Cco.cin + "&nomp=" + Form1.p1.label15.Text + "&matiere=" + matiere + "&type=" + type + "&heur=" + heur;
                

        }

        private void QR_Load(object sender, EventArgs e)
        {
            
            file_d_attents f = new file_d_attents();
            f.StartPosition = FormStartPosition.Manual;
            f.Height = Screen.PrimaryScreen.Bounds.Height;
            f.Width = Screen.PrimaryScreen.Bounds.Width / 2;
            f.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, 0);
            Zen.Barcode.CodeQrBarcodeDraw qr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qr.Draw(url1, 50);
            f.Show();
        }
    }
}
