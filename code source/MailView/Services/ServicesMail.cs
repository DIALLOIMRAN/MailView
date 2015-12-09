using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailView.DataModel;
using System.Collections;
using System.Data;

namespace MailView.Services
{
    
    class ServicesMail
    {
        private ModelDataContext dc = new ModelDataContext();

        static string getCurrTime()
        {
            return String.Format("{0:0000}-{1:00}-{2:00} {3:00}:{4:00}:{5:00}",
                System.DateTime.Now.Year,
                System.DateTime.Now.Month,
                System.DateTime.Now.Day,
                System.DateTime.Now.Hour, 
                System.DateTime.Now.Minute, 
                System.DateTime.Now.Second);
        }


        // les messages de la boîte de récéption de "email"
        public DataTable messageRecu(String email)
        {
            
            var mailRecu = (from M in dc.Mail join MbM in dc.MailBoxMail on M.Id_mail equals MbM.Mail_Id_mail join
                                 Mb in dc.MailBox on MbM.MailBox_Id_mailbox equals Mb.Id_mailbox
                            where Mb.libellé == "recu" && M.adresse_dest == email orderby M.date_msg 
                            select new { 
                                M.Id_mail,
                                M.etat_msg,
                                M.adresse_source,
                                M.objet,
                                M.contenu,
                                M.date_msg
                            });

            //Creation de la table 
            DataTable dt = new DataTable();
            dt.Columns.Add("num mail", typeof(int));
            dt.Columns.Add("Emetteur", typeof(string));
            dt.Columns.Add("Objet du message", typeof(string));
            dt.Columns.Add("date de reception", typeof(DateTime));

            foreach (var res in mailRecu)
            {
                DataRow row = dt.NewRow();
                row["num mail"] = res.Id_mail;
                row["Emetteur"] = res.adresse_source;
                row["Objet du message"] = res.objet;
                row["date de reception"] = res.date_msg;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public DataTable messageLu(String email)
        {

            var mailRecu = (from M in dc.Mail
                            join MbM in dc.MailBoxMail on M.Id_mail equals MbM.Mail_Id_mail
                            join
                                Mb in dc.MailBox on MbM.MailBox_Id_mailbox equals Mb.Id_mailbox
                            where Mb.libellé == "recu" && M.adresse_dest == email && M.etat_msg == 1
                            select new
                            {
                                M.etat_msg,
                                M.adresse_source,
                                M.objet,
                                M.date_msg,
                                M.Id_mail
                            });

            //Creation de la table 
            DataTable dt = new DataTable();
            dt.Columns.Add("num mail", typeof(int));
            dt.Columns.Add("Emetteur", typeof(string));
            dt.Columns.Add("Objet du message", typeof(string));
            dt.Columns.Add("date de reception", typeof(DateTime));

            foreach (var res in mailRecu)
            {
                DataRow row = dt.NewRow();
                row["num mail"] = res.Id_mail;
                row["Emetteur"] = res.adresse_source;
                row["Objet du message"] = res.objet;
                row["date de reception"] = res.date_msg;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public DataTable messageNonLu(String email)
        {

            var mailRecu = (from M in dc.Mail
                            join MbM in dc.MailBoxMail on M.Id_mail equals MbM.Mail_Id_mail
                            join
                                Mb in dc.MailBox on MbM.MailBox_Id_mailbox equals Mb.Id_mailbox
                            where Mb.libellé == "recu" && M.adresse_dest == email && M.etat_msg == 0
                            select new
                            {
                                M.etat_msg,
                                M.adresse_source,
                                M.objet,
                                M.date_msg,
                                M.Id_mail
                            });

            //Creation de la table 
            DataTable dt = new DataTable();
            dt.Columns.Add("num mail", typeof(int));
            dt.Columns.Add("Emetteur", typeof(string));
            dt.Columns.Add("Objet du message", typeof(string));
            dt.Columns.Add("date de reception", typeof(DateTime));

            foreach (var res in mailRecu)
            {
                DataRow row = dt.NewRow();
                row["num mail"] = res.Id_mail;
                row["Emetteur"] = res.adresse_source;
                row["Objet du message"] = res.objet;
                row["date de reception"] = res.date_msg;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public DataTable ChercherMails(String val)
        {

            var mailRecu = (from M in dc.Mail
                            join MbM in dc.MailBoxMail on M.Id_mail equals MbM.Mail_Id_mail
                            join
                                Mb in dc.MailBox on MbM.MailBox_Id_mailbox equals Mb.Id_mailbox
                            where M.adresse_dest == val || M.objet == val || M.date_msg == Convert.ToDateTime(val)
                            select new
                            {
                                M.etat_msg,
                                M.adresse_source,
                                M.objet,
                                M.date_msg,
                                M.Id_mail
                            });

            //Creation de la table 
            DataTable dt = new DataTable();
            dt.Columns.Add("num mail", typeof(int));
            
            dt.Columns.Add("Emetteur", typeof(string));
            dt.Columns.Add("Objet du message", typeof(string));
            dt.Columns.Add("date de reception", typeof(DateTime));

            foreach (var res in mailRecu)
            {
                DataRow row = dt.NewRow();
                row["Emetteur"] = res.adresse_source;
                row["num mail"] = res.Id_mail;
                row["Objet du message"] = res.objet;
                row["date de reception"] = res.date_msg;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public void mettreAjour(Mail mail)
        {
            Mail mail1 = dc.Mail.Single(u => u.Id_mail == mail.Id_mail);
            mail1.adresse_source = mail.adresse_source;
            mail1.adresse_dest = mail.adresse_dest;
            mail1.contenu = mail.contenu;
            mail1.objet = mail.objet;
            mail1.date_msg = mail.date_msg;
            mail1.etat_msg = mail.etat_msg;
            dc.SubmitChanges();

        }
        // les messages que user d'adresse "email" a envoyé
        public DataTable messageEnvoye(String email)
        {
            
            var mailRecu = (from M in dc.Mail
                            join MbM in dc.MailBoxMail on M.Id_mail equals MbM.Mail_Id_mail
                            join Mb in dc.MailBox on MbM.MailBox_Id_mailbox equals Mb.Id_mailbox
                            where Mb.libellé == "envoi" && M.adresse_source == email
                            select new
                            {
                                M.etat_msg,
                                M.adresse_dest,
                                M.objet,
                                M.date_msg,
                                M.Id_mail
                            });

            //Creation de la table 

            //Creation de la table 
            DataTable dt = new DataTable();
            dt.Columns.Add("num mail", typeof(int));
            
            dt.Columns.Add("Destinateur", typeof(string));
            dt.Columns.Add("Objet du message", typeof(string));
            dt.Columns.Add("date de reception", typeof(DateTime));

            foreach (var res in mailRecu)
            {
                DataRow row = dt.NewRow();
                row["num mail"] = res.Id_mail;
                row["Destinateur"] = res.adresse_dest;
                row["Objet du message"] = res.objet;
                row["date de reception"] = res.date_msg;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public Boolean envoyer(string source, string dest, string objet, string contenu)
        {
            Mail mail = new Mail();

            mail.adresse_source = source;
            mail.adresse_dest = dest;
            mail.objet = objet;
            mail.contenu = contenu;
            mail.date_msg = Convert.ToDateTime(getCurrTime());
            mail.etat_msg = 0;


            dc.Mail.InsertOnSubmit(mail);
            dc.SubmitChanges();
            int id_email = this.getDenierMail();


            MailBoxMail mailBoxMailSource = new MailBoxMail();

            mailBoxMailSource.Mail_Id_mail = id_email;
            mailBoxMailSource.MailBox_Id_mailbox = this.getMailBox(getUser(source), "envoi").Id_mailbox;

            dc.MailBoxMail.InsertOnSubmit(mailBoxMailSource);
            dc.SubmitChanges();

            MailBoxMail mailBoxMailDest = new MailBoxMail();
            mailBoxMailDest.Mail_Id_mail = id_email;
            mailBoxMailDest.MailBox_Id_mailbox = this.getMailBox(getUser(dest), "recu").Id_mailbox;

            dc.MailBoxMail.InsertOnSubmit(mailBoxMailDest);
            dc.SubmitChanges();

            return true;
        }

        public MailBox getMailBox(User user, string typeBoite)
        {
            var query = from x in dc.MailBox
                        where x.UserId_user == user.Id_user && x.libellé == typeBoite 
                        select x;
            foreach (MailBox v in query)
            {
                return v;
            }
            return null;
        }

        public User getUser(string adresseEmail)
        {
            var query = from x in dc.User
                        where x.adresse_email == adresseEmail
                        select x;
            foreach (User v in query)
            {
                return v;
            }
            return null;
        }

        public int getDenierMail()
        {
            return (from mail in dc.Mail select mail.Id_mail).Max();
        }

        public Mail getMailSelection(String adresse_source, DateTime date_envoi)
        {
            var query = from x in dc.Mail
                        where x.adresse_source == adresse_source && x.date_msg == date_envoi
                        select x;
            foreach (Mail m in query)
            {
                return m;
            }
            return null;
        }

        
        public Mail getMailId(int id)
        {
            var query = from x in dc.Mail
                        where x.Id_mail == id
                        select x;
            foreach (Mail m in query)
            {
                return m;
            }
            return null;
        }

        public void supprimer(Mail email, User user)
        {
            MailBoxMail lien = new MailBoxMail();
            lien.Mail_Id_mail = email.Id_mail;

            if (user.adresse_email == email.adresse_source)
            {
                
                lien.MailBox_Id_mailbox = this.getMailBox(user, "envoi").Id_mailbox;
            }
            else
            {
                lien.MailBox_Id_mailbox = this.getMailBox(this.getUser(email.adresse_dest), "recu").Id_mailbox;
            }
            dc.MailBoxMail.Attach(lien);
            dc.MailBoxMail.DeleteOnSubmit(lien);
            dc.SubmitChanges();
        }

        public List<Mail> getMail(string emailSource, string emailDest)
        {
            List <Mail> mails = new List<Mail>();

            var query = from x in dc.Mail
                        where x.adresse_source == emailSource && x.adresse_source == emailSource orderby x.etat_msg 
                        select x;

            foreach (Mail mail in query)
            {
                mails.Add(mail);
            }
            return mails;
        }


        public List<Mail> getMail1(string objet)
        {
            List<Mail> mails = new List <Mail>();

            var query = from x in dc.Mail
                        where x.objet == objet orderby x.etat_msg
                        select x;

            foreach (Mail mail in query)
            {
                mails.Add(mail);
            }
            return mails;
        }

        public DataTable Conversation (string emailSource, string emailDest)
        {
            var conversation = (from M in dc.Mail
                                join MbM in dc.MailBoxMail on M.Id_mail equals MbM.Mail_Id_mail
                                join Mb in dc.MailBox on MbM.MailBox_Id_mailbox equals Mb.Id_mailbox
                         
                                where M.adresse_dest == emailSource && M.adresse_dest == emailDest
                                orderby M.date_msg
                                select new
                                {
                                    M.Id_mail,
                                    Mb.libellé,
                                    M.adresse_source,
                                    M.adresse_dest,
                                    M.contenu,
                                    M.objet,
                                    M.date_msg
                                });

            DataTable dt = new DataTable();
            dt.Columns.Add("idMail", typeof(int));
            dt.Columns.Add("date", typeof(DateTime));
            dt.Columns.Add("objet", typeof(string));
            dt.Columns.Add("contenu", typeof(string));
            dt.Columns.Add("libellé", typeof(string));
            //dt.Columns.Add("date", typeof([));

            foreach (var res in conversation)
            {
                DataRow row = dt.NewRow();
                row["idMail"] = res.Id_mail;
                row ["date"] = res.date_msg;
                row ["objet"] = res.objet;
                row ["contenu"] = res.contenu;
                row ["libellé"] = res.libellé;
                dt.Rows.Add(row);
            }
            return dt;

        }
        public int NombreNonLus(string adresse)
        {
            return (from mail in dc.Mail where mail.adresse_dest == adresse select mail.Id_mail).Count();;
        }
    }
}
