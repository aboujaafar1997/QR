using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OracleClient;

namespace mini_project
{
    public partial class profs : UserControl
    {
        public profs()
        {
            InitializeComponent();
        }
        ClassConnexion cnxdata=new ClassConnexion();
        DataTable dt;
        private void label9_Click(object sender, EventArgs e)
        {
            panel1.Width = label9.Width;
            panel1.Left = label9.Left;
            bunifuThinButton28.Visible = true;
            bunifuThinButton29.Visible = true;
            bunifuThinButton210.Visible = true;
            bunifuCustomDataGrid1.Visible = true;
            bunifuCustomDataGrid1.BringToFront();
            bunifuCustomDataGrid1.Visible = false;
            bunifuTransition1.ShowSync(bunifuCustomDataGrid1);
            bunifuCustomDataGrid1.BringToFront();
            pnl_Panel.Visible = false;



            textBox2.Visible = true;
            bunifuImageButton2.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Width = label1.Width;
            panel1.Left = label1.Left;
            bunifuCustomDataGrid1.Visible = false;
            pnl_Panel.Visible = true;
            bunifuThinButton28.Visible = false;
            bunifuThinButton29.Visible = false;
            bunifuThinButton210.Visible = false;
            BunifuThinButton21.Visible = false;
            textBox2.Visible = false;
            bunifuImageButton2.Visible = false;
            vider();
            //26 true
            //21 false;

            bunifuThinButton26.Visible = true;
            BunifuThinButton21.Visible = false;




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controls.Remove(pnl_Panel);
            panel2.Location = new Point(125, 49);
        }
        
        private void profs_Load(object sender, EventArgs e)
        {
            pnl_Panel.Visible = false;

             
            //Remplissage DGV


            getDGVinfo();









        }

        private void getDGVinfo()
        {
            dt = cnxdata.GetInfo("select * from professeur");
            bunifuCustomDataGrid1.DataSource = dt;
            ((DataGridViewImageColumn)bunifuCustomDataGrid1.Columns[7]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pnl_Panel.Visible = false;
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            getDGVinfo();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            dv.RowFilter = "nom like'%" + textBox2.Text + "%' or prenom like '%" + textBox2.Text + "%'"; ;

            bunifuCustomDataGrid1.DataSource = dv;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            DataView dv = new DataView(dt);

            dv.RowFilter = "nom like'%" + textBox2.Text + "%' or prenom like '%" + textBox2.Text + "%'"; ;

            bunifuCustomDataGrid1.DataSource = dv;
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            try
            {
                affichezModifier();

                remplirInfoEtud(bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.SelectedRows[0].Index].Cells[0].Value.ToString());


            }
            catch (Exception)
            {
                MessageBox.Show("Selectionnez un etudiant ");
            }
        }

        private void affichezModifier()
        {

            panel1.Width = label1.Width;
            panel1.Left = label1.Left;
            bunifuCustomDataGrid1.Visible = false;
            pnl_Panel.Visible = true;
            bunifuThinButton28.Visible = false;
            bunifuThinButton29.Visible = false;
            bunifuThinButton210.Visible = false;
            BunifuThinButton21.Visible = true;
            bunifuThinButton26.Visible = false;
            textBox2.Visible = false;
            bunifuImageButton2.Visible = false;
        }

        public void remplirInfoEtud(String numr)
        {
            vider();
            DataTable dtinfo = cnxdata.GetInfo("select * from professeur where CIN='" + numr + "'");
            bunifuMetroTextbox1.Text = dtinfo.Rows[0][0].ToString();
            bunifuMetroTextbox2.Text = dtinfo.Rows[0][1].ToString();
            bunifuMetroTextbox3.Text = dtinfo.Rows[0][2].ToString();
            bunifuMetroTextbox4.Text = dtinfo.Rows[0][3].ToString();
            bunifuMetroTextbox5.Text = dtinfo.Rows[0][4].ToString();
            bunifuMetroTextbox6.Text = dtinfo.Rows[0][5].ToString();
            BunifuDatepicker1.Value = DateTime.Parse(dt.Rows[0][6].ToString()); 
            try
            {
                Byte[] img = ((Byte[])dtinfo.Rows[0][7]);
                MemoryStream ms = new MemoryStream(img);
                PictureBox1.Image = Image.FromStream(ms);

            }
            catch (Exception)
            {
                PictureBox1.Image = null;
            }
            dtinfo.Rows.Clear();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Voullez-vous vraimment supprimer ce professeur", "Remarque ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                try
                {
                    string num_insp = bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.SelectedRows[0].Index].Cells[0].Value.ToString();

                    cnxdata.ExecuteQr("delete from professeur where CIN='" + num_insp+"'");

                    MessageBox.Show("Supression est terminée", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    getDGVinfo();
                    bunifuCustomDataGrid1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selectionnez un professeur ");
                }
            }

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

