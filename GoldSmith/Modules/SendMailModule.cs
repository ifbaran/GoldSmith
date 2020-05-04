using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using GoldSmith.Forms;
using GoldSmith.Class;

namespace GoldSmith.Modules.Class
{
    public class SendMailModule
    {
        //private System.Windows.Forms.TextBox txtWhom;
        public void SendMail(string TxtWhom, string TxtSubject,string RichTxtContent )
        {
            
            MailMessage message = new MailMessage();
            message.From = new MailAddress("goldsmith.cvs@gmail.com", "GoldSmith | Altın Depo Yönetim Sistemi");

            message.To.Add(TxtWhom);
            message.Subject = TxtSubject;
            message.Body = RichTxtContent;

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("goldsmith.cvs@gmail.com", "GoldSmithAPP");
            object userState = message;

            bool isThereInternet = false;

            try
            {
                System.Net.Sockets.TcpClient kontrol_client = new System.Net.Sockets.TcpClient("www.google.com", 80);
                isThereInternet = true;
            }
            catch (Exception)
            {

                isThereInternet = false;
            }

            if (isThereInternet == true)
            {
                if (TxtSubject != "" || RichTxtContent != "")
                {
                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Başarılı");
                        
                    }
                    catch (SmtpException ex)
                    {
                        MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen gerekli alanları doldurunuz.");
                }


            }
            else
            {
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz. ");
            }
            
        }
    }


    }

