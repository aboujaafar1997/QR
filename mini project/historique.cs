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
    public partial class historique : UserControl
    {
        public historique()
        {
            InitializeComponent();
        }
        ClassConnexion datacnx = new ClassConnexion();
        DataTable dt;
        DataView dv;
        private void historique_Load(object sender, EventArgs e)
        {

            DoThis();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (textBox2Num.Text == "")
            {
                DoThis();
            }
            else
            {
                dv.RowFilter = "numero=" + textBox2Num.Text;
                bunifuCustomDataGrid1.DataSource = dv;
            }
        }
        public void DoThis()
        {
            dt = datacnx.GetInfo("select * from historique ");

            dt.Columns[0].ColumnName = "Numero";
            dt.Columns[1].ColumnName = "Carte Identification National";
            dt.Columns[3].ColumnName = "Date de Visite";

            dv = new DataView(dt);
            bunifuCustomDataGrid1.DataSource = dt;

        }
        bool test = false;
        private void textBox2Num_TextChanged_1(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(textBox2Num.Text, out n) == false)
            {

                if (textBox2Num.Text == "")
                {
                    DoThis();
                    test = true;
                }
                if (test == false)
                {
                    MessageBox.Show("Fitrage seulment par Numero ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    test = true;

                }
                try
                {
                    textBox2Num.Text = textBox2Num.Text.Remove(textBox2Num.Text.Count() - 1);

                }
                catch (Exception)
                { }

            }
            else
            {
                DoThis();

                if (textBox2Num.Text != "")
                {

                    dv.RowFilter = "Numero=" + textBox2Num.Text;

                    bunifuCustomDataGrid1.DataSource = dv;

                    test = true;
                }
            }







        }
    }
}
