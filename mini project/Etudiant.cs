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
    public partial class Etudiant : UserControl
    {
        public Etudiant()
        {
            InitializeComponent();
        }


        ClassConnexion cnxdata = new ClassConnexion();
        DataTable dt;
       
        private void Etudiant_Load(object sender, EventArgs e)
        {
            pnl_Panel.Visible = false;

            ///Remplissage DGV
            ///
            getDGVinfo();

            ///Remplissage Combobox
            ///
            DataTable dtt = cnxdata.GetInfo("select * from Filiere");
            
            foreach(DataRow dr in dtt.Rows)
            {
                ComboBox2.Items.Add(dr[0]);
            }













        }

        private void label1_Click(object sender, EventArgs e) => affichezModifierLib();

        private void affichezModifierLib()
        {
            panel1.Width = label1.Width;
            panel1.Left = label1.Left;
            bunifuCustomDataGrid1.Visible = false;
            pnl_Panel.Visible = true;
            bunifuThinButton28.Visible = false;
            bunifuThinButton29.Visible = false;
            bunifuThinButton210.Visible = false;
            bunifuThinButton26.Visible = true;
            BunifuThinButton21.Visible = false;
            bunifuMetroTextboxNumInscrip.Enabled = true;


            textBox2.Visible = false;
            bunifuImageButton2.Visible = false;



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
            bunifuThinButton26.Visible = false;
            BunifuThinButton21.Visible = true;

            textBox2.Visible = false;
            bunifuImageButton2.Visible = false;

        }

        private void label9_Click(object sender, EventArgs e)=> affichezListe();

        private void affichezListe()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Controls.Remove(pnl_Panel);
            panel2.Location = new Point(125,49);
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
            }catch(Exception)
            {

            }



        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Voullez-vous vraimment supprimer ce etudiant","Remarque ",MessageBoxButtons.YesNo,MessageBoxIcon.Stop)==DialogResult.Yes)
            {
                try
                {

                    string num_insp = bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.SelectedRows[0].Index].Cells[0].Value.ToString();
                    cnxdata.ExecuteQr("delete from etudiant where NUM_INSCRIPTION='" + num_insp+"'");

                    MessageBox.Show("Supression est terminée", "Resultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getDGVinfo();
                    bunifuCustomDataGrid1.Refresh();
                }
                catch (Exception)
                {
                    MessageBox.Show("Selectionnez un etudiant ");
                }
            } 

        }


        public void getDGVinfo()
        {

            dt = cnxdata.GetInfo("select * from etudiant");
            bunifuCustomDataGrid1.DataSource = dt;
            ((DataGridViewImageColumn)bunifuCustomDataGrid1.Columns[11]).ImageLayout = DataGridViewImageCellLayout.Stretch;
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
        public void remplirInfoEtud(String numr)
        {
            DataTable dtinfo = cnxdata.GetInfo("select * from etudiant where NUM_INSCRIPTION='"+numr+"'");

            bunifuMetroTextboxNumInscrip.Text = dtinfo.Rows[0][0].ToString();
            bunifuMetroTextboxNumInscrip.Enabled = false;
            bunifuMetroTextboxNom.Text = dtinfo.Rows[0][1].ToString();
            bunifuMetroTextbox3Prenom.Text = dtinfo.Rows[0][2].ToString(); 
            bunifuMetroTextbox4Tel.Text = dtinfo.Rows[0][3].ToString();
            bunifuMetroTextbox5Email.Text = dtinfo.Rows[0][4].ToString();
            bunifuMetroTextbox6Adresse.Text = dtinfo.Rows[0][5].ToString();
            ComboBox2.SelectedIndex = ComboBox2.Items.IndexOf(dtinfo.Rows[0][6].ToString());
            bunifuMetroTextbox7Cin.Text = dtinfo.Rows[0][7].ToString();
            BunifuDatepicker1.Value = DateTime.Parse(dtinfo.Rows[0][8].ToString());


        }

        public void vider()
        {


            bunifuMetroTextboxNumInscrip.Text = "";
            bunifuMetroTextboxNumInscrip.Enabled = true;
            bunifuMetroTextboxNom.Text = "";
            bunifuMetroTextbox3Prenom.Text = "";
            bunifuMetroTextbox4Tel.Text = "";
            bunifuMetroTextbox5Email.Text = "";
            bunifuMetroTextbox6Adresse.Text = "";
          //  ComboBox2.SelectedIndex = -1;
            bunifuMetroTextbox7Cin.Text = "";
            BunifuDatepicker1.Value = DateTime.Now;


        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            //Ajouter Click
            MemoryStream ms = new MemoryStream();
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
            var picture = ms.ToArray();
            if(bunifuMetroTextboxNumInscrip.Text=="" || bunifuMetroTextboxNom.Text == "" || bunifuMetroTextbox3Prenom.Text == "" || bunifuMetroTextbox4Tel.Text == "" || bunifuMetroTextbox5Email.Text == "" || bunifuMetroTextbox6Adresse.Text == "" || bunifuMetroTextbox7Cin.Text == "")
            {
                MessageBox.Show("Verifier tous les champs");
            }
            else
            {
                string dated = "to_date('"+BunifuDatepicker1.Value.Year+"-"+BunifuDatepicker1.Value.Month+"-"+BunifuDatepicker1.Value.Day+"','yyyy-mm-dd')";
               OracleCommand cmd=new OracleCommand("insert into etudiant values('"+ bunifuMetroTextboxNumInscrip.Text +"','"+ bunifuMetroTextboxNom.Text +"','"+bunifuMetroTextbox3Prenom.Text+"','"+bunifuMetroTextbox4Tel.Text+"','"+bunifuMetroTextbox5Email.Text+"','"+bunifuMetroTextbox6Adresse.Text+"','"+ComboBox2.Text+"','"+bunifuMetroTextbox7Cin.Text+"',"+dated+",0,0,:blopImage)",cnxdata.cnx);
                cnxdata.cnx.Open();
                OracleParameter blopImage = new OracleParameter();
                blopImage.ParameterName = "blopImage";
                blopImage.Value = picture;
                cmd.Parameters.Add(blopImage);
                cmd.ExecuteNonQuery();
                cnxdata.cnx.Close();
                MessageBox.Show("Insertion Avec succes ");
                vider();
            }
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            //Modifier click

            MemoryStream ms = new MemoryStream();
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat);
            var picture = ms.ToArray();
            if (bunifuMetroTextboxNumInscrip.Text == "" || bunifuMetroTextboxNom.Text == "" || bunifuMetroTextbox3Prenom.Text == "" || bunifuMetroTextbox4Tel.Text == "" || bunifuMetroTextbox5Email.Text == "" || bunifuMetroTextbox6Adresse.Text == "" || bunifuMetroTextbox7Cin.Text == "")
            {
                MessageBox.Show("Verifier tous les champs");
            }
            else
            {
                
                string dated = "to_date('" + BunifuDatepicker1.Value.Year + "-" + BunifuDatepicker1.Value.Month + "-" + BunifuDatepicker1.Value.Day + "','yyyy-mm-dd')";
                OracleCommand cmd = new OracleCommand("update etudiant set NOM='" + bunifuMetroTextboxNom.Text + "',PRENOM='" + bunifuMetroTextbox3Prenom.Text + "',TELEPHONE='" + bunifuMetroTextbox4Tel.Text + "',E_MAIL='" + bunifuMetroTextbox5Email.Text + "',ADRESSE='" + bunifuMetroTextbox6Adresse.Text + "',FILIERE='" + ComboBox2.Text+ "',CIN='" + bunifuMetroTextbox7Cin.Text + "',DATEE=" + dated + ",Image=:blopImage where NUM_INSCRIPTION='" + bunifuMetroTextboxNumInscrip.Text+"'",cnxdata.cnx);
                cnxdata.cnx.Open();
                OracleParameter blopImage = new OracleParameter();
                blopImage.ParameterName = "blopImage";
                blopImage.Value = picture;
                cmd.Parameters.Add(blopImage);

                cmd.ExecuteNonQuery();
                cnxdata.cnx.Close();
                 
                MessageBox.Show("Modification Avec succes ");

            }
        }

        private void bunifuMetroTextboxNumInscrip_Click(object sender, EventArgs e)
        { 
            vider();
            PictureBox1.Image = null;
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

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                string num_insp = bunifuCustomDataGrid1.Rows[bunifuCustomDataGrid1.SelectedRows[0].Index].Cells[0].Value.ToString();
                fiche f = new fiche();
                f.Show();
                f.getinfoEtud(num_insp);

            }
            catch (Exception)
            {

                MessageBox.Show("Selectionnez un etudiant ");
            }
        }
    }
}
