using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailView.Services;
using MailView.DataModel ;
namespace MailView.IHM
{
    public partial class Conversation : Form
    {
        string source; 
        string dest;
        public Conversation(string source, string dest)
        {
            InitializeComponent();
            this.source = source;
            this.dest = dest;

        }

        private void Conversation_Load(object sender, EventArgs e)
        {
            List <Mail> mails = new ServicesMail().getMail(source, dest);
            int nbr = 0;
            foreach (Mail mail in mails)
            {
                nbr++;
                string email = mail.adresse_source;
                string objet = mail.objet;
                string contenu = mail.contenu;

                listBox1.Items.Add(new exListBoxItem(mail.Id_mail, objet + " " + mail.adresse_source, contenu, Image.FromFile(@"C:\images\image.png")));
            }
        }

        private void labelBoiteReception_Click(object sender, EventArgs e)
        {

        }
    }
}
