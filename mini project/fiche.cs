using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mini_project
{
    public partial class fiche : Form
    {
        public fiche()
        {
            InitializeComponent();
        }
        ClassConnexion cnxdata;
        Cco c = new Cco();
        DataTable dt;
        private void fiche_Load(object sender, EventArgs e)
        {
            cnxdata = new ClassConnexion();
        }
        public void getinfoEtud(string numr)
        {
            dt = cnxdata.GetInfo("select * from etudiant where NUM_INSCRIPTION='"+numr+"'");
            label1.Text = dt.Rows[0][1] + " " + dt.Rows[0][2];
            label6Email.Text = dt.Rows[0][4].ToString();
            label7Numero.Text = dt.Rows[0][3].ToString();
            label8Filiere.Text = dt.Rows[0][6].ToString();

            try
            {
                DataTable dtAbsProf = cnxdata.GetInfo("select count(*) from absence where n_prof='" + Cco.cin + "' and n_etudiant='" + numr + "' group by n_prof");
                label10absence.Text = dtAbsProf.Rows[0][0].ToString();
            }
            catch (Exception)
            {
                label10absence.Text = "0";
            }
            ////////////////////////
            try
            {
                DataTable dtAbsYear = cnxdata.GetInfo("select count(*) from absence where n_prof = '" + Cco.cin + "' and n_etudiant = '" + numr + "' and  extract(year from datea)=extract(Year from SYSDATE) group by n_prof");
                label18nombretotalabs.Text = dtAbsYear.Rows[0][0].ToString();
               
            }
            catch (Exception)
            {
                label18nombretotalabs.Text = "0";
            }
             
            MemoryStream ms = new MemoryStream((byte[])dt.Rows[0][11]);
            pb_Photo.Image = Image.FromStream(ms);
            dt.Rows.Clear();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
