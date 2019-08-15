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

namespace mini_project
{
    public partial class statistique : UserControl
    {
        public statistique()
        {
            InitializeComponent();
        }

        private void statistique_Load(object sender, EventArgs e)
        {
            /////////////////////chart3/////////////////
            DataTable a = new DataTable();
            Cco.adapter = new System.Data.OracleClient.OracleDataAdapter("select nom_etudiant ,COUNT(n_etudiant) as nbr from absence group by nom_etudiant", Cco.cn);
            Cco.adapter.Fill(a);

            for (int i = 0; i < a.Rows.Count; i++)

            {

                string x = a.Rows[i][0].ToString();
                string y = a.Rows[i][1].ToString();

                chart3.Series["produit"].Points.AddXY(x, y);


            }

            Cco.cn.Close();
            ////////////////////////////////////////

            Cco.cmd = new System.Data.OracleClient.OracleCommand("select  to_char(Extract(MONTH from datea)), count(n_etudiant) from absence  group by  to_char(Extract(MONTH from datea)) ", Cco.cn);
            Cco.cn.Open();
            OracleDataReader num = Cco.cmd.ExecuteReader();
            while (num.Read())
            {
                Chart1.Series["absence/mois/line"].Points.AddXY(num[0].ToString(), int.Parse(num[1].ToString()));
            }
            Cco.cn.Close();
            //////////////////////////////////////cahar3////////////
            Cco.cmd = new System.Data.OracleClient.OracleCommand("select  to_char(Extract(MONTH from datea)), count(n_etudiant) from absence  group by  to_char(Extract(MONTH from datea)) ", Cco.cn);
            Cco.cn.Open();
            OracleDataReader num2 = Cco.cmd.ExecuteReader();
            while (num2.Read())
            {
                chart2.Series["absence/mois/pile"].Points.AddXY(num2[0].ToString(), int.Parse(num2[1].ToString()));
            }
            Cco.cn.Close();
        }
    }
}
