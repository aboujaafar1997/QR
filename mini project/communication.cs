using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mini_project
{
    class communication
    {
     

      public static void laSncermsg(string tel, SerialPort serialPort1)
        {
            if (Form1.p1.parametre1.bunifuSwitch1.Value == true)
            {
               
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }

                serialPort1.PortName = "COM17";
                serialPort1.BaudRate = 9600;
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.DataBits = 8;
                serialPort1.Handshake = System.IO.Ports.Handshake.RequestToSend;
                serialPort1.DtrEnable = true;
                serialPort1.RtsEnable = true;
                try
                {
                    serialPort1.Open();
                    if (serialPort1.IsOpen)
                    {

                        serialPort1.Write("at\r");
                        serialPort1.Write("at+cmgf=1\r");
                        System.Threading.Thread.Sleep(1000);
                        serialPort1.Write("at+cmgs=\"" + "555" + "\"\r\n");
                        serialPort1.Write("bla" + "\x1A");
                        System.Threading.Thread.Sleep(1000);
                        MessageBox.Show("efuctue");
                        MessageBox.Show("message envoyer");
                    }
                    else
                    {
                        MessageBox.Show("Port '" + serialPort1.PortName + "' is not available!");
                    }
                }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }


            }
        }



        public static void email(string email)
        {
            try
            {

                MailMessage mail = new MailMessage();
                mail.From = new System.Net.Mail.MailAddress(Form1.p1.parametre1.bunifuMetroTextbox2.Text.ToString());
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, (Form1.p1.parametre1.bunifuMetroTextbox3.Text.ToString()));
                smtp.Host = "smtp.gmail.com";
     
                //recipient
                mail.To.Add(new MailAddress(email));
                mail.IsBodyHtml = true;
                string st = Form1.p1.parametre1.bunifuMetroTextbox4.Text.ToString();

                mail.Body = st;
                smtp.Send(mail);
                MessageBox.Show("envoyer");
            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
    }
}
