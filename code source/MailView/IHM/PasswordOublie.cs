using MailView.DataModel;
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
namespace MailView.IHM
{
    public partial class PasswordOublie : Form
    {
        public PasswordOublie()
        {
            InitializeComponent();
            this.CenterToParent();
            buttonVerifier.Enabled = false;
            panel2.Visible = false;
        }
        private void textAdresse_Leave(object sender, EventArgs e)
        {
            Boolean test = true;
            if (textAdresse.Text == "")
            {
                labelErreur.Text = "Ce champ est obligatoire";
            }
            else
            {
                if (test)  //c'est une adresse hotmail
                {
                    buttonVerifier.Enabled = true;
                }
                else
                {
                    labelErreur.Text = "Cette adresse est invalide";
                }
            }
        }
        private void buttonEnvoyer_Click(object sender, EventArgs e)
        {
            
        }

        private void PasswordOublie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            





            this.Hide();
            if (Services.Validation.validerPassword(textNvPwd.Text) == "Valide")
            {
                if (Services.Validation.identique(textNvPwd.Text, textPwd.Text) == "identique")
                {
                    User user = new Services.ServicesUser().getUserAdressePhone(textAdresse.Text, textPhone.Text);
                    user.password = textNvPwd.Text;
                    new Services.ServicesUser().mettreAjour(user);
                    MessageBox.Show("le mot de passe est mis à jour");
                }
                else
                {
                    labelErreur1.Text = "les mots de passe sont pas identique";
                    textNvPwd.Text = "";
                    textPwd.Text = "";
                }
            }
            else
            {
                labelErreur1.Text = "ce mot de passe est incorrect";
                textNvPwd.Text = "";
                textPwd.Text = "";
            }

        }

        private void buttonVerifier_Click(object sender, EventArgs e)
        {
            if (new Services.Validation().adresseExiste(textAdresse.Text))
            {
                if (new Services.ServicesUser().getUserAdressePhone(textAdresse.Text, textPhone.Text) != null)
                {
                    panel2.Visible = true;
                }
                else
                {
                    labelErreur.ForeColor = System.Drawing.Color.Red;
                    labelErreur.Text = "cet n° de téléphone ne correspond pas à l'adresse indiquer !";
                    textPhone.Text = "";
                }

            }
            else
            {
                labelErreur1.ForeColor = System.Drawing.Color.Red;
                labelErreur.Text = "cet adresse eamil n'existe pas !";
                textAdresse.Text = "";
            }

        }

        private void buttonMaj_Click(object sender, EventArgs e)
        {
            User user = new ServicesUser().getUser1(textAdresse.Text);
            
            if (Validation.validerPassword(textPwd.Text).Equals("Valide"))
            {
                if (Validation.identique(textPwd.Text, textNvPwd.Text).Equals("identique"))
                {
                    user.password = textNvPwd.Text;
                    new ServicesUser().mettreAjour(user);
                    this.Hide();
                }
                else
                {
                    labelErreur1.ForeColor = System.Drawing.Color.Red;
                    labelErreur1.Text = "les deux mots de passe sont pas identique";
                    textNvPwd.Text = "";
                }

            }
            else
            {
                labelErreur1.ForeColor = System.Drawing.Color.Red;
                labelErreur1.Text = "incorrect !";
                textPwd.Text = "";
            }

        }

    }
}
