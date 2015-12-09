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
using System.Text.RegularExpressions;

namespace MailView.IHM
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
            this.CenterToParent();
            buttonAnnuler.Enabled = false ;
            buttonConfirmer.Enabled = false ;
            
        }

        private void textNom_Leave(object sender, EventArgs e)
        {
            if (textNom.Text == "")
            {
                this.errorProvider1.SetError(this.textNom," Ce champ est obligatoire ");
                this.labelNomErreur.Hide();
            }
            else
            {
               this.errorProvider1.Clear ();
               labelNomErreur.Image = global::MailView.Properties.Resources.iconValide;
               this.activerBoutons();
            }
        }

        private void textPrenom_Leave(object sender, EventArgs e)
        {
            if (textPrenom.Text == "")
            {
                this.errorProvider1.SetError(this.textPrenom, " Ce champ est obligatoire ");
                this.labelPrenomErreur.Hide();
            }
            else
            {
                this.errorProvider1.Clear();
                labelPrenomErreur.Image = global::MailView.Properties.Resources.iconValide;
                this.activerBoutons();
            }

        }

        private void textEmail_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                this.errorProvider1.SetError(this.textEmail, " Ce champ est obligatoire ");
                this.labelAdresseErreur.Hide();
            }
            else
            {
                if(new Validation().adresseExiste(textEmail.Text))
                {
                    this.errorProvider1.SetError(this.textEmail, "Cette adresse existe déjà");
                    textEmail.Text = null;
                }
                else
                {
                    if(new Validation().adresseValide(textEmail.Text))
                    {
                        this.errorProvider1.Clear();
                        labelAdresseErreur.Image = global::MailView.Properties.Resources.iconValide;
                        this.activerBoutons();

                    }else
                    {
                        this.errorProvider1.SetError(this.textEmail, " Vous devez respecter la forme suivante : \n xxxxxx@mailview.ma");
                        this.labelAdresseErreur.Hide();
                    }
                    
                }
            }

        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            if (textPassword.Text == "")
            {
                this.errorProvider1.SetError(this.textPassword, " Ce champ est obligatoire ");
                this.labelPasswordErreur.Hide();
            }
            else
            {

                if (Validation.validerPassword(textPassword.Text) == "Valide")
                {
                    this.errorProvider1.Clear();
                    labelPasswordErreur.Image = global::MailView.Properties.Resources.iconValide;
                    this.activerBoutons();
                }
                else
                {
                    this.errorProvider1.SetError(this.textPassword, " invalide.\n le mot de passe doit contenir au moins six caractères \n composés d'au moins un chiffre\n une lettre minuscule et une majuscule ");
                    this.labelPasswordErreur.Hide();
                }
            }
        }

        private void textPwdConfirm_Leave(object sender, EventArgs e)
        {
            if (textPwdConfirm.Text == "")
            {
                this.errorProvider1.SetError(this.textPwdConfirm, " Ce champ est obligatoire ");
                this.labelPasswordConfirmErreur.Hide();
            }
            else
            {

                if (Validation.identique(textPassword.Text, textPwdConfirm.Text) == "identique")
                {
                    this.errorProvider1.Clear();
                    labelPasswordConfirmErreur.Image = global::MailView.Properties.Resources.iconValide;
                    this.activerBoutons();
                }
                else
                {
                    this.errorProvider1.SetError(this.textPwdConfirm, " les deux mots de passes doivent être identiques ");
                    this.labelPasswordConfirmErreur.Hide();
                }
            }
        }

        private void activerBoutons()
        {
            if (textNom.Text != "" && textPrenom.Text != "" && textEmail.Text != "" && textPassword.Text != "" && textPwdConfirm.Text != "")
            {
                buttonAnnuler.Enabled = true;
                buttonConfirmer.Enabled = true;    
            }
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
                 if (new ServicesUser().S_inscrire(textNom.Text, textPrenom.Text, textEmail.Text, textPassword.Text, textPhone.Text))
                {
                    MessageBox.Show("Inscription réussie"); 
                }
                else
                {
                     MessageBox.Show("Inscription échoué");   
                }
            this.Close();
        }

        private void textEmail_Enter(object sender, EventArgs e)
        {
            textEmail.Text = "";
            textEmail.ForeColor = System.Drawing.Color.Black;
        }

        private void textPhone_Enter(object sender, EventArgs e)
        {
            textPhone.Text = "";
            textPhone.ForeColor = System.Drawing.Color.Black;
        }

        private void textPhone_Leave(object sender, EventArgs e)
        {
            if (new Validation().phoneValide(textPhone.Text))
            {
                labelPhone.Visible = true;
                this.errorProvider1.Clear();
                labelPhone.Image = global::MailView.Properties.Resources.iconValide;
                this.activerBoutons();
            }
            else
            {
                this.errorProvider1.SetError(this.textPhone, "le n° de téléphone doit contenir 10 chiffres commençant par 06");
                this.labelPhone.Hide();
            }
        }
        
        
    }
}
