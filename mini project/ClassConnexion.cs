using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OracleClient;
using System.Threading.Tasks;

namespace mini_project
{
    class ClassConnexion
    {
        public  OracleConnection cnx = new OracleConnection("Data Source=localhost;User Id=system;Password=45frtg-");
        public OracleDataAdapter da;


        public ClassConnexion()
        {
            this.da = new OracleDataAdapter();
        }
         
        public void ExecuteQr(string command)
        {
            cnx.Open();
            OracleCommand cmd = new OracleCommand(command,cnx);

            cmd.ExecuteNonQuery();
            cnx.Close();
            
        }
 
        public DataTable GetInfo(String cmd)
        {
            DataTable data = new DataTable();
            da = new OracleDataAdapter(cmd, cnx);
            da.Fill(data);

            return data;
        }
    }
}
