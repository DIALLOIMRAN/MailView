using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailView.DataModel;
using MailView.Services;
namespace MailView
{
    public partial class NouveauMessage : Form
    {
        User user = new User();
        string _destination = "";
        public string destination
        {
            set { _destination = value; }
        }
        public NouveauMessage(User user)
        {
            InitializeComponent();
            this.user = user;
            this.CenterToParent();
        }

        private void labelEnvoyer_Click(object sender, EventArgs e)
        {
            if (new ServicesMail().envoyer(this.user.adresse_email, textAdresse.Text, textObjet.Text, textContenu.Text))
            {
                MessageBox.Show("Message envoyé");
                this.Hide();
            }
            else
            {
                MessageBox.Show("l'envoi du message a échoué");
                this.Hide();
            }
        }

        private void activerEnvoyer()
        {
            if (textAdresse.Text != "" && textObjet.Text != "" && textContenu.Text != "")
            {
                labelEnvoyer.Enabled = true;
            }
        }

        private void textContenu_Leave(object sender, EventArgs e)
        {
            this.activerEnvoyer();
        }

        private void textObjet_Leave(object sender, EventArgs e)
        {
            this.activerEnvoyer();
        }

        private void textAdresse_Leave(object sender, EventArgs e)
        {
            this.activerEnvoyer();
        }

        private void labelErreur_Click(object sender, EventArgs e)
        {

        }

        private void NouveauMessage_Load(object sender, EventArgs e)
        {
            if (!(this._destination.Equals("")))
            {
                textAdresse.Text = this._destination;
            }
        }
    }
}
