using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project
{
    public partial class Form1 : Form
    {
        Cco c = new Cco();
        int i=0;
        static public principale p1;

        public Form1()
        {

            InitializeComponent();
            p1 = new principale();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int a = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 1) {
                pictureBox1.Visible = true;
                pictureBox4.Visible = false;
                a = a * -1;
            }
            else
            {
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                a = a * -1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            
            string cin = "";

            try
            {
                DataTable dt1 = new DataTable();
                Cco.adapter = new OracleDataAdapter("select * from utilisateur where ID ='" +bunifuMetroTextbox4.Text + "' and PWD ='"+ bunifuMetroTextbox3.Text+ "'", Cco.cn);
               // Cco.adapter.SelectCommand.Parameters.Add(new OracleParameter("@ID", OracleType.VarChar, 50)).Value = bunifuMetroTextbox4.Text;
                //Cco.adapter.SelectCommand.Parameters.Add(new OracleParameter("@PWD", OracleType.VarChar, 50)).Value = bunifuMetroTextbox3.Text;
                Cco.adapter.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {


                    notifyIcon1.ShowBalloonTip(20, "Beinvenu", bunifuMetroTextbox4.Text, ToolTipIcon.Info);

                    //recuperation de cin de prof -----------------------------------------------------------------------
                  
                    Cco.cn.Open();

                    Cco.cmd = new OracleCommand("select CIN,image from professeur where NOM='" + bunifuMetroTextbox4.Text + "'or Prenom='" + bunifuMetroTextbox4.Text + "'", Cco.cn);
                    
                    OracleDataReader da = Cco.cmd.ExecuteReader();

                    while (da.Read()) {

                        cin = da.GetString(0);
                        MemoryStream ms = new MemoryStream((byte[])da[1]);
                        Form1.p1.pictureBox1.Image = Image.FromStream(ms);
                        Form1.p1.label15.Text = bunifuMetroTextbox4.Text;
                     

                    }

               
                    Cco.cn.Close();
                    //---------------------------------------fin de recuperation------------------------------------------

                    if (bunifuMetroTextbox4.Text!= "admin") { 
                    //-------------------------------------insertion dans lihstorique----------------------------------
                    Cco.cmd = new OracleCommand("INSERT INTO historique(CIN,NOM,DATEH) values('" +cin+ "' , '"+ bunifuMetroTextbox4.Text +"' ,'" + DateTime.Now+"' )", Cco.cn);
                   // Cco.cmd.Parameters.Add(new OracleParameter("@ID", OracleType.VarChar, 30)).Value = bunifuMetroTextbox4.Text;
                    //Cco.cmd.Parameters.Add(new OracleParameter("@date", OracleType.VarChar, 30)).Value = DateTime.Now.ToString();


                      Cco.cn.Open();
                      Cco.cmd.ExecuteNonQuery();
                      Cco.cn.Close();
                       
                        //---------------------------------lancer des message---------------------------------------------------
                        //------------------------------------recuperation des numero de telephone des etudiant qui depacer 20h--------------------
                        
                        p1.Show();

                    }
                    //--------------------- fin---------------------------------------------------------------------------
                    else
                    {
                        Cco.adapter = new OracleDataAdapter("select telephone , E_mail from etudiant where nbr_pou_msg>20", Cco.cn);
                        DataTable dtteleemail = new DataTable();
                         
                        Cco.adapter.Fill(dtteleemail);
                        if (dtteleemail.Rows.Count > 0)
                        {
                            while (i < dtteleemail.Rows.Count-1)
                            {
                                MessageBox.Show(dtteleemail.Rows[i][0].ToString());
                                communication.laSncermsg(dtteleemail.Rows[i][0].ToString(),serialPort1);
                            }
                            i = 0;
                            while (i < dtteleemail.Rows.Count-1)
                            {
                                MessageBox.Show(dtteleemail.Rows[i][1].ToString());
                                communication.email(dtteleemail.Rows[i][1].ToString());
                            }
                        }
                        p1.Show();
                    }

                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("le utilisateur ou le mote de passe incorecte !", "Ereur !!");

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked)
            {

                bunifuMetroTextbox3.isPassword = false;

            }else
            {

                bunifuMetroTextbox3.isPassword = true;
            }

        }
    } }
