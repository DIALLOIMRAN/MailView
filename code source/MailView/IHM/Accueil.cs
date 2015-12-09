using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using MailView.DataModel;
using MailView.Services;
using System.IO;

namespace MailView.IHM
{
    public partial class Accueil : Form
    {
        User user;
        private string _destination;
        
        public string destination
        {
            set { _destination = value; }
        }
        private string _objet = "";

        public string objet
        {
            set { _objet = value; }
        }
        List<Mail> mails = null;
        public Accueil(User user)
        {
            InitializeComponent();
            this.CenterToParent();
            this.user = user;
            
            labelNomPrenom.Text = user.nom + " " + user.prenom;
            panelRenouvelerPassword.Visible = false;
            panelLusNonLus.Visible = false;
          //  labelSupprimer.Visible = false;

            //label4.Text = new ServicesMail().NombreNonLus(user.adresse_email) + "nouveaux Messages";

            if (user.photo != null)
            {
                pictureBoxPhoto.Image = new ServicesUser().ByteToImage(this.user.photo);
            }

            DGMails.Font = new System.Drawing.Font("Century Gothic", 28.25F);
            DGMails.ClearSelection();
            
        }

        private void visibilité(string comp)
        {
            switch (comp)
            {
                case "DGMails":

                    DGMails.Visible = true;
                    panelFormProfil.Visible = false;
                    listBox1.Visible = false;
                    panel2.Visible = false;
                    DGMails.Columns[1].Visible = false;
                    panel3.Visible = false;
                    break;
                case "panelFormProfil":

                    DGMails.Visible = false;
                    panelFormProfil.Visible = true;
                    listBox1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;

                    break;
                case "listBox1":

                    DGMails.Visible = false;
                    panelFormProfil.Visible = true;
                    listBox1.Visible = true;
                    panel2.Visible = true;
                    panel3.Visible = false;

                    break;

                case "default":

                    DGMails.Visible = false;
                    panelFormProfil.Visible = false;
                    listBox1.Visible = false;
                    panel2.Visible = false;
                    panel3.Visible = false;

                    break;
                    
            }

        }

        private void labelActualiser_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.labelActualiser, "Actualiser"); 