            //Ajouter Click
            MemoryStream ms = new MemoryStream();
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
            var picture = ms.ToArray();
            if ( bunifuMetroTextbox1.Text == "" || bunifuMetroTextbox2.Text == "" || bunifuMetroTextbox3.Text == "" || bunifuMetroTextbox4.Text == "" || bunifuMetroTextbox5.Text == "" || bunifuMetroTextbox6.Text == "")
            {
                MessageBox.Show("Verifier tous les champs");
            }
            else
            {
                string dated = "to_date('" + BunifuDatepicker1.Value.Year + "-" + BunifuDatepicker1.Value.Month + "-" + BunifuDatepicker1.Value.Day + "','yyyy-mm-dd')";
                OracleCommand cmd = new OracleCommand("insert into professeur values('" + bunifuMetroTextbox1.Text + "','" + bunifuMetroTextbox2.Text + "','" + bunifuMetroTextbox3.Text + "','" + bunifuMetroTextbox4.Text + "','" + bunifuMetroTextbox5.Text + "','" + bunifuMetroTextbox6.Text+ "'," + dated + ",:blopImage)", cnxdata.cnx);
                cnxdata.cnx.Open();
                OracleParameter blopImage = new OracleParameter();
                blopImage.ParameterName = "blopImage";
                blopImage.Value = picture;
                cmd.Parameters.Add(blopImage);
                cmd.ExecuteNonQuery();
                cnxdata.cnx.Close();
                MessageBox.Show("Insertion Avec succes ");
                vider();

                getDGVinfo();
                bunifuCustomDataGrid1.Refresh();
            }

        }
        public void vider()
        {


            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox2.Text = "";
            bunifuMetroTextbox3.Text = "";
            bunifuMetroTextbox4.Text = "";
            bunifuMetroTextbox6.Text = "";
            bunifuMetroTextbox5.Text = "";
            BunifuDatepicker1.Value = DateTime.Now;


        }

        private void bunifuMetroTextbox1_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            //Modifier click

            MemoryStream ms = new MemoryStream();
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
            var picture = ms.ToArray();
            if (bunifuMetroTextbox1.Text == "" || bunifuMetroTextbox2.Text == "" || bunifuMetroTextbox3.Text == "" || bunifuMetroTextbox4.Text == "" || bunifuMetroTextbox5.Text == "" || bunifuMetroTextbox6.Text == "")
            {
                MessageBox.Show("Verifier tous les champs");
            }
            else
            {

                string dated = "to_date('" + BunifuDatepicker1.Value.Year + "-" + BunifuDatepicker1.Value.Month + "-" + BunifuDatepicker1.Value.Day + "','yyyy-mm-dd')";
                OracleCommand cmd = new OracleCommand("update professeur set NOM='" + bunifuMetroTextbox2.Text + "',PRENOM='" + bunifuMetroTextbox3.Text + "',E_MAIL='" + bunifuMetroTextbox4.Text + "',TELEPHONE='" + bunifuMetroTextbox5.Text + "',ADRESSE='" + bunifuMetroTextbox6.Text+ "',DATEP=" + dated + ",Image=:blopImage where CIN='" + bunifuMetroTextbox1.Text + "'", cnxdata.cnx);
                cnxdata.cnx.Open();
                OracleParameter blopImage = new OracleParameter();
                blopImage.ParameterName = "blopImage";
                blopImage.Value = picture;
                cmd.Parameters.Add(blopImage);

                cmd.ExecuteNonQuery();
                cnxdata.cnx.Close();

                MessageBox.Show("Modification Avec succes ");

                getDGVinfo();
                bunifuCustomDataGrid1.Refresh();

            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog1.Filter = "All Image | *.JPG; *.PNG ; *.JEPG";
                if (OpenFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (OpenFileDialog1.CheckFileExists)
                    {
                        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName);
                    }

                }
            }
            catch (Exception)
            {

            }
        }
    }
}
