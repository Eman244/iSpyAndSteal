using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Web;

/// <summary>
/// Summary description for Extensions
/// </summary>
public class Extensions
{
    public static void SendMail(string ReceiverEmail, string MailText, string subject)
    {
        //Fetching Settings from WEB.CONFIG file.  
        string emailSender = "ntupassing2112@gmail.com";
        string emailSenderPassword = "Hello123!!";
        string emailSenderHost = "smtp.gmail.com";
        int emailSenderPort = 587;
        Boolean emailIsSSL = true;



        //Base class for sending email  
        MailMessage _mailmsg = new MailMessage();

        //Make TRUE because our body text is html  
        _mailmsg.IsBodyHtml = true;

        //Set From Email ID  
        _mailmsg.From = new System.Net.Mail.MailAddress(emailSender);

        //Set To Email ID  
        _mailmsg.To.Add(ReceiverEmail.ToString());

        //Set Subject  
        _mailmsg.Subject = subject;// "Sweet Institute";

        //Set Body Text of Email   
        _mailmsg.Body = MailText;


        //Now set your SMTP   
        SmtpClient _smtp = new SmtpClient();

        //Set HOST server SMTP detail  
        _smtp.Host = emailSenderHost;

        //Set PORT number of SMTP  
        _smtp.Port = emailSenderPort;

        //Set SSL --> True / False  
        _smtp.EnableSsl = emailIsSSL;

        //Set Sender UserEmailID, Password  
        NetworkCredential _network = new NetworkCredential(emailSender, emailSenderPassword);
        _smtp.Credentials = _network;

        //Send Method will send your MailMessage create above.  
        _smtp.Send(_mailmsg);

    }


}