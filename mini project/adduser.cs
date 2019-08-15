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
    public partial class adduser : UserControl
    {
        public adduser()
        {
            InitializeComponent();
        }
        ClassConnexion cnxdata = new ClassConnexion();
        DataTable dt;
        private void adduser_Load(object sender, EventArgs e)
        {

            //Remplir Dgv
            getinfoDGV();
        }
        public void getinfoDGV()
        {
            dt = cnxdata.GetInfo("select * from utilisateur");
            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Refresh();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            dv.RowFilter = "id like'%" + textBox2.Text + "%'" ;

            bunifuCustomDataGrid1.DataSource = dv;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            dv.RowFilter = "id like'%" + textBox2.Text + "%'";

            bunifuCustomDataGrid1.DataSource = dv;
        }

        private void bunifuMetroTextbox1_Click(object sender, EventArgs e)
        {
            vider();
        }
        public void vider()
        {

            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox2.Text = "";
        }
        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voullez-vous vraimment supprimer ce utilisateur ", "Remarque ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                try
                {

                    string num_insp = bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.SelectedRows[0].Index].Cells[0].Value.ToString();
                    cnxdata.ExecuteQr("delete from utilisateur where ID='" + num_insp + "'");

                    MessageBox.Show("Supression est terminée", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getinfoDGV();
                    bunifuCustomDataGrid1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selectionnez un utilisateur ");
                }
            }

        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if(bunifuMetroTextbox2.Text=="" ||bunifuMetroTextbox1.Text=="")
            {
                MessageBox.Show("Verifier les champs");
            }
            else
            {


                cnxdata.ExecuteQr("insert into utilisateur values('"+bunifuMetroTextbox1.Text+"','"+bunifuMetroTextbox2.Text+"')");
                MessageBox.Show("Insertion terminé avec succes");
                getinfoDGV();
                vider();


            }
        }
    }
}
