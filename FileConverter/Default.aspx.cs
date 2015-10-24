using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace FileConverter
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SendReportEmail();
        }

        public static void SendReportEmail()//string report, string agencyFolder, string from, string to , string cc, int importRunId, Aspect aspect
        {
            MailMessage mail = new MailMessage();
            string s = "s";

            SmtpClient SmtpServer = new SmtpClient("mail.rcrtechnology.com");////rcrtechnology   //mail.rcrtechnology.com

            mail.From = new MailAddress("no-reply@nhbhas.com"); // this should be from   // thubbard@rcrtechnology.com
            mail.To.Add("thubbard@rcrtechnology.com");     // this should be to
            mail.CC.Add("ThomasLHubbard@hotmail.com");     // this should be cc
            mail.Subject = "This is a Sample Subject line";
            mail.Body = "This is a sample string for the email body of the applicaton.";


            SmtpServer.Port = 587;//587
            //SmtpServer.Credentials = new System.Net.NetworkCredential("jgrover@rcrtechnology.com", "********");
            //SmtpServer.Credentials = new System.Net.NetworkCredential("thubbard@rcrtechnology.com", "thubbard1");
            SmtpServer.EnableSsl = true;

            //below code (edited) Retreived from     http://stackoverflow.com/posts/5728177/edit

            //SmtpClient client = new SmtpClient("mail.rcrtechnology.com", 25);//EmailServer
            //var SmtpUser = new System.Net.NetworkCredential("thubbard@rcrtechnolog.com", "thubbard1");
            //client.Credentials = SmtpUser;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;

            try
            {
                SmtpServer.Send(mail);
                //  send a message to the database saying the mailer succeeded
            }
            catch (Exception ex)  //Mailbox unavailable. The server response was: 5.7.1 Unable to relay
            {
                //  send a message to the database saying the mailer failed
                //StatusError.InsertRunError(ex.Message, ex, "Emailer", importRunId, aspect.Enter("InsertRunError")); aspect--;
            }
        }

    }
}