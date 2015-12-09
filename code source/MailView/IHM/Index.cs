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
using MailView.DataModel;

namespace MailView.IHM
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            this.CenterToParent();
          
            
        }

        private void labelConnexion_Click(object sender, EventArgs e)
        {
            if (new Validation().adresseExiste(textAdresseEmail.Text))
            {
                if (new ServicesUser().passwordCorrect(textAdresseEmail.Text, textPassword.Text))
                {
                    User user = new ServicesUser().seConnecter(textAdresseEmail.Text, textPassword.Text);
                    if (user != null)
                    {
                        this.Hide();
                        Accueil ac = new Accueil(user);
                       
                        ac.objet = "";
                        ac.Show();
                    }
                    else
                    {
                        labelErreur.Text = "Erreur de connexion";
                    }
                }
                else
                {
                    labelErreur.Text = "Le mot de passe que vous avez saisi est incorrect. Veuillez réessayer ";
                }

            }
            else
            {
                labelErreur.Text = "L'adresse que vous avez saisie n’est associée à aucun compte !";
            }

        }

        private void labelInscription_Click(object sender, EventArgs e)
        {
            
            new Inscription().Show();
            
            
        }

        private void labelPasswordOublie_Click(object sender, EventArgs e)
        {
            new PasswordOublie().Show();
        }

        private void labelConnexion_MouseEnter(object sender, EventArgs e)
        {
            labelConnexion.ForeColor = Color.FromArgb(0, 0, 255);
        }

        private void labelConnexion_MouseLeave(object sender, EventArgs e)
        {
            labelConnexion.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void labelPasswordOublie_MouseEnter(object sender, EventArgs e)
        {
            labelPasswordOublie.ForeColor = Color.FromArgb(0, 0, 255);
        }

        private void labelPasswordOublie_MouseLeave(object sender, EventArgs e)
        {
            labelPasswordOublie.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void textAdresseEmail_MouseLeave(object sender, EventArgs e)
        {
            if (textAdresseEmail.Text != "")
            {
                if (new Validation().adresseExiste(textAdresseEmail.Text))
                {
                    labelPasswordOublie.ForeColor = Color.FromArgb(0, 0, 255);
                }
            }
            else
            {
                labelPasswordOublie.ForeColor = Color.FromArgb(0, 0, 0);
            }

        }

       
    }
 }