            DGMails.DataSource = new Services.ServicesMail().messageRecu(user.adresse_email);
            visibilité("DGMails");
            this.checkNonLus.Checked = true;
            this.checkLus.Checked = true;
        }

        private void labelNouveau_Click(object sender, EventArgs e)
        {
            new NouveauMessage(this.user).Show();
        }

        private void labelBoiteReception_Click(object sender, EventArgs e)
        {
            DGMails.DataSource = new Services.ServicesMail().messageRecu(user.adresse_email);
            panelLusNonLus.Visible = true;
            visibilité("DGMails");
            
            // trouver une méthode de mise en page
            DGMails.AutoResizeColumns();
            DGMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void labelMessageEnvoyes_Click(object sender, EventArgs e)
        {
            DGMails.DataSource = new Services.ServicesMail().messageEnvoye(user.adresse_email);
            panelLusNonLus.Visible = true;
            visibilité("DGMails");
            this.checkNonLus.Checked = false;
            this.checkLus.Checked = false;
        }

        private void checkLus_CheckedChanged(object sender, EventArgs e)
        {
            DGMails.DataSource = new Services.ServicesMail().messageLu(user.adresse_email);
            DGMails.AutoResizeColumns();
            DGMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void checkNonLus_CheckedChanged(object sender, EventArgs e)
        {
            DGMails.DataSource = new Services.ServicesMail().messageNonLu(user.adresse_email);
            DGMails.AutoResizeColumns();
            DGMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
 
        private void labelSupprimer_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.labelSupprimer, "Supprimer");
            if (!(DGMails.Columns[1].Name.Equals("id")))
            {
                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < DGMails.Rows.Count; i++)
                {
                    row = DGMails.Rows[i];
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        Mail mail = new Mail();
                        if (this.checkLus.Checked == true || this.checkNonLus.Checked == true)
                        {

                            mail = new ServicesMail().getMailSelection(Convert.ToString(row.Cells[2].Value), Convert.ToDateTime(row.Cells[4].Value));

                        }
                        else
                        {

                            mail = new ServicesMail().getMailSelection(user.adresse_email, Convert.ToDateTime(row.Cells[4].Value));

                        }
                        if (mail == null)
                        {
                            MessageBox.Show("le message est null ");
                        }
                        else
                        {

                            new ServicesMail().supprimer(mail, user);
                            DGMails.Rows.Remove(row);
                            i--;
                        }

                    }
            }
            
               
            }
        }

       //ici

        private void Accueil_Load(object sender, EventArgs e)
        {
            
            if (_objet.Equals(""))
            {
                if (DGMails.Rows.Count == 0)
                {
                    visibilité("default");
                }
                else
                {
                    DGMails.DataSource = new Services.ServicesMail().messageRecu(user.adresse_email);
                    visibilité("DGMails");
                    DGMails.AutoResizeColumns();
                    DGMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
            }
            else
            {
                visibilité("listBox1");
                this.Hide();
                

                mails = new ServicesMail().getMail1(this._objet); 
                
                foreach (Mail mail in mails)
                {
                    string emailSource = mail.adresse_source;
                    string contenu = mail.contenu;
                    User user1 = new ServicesMail().getUser(mail.adresse_source);
                    if (new ServicesUser().ByteToImage(user1.photo) != null)
                    {
                        listBox1.Items.Add(new exListBoxItem(mail.Id_mail, emailSource + "  " + mail.date_msg, contenu, new ServicesUser().ByteToImage(user1.photo)));
                    }
                    
                }
            }
        }

        private void DGMails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (DGMails.Rows.Count == 0)
                {
                    visibilité("default");
                }
                else
                {
                    if (DGMails.Columns[1].Name.Equals("id"))
                    {
                        User u = new ServicesMail().getUser(DGMails.CurrentRow.Cells[4].Value.ToString());
                        DGMails.Columns[1].Visible = true;
                        if (u.photo != null)
                        {
                            pictureBox1.Image = new ServicesUser().ByteToImage(u.photo);
                        }
                        labelNP.Text = "Nom : " + u.nom + " " + u.prenom;
                        labelE.Text = "email :";
                        label16.Text = u.adresse_email;
                        labelPho.Text = "Téléphone : " + u.numTelephone;
                        panel3.Visible = true;
                    }
                    else
                    {
                        DGMails.Columns[1].Visible = true;
                        Mail mail = new ServicesMail().getMailId(Convert.ToInt32(DGMails.CurrentRow.Cells[1].Value.ToString()));
                        mail.etat_msg = 1;
                        new ServicesMail().mettreAjour(mail);
                        this.Hide();
                        Accueil ac = new Accueil(user);
                        ac.destination = DGMails.CurrentRow.Cells[2].Value.ToString();
                        ac.objet = DGMails.CurrentRow.Cells[3].Value.ToString();
                        ac.Show();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new ServicesUser().seDeconnecter(user);
            this.Hide();
            new Index().Show();
        }

        private void labelListeAmis_Click(object sender, EventArgs e)
        {
            //DGMails.Visible = true;
            panelFormProfil.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelRenouvelerPassword.Visible = true;
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            //On ouvre un OpenFileDialog
            if (this.openDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                // Si le fichier choisi existe
                FileInfo fi = new FileInfo(this.openDialogPhoto.FileName);
                if (fi.Exists)
                {
                    
                    this.PBPhoto.Image = Image.FromFile(@""+fi.FullName) ;
                    pictureBoxPhoto.Image = this.PBPhoto.Image;
                    textCheminPhoto.Text = @"" + fi.FullName;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            DGMails.Visible = false;
            panelFormProfil.Visible = true;
            User user1 = new ServicesUser().getUser(user.Id_user);
            texteNom.Text = user1.nom;
            textePrenom.Text = user1.prenom;
            texteEmail.Text = user1.adresse_email;
            textPhone.Text = user1.numTelephone;
            if (user1.sexe == "M")
            {
                radioMasculin.Checked = true;
            }
            else if(user1.sexe == "F")
            {
                radioFeminin.Checked = true;
            }

            if (user1.photo != null)
            {
                PBPhoto.Image = new ServicesUser().ByteToImage(user1.photo);
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            user.nom = texteNom.Text;
            user.prenom = textePrenom.Text;
            user.adresse_email = texteEmail.Text;
            user.numTelephone = textPhone.Text;
            if (radioMasculin.Checked)
            {
                user.sexe = "M";
            }
            else if (radioFeminin.Checked)
            {
                user.sexe = "F";
            }
            byte[] bImage = null;
            if (!(textCheminPhoto.Text.Equals("")))
            {
                
                bImage = new ServicesUser().ReadFile(textCheminPhoto.Text);
            }
            
            user.photo = bImage;
            new ServicesUser().mettreAjour(user);
            label4.ForeColor = System.Drawing.Color.Green;
            label4.Text = "votre compte est mis à jour avec succès : ";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            
            DGMails.DataSource = new ServicesMail().ChercherMails(textBox4.Text);
            visibilité("DGMails") ;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox4.Text = "";
            textBox4.ForeColor = System.Drawing.Color.Black;
        }

        private void checkLus_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkLus.Checked && !checkNonLus.Checked)
            {
                DGMails.DataSource = new Services.ServicesMail().messageLu(user.adresse_email);
                visibilité("DGMails");
            }
            else
            {
                DGMails.DataSource = new Services.ServicesMail().messageRecu(user.adresse_email);
                visibilité("DGMails");
            }
        }

        private void checkNonLus_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!checkLus.Checked && checkNonLus.Checked)
            {
                DGMails.DataSource = new Services.ServicesMail().messageNonLu(user.adresse_email);
                visibilité("DGMails");
                DGMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                visibilité("DGMails");
            }
            else
            {
                DGMails.DataSource = new Services.ServicesMail().messageRecu(user.adresse_email);
                visibilité("DGMails");
                DGMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                visibilité("DGMails");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            DGMails.DataSource = new Services.ServicesUser().allUser();
            DGMails.AutoResizeColumns();
            DGMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            visibilité("DGMails");
            DGMails.Columns[0].Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            DGMails.DataSource = new Services.ServicesUser().getUserAdresse(textBox5.Text);
            DGMails.AutoResizeColumns();
            DGMails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            visibilité("DGMails");
            
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox5.Text = "";
            textBox5.ForeColor = System.Drawing.Color.Black;
            //DGMails.Font = System.Drawing.Font.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (new ServicesUser().passwordCorrect(user.adresse_email, textBox1.Text))
            {
                if (Validation.validerPassword(textBox2.Text) == "Valide")
                {
                    if (Validation.identique(textBox2.Text, textBox3.Text) == "identique")
                    {
                        user.password = textBox3.Text;
                        new ServicesUser().mettreAjour(user);
                        panelRenouvelerPassword.Visible = false;
                        label4.Text = "votre nouveau mot de passe est : " + user.password;
                    }
                    else
                    {
                        textBox3.ForeColor = System.Drawing.Color.Red;
                        textBox3.Text = "les deux mots de passe sont pas identique" ;
                    }

                }else
                    {
                        textBox2.ForeColor = System.Drawing.Color.Red;
                        textBox2.Text = "incorrect !" ;
                    }
                
            }
            else
            {
                textBox1.ForeColor = System.Drawing.Color.Red;
                textBox1.Text = "ne correspond pas à ce compte";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox1.Text = "";
            textBox1.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox2.Text = "";
            textBox2.ForeColor = System.Drawing.Color.Black;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            textBox3.Text = "";
            textBox3.ForeColor = System.Drawing.Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!_objet.Equals(""))
            {
                mails.Add(null);
                Mail mail= new Mail();
                mail.objet = this._objet;
                mail.adresse_dest = mails[0].adresse_source ;
                mail.contenu = textBox6.Text ;
                mail.adresse_source = this.user.adresse_email;
                if (new ServicesMail().envoyer(this.user.adresse_email, mail.adresse_dest, mail.objet, mail.contenu))
                {
                    mails.Add(mail);
                    Accueil ac = new Accueil(user);
                    ac.objet = this._objet;
                    ac.Show();

                }
                else
                {
                    MessageBox.Show("l'envoi du message a échoué");
                    this.Hide();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mail mail = new Mail();
            mail.adresse_dest = labelE.Text;
            NouveauMessage nv = new NouveauMessage(user);
            nv.destination = label16.Text;
            nv.Show();
            
        }
    }
            
}
