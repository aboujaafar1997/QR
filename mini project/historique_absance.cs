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
    public partial class historique_absance : UserControl
    {
        public historique_absance()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        ClassConnexion cnxdata;
        DataTable dt;
        private void historique_absance_Load(object sender, EventArgs e)
        {
            cnxdata = new ClassConnexion();

            GetinfoDGV();









        }
        public void GetinfoDGV()
        {
            dt = cnxdata.GetInfo("select * from absence");
            bunifuCustomDataGrid1.DataSource = dt;
            bunifuCustomDataGrid1.Refresh();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            dv.RowFilter = "NOM_PROF like '%" + textBox2.Text + "%' or NOM_ETUDIANT like '%" + textBox2.Text + "%'" + " or MATIERE like '%" + textBox2.Text + "%'";

            bunifuCustomDataGrid1.DataSource = dv;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            dv.RowFilter = "NOM_PROF like '%" + textBox2.Text + "%' or NOM_ETUDIANT like '%" + textBox2.Text + "%'" + " or MATIERE like '%" + textBox2.Text + "%'";

            bunifuCustomDataGrid1.DataSource = dv;
        }
        public void SupprimerAbsence(int numr)
        {

            cnxdata.ExecuteQr("delete from absence where N="+numr);

        }

        private void bunifSupprimer_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voullez-vous vraimment supprimer ce ligne d'Absence ", "Remarque ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                try
                {
                    int num_insp = int.Parse(bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.SelectedRows[0].Index].Cells[0].Value.ToString());

                    SupprimerAbsence(num_insp);

                    MessageBox.Show("Supression est terminée", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetinfoDGV();
                    bunifuCustomDataGrid1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selectionnez un ligne d'absence  ");
                }
            }
        }
    }
}
