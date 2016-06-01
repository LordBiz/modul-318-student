using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace ÜBER_GUI
{
    public partial class MailWindow : Form
    {
        // Variabeln
        string MailText = "";

        // Standartkonstruktor
        public MailWindow()
        {
            InitializeComponent();
        }

        // Konstruktor mit String als Mitgabe
        // Der String wird als Mailtext gesetzt
        public MailWindow(string Mail)
        {
            InitializeComponent();
            MailText = Mail;
        }

        /// <summary>
        /// Sendet ein E-Mail an die eingegebene Adresse
        /// </summary>
        private void SendMail_Click(object sender, EventArgs e)
        {
            if (Subject.Text == "")
                Subject.Text = "Fahrplan Mail";

            // Erstellt die E-Mail Nachricht
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("dok501testmail@gmail.com");     // Mail: dok501testmail@gmail.com PW: Vogel123;
            msg.To.Add(MailAdr.Text);
            msg.Subject = Subject.Text;
            msg.Body = MailText;

            // Beginnt eine Verbindung auf den Server
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("dok501testmail@gmail.com", "Vogel123");
            client.Timeout = 20000;

            try
            {
                client.Send(msg);
            }
            finally
            {
                msg.Dispose();
            }
            this.Close();
        }

        /// <summary>
        /// Schliesst das Mail-Fenster
        /// </summary>
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
