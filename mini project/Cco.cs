using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Security.Cryptography;

namespace mini_project
{
   public class Cco
    {

        static public string cin;
        static public string url= "http://192.168.23.2/qr/mini%20project/qrscripte.php";
        static public OracleConnection cn = new OracleConnection("Data Source=localhost; User Id=system;Password=45frtg-;");
        static public OracleDataAdapter adapter ;
        static public OracleCommand cmd ;
        
        public static String sha256(string hach)
        {
            SHA1CryptoServiceProvider objimplsercry = new SHA1CryptoServiceProvider();
            Byte[] bytestring = System.Text.Encoding.ASCII.GetBytes(hach);
            bytestring = objimplsercry.ComputeHash(bytestring);
            String finalstring = "";
            foreach (Byte bt in bytestring)
            {
                finalstring = finalstring + bt.ToString();
            }
            return finalstring;
        }
    }
}
