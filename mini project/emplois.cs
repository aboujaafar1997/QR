using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;
namespace mini_project
{
    public partial class emplois : UserControl
    {
        public emplois()
        {
            InitializeComponent();
        }
        ClassConnexion cnxdata = new ClassConnexion();
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "All Image | *.JPG; *.PNG ; *.JEPG";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                    }

                }
            }
            catch (Exception)
            {

            }
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox1_Click(object sender, EventArgs e)
        {
            bunifuMetroTextbox1.Text = "";
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            var picture = ms.ToArray();

            if (bunifuMetroTextbox1.Text=="" && pictureBox1.Image == null)
            {
                MessageBox.Show("Il faut remplir tous les champs ");
            }
            else
            {

                OracleCommand cmd = new OracleCommand("insert into emplois(NOMF,IMAGE) values('" + bunifuMetroTextbox1.Text + "',:blopImage)", cnxdata.cnx);
                cnxdata.cnx.Open();
                OracleParameter blopImage = new OracleParameter();
                blopImage.ParameterName = "blopImage";
                blopImage.Value = picture;
                cmd.Parameters.Add(blopImage);
                cmd.ExecuteNonQuery();
                cnxdata.cnx.Close();
                MessageBox.Show("Insertion Avec succes ");

            }
            GetDGV();

        }
        DataTable dt;
        private void emplois_Load(object sender, EventArgs e)
        {

            GetDGV();

        }

        public void GetDGV()
        {

            dt = cnxdata.GetInfo("select * from  emplois ");

            bunifuCustomDataGrid1.DataSource = dt;
            ((DataGridViewImageColumn)bunifuCustomDataGrid1.Columns[2]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voullez-vous vraimment supprimer ce Emploi ", "Remarque ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                try
                {

                    int num_insp = int.Parse(bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.SelectedRows[0].Index].Cells[0].Value.ToString());
                    cnxdata.ExecuteQr("delete from emplois where ID=" + num_insp);

                    MessageBox.Show("Supression est terminée", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetDGV();
                    bunifuCustomDataGrid1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selectionnez un etudiant ");
                }
            }


        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            dv.RowFilter = "NOMF like'%" +textBox2Num.Text + "%'";

            bunifuCustomDataGrid1.DataSource = dv;

        }

        private void textBox2Num_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            dv.RowFilter = "NOMF like'%" + textBox2Num.Text + "%'";

            bunifuCustomDataGrid1.DataSource = dv;

        }
    }
}
