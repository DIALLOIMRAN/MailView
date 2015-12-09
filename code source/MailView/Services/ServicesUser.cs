using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailView.DataModel;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Data;
using System.IO;
using System.Drawing;

namespace MailView.Services
{
    
    class ServicesUser
    {
        ModelDataContext dc = new ModelDataContext();
        public Boolean S_inscrire(string nom, string prenom, string email, string password, string phone)
        {
                User user = new User();
                user.nom = nom;
                user.prenom = prenom;
                user.adresse_email = email;
                user.password = password;
                user.numTelephone = phone;
                user.connecté = 0;
                user.photo = this.ReadFile("..\\..\\Resources\\inconnu.jpg");
               if(!(new Validation().adresseExiste(email)))
               {
                   dc.User.InsertOnSubmit(user);
                   dc.SubmitChanges();
                   this.creerMailBox(user);
                   return true;
               }
               return false;
        }

        public DataTable allUser()
        {
            var query = from x in dc.User
                        select x;


            DataTable dt = new DataTable();
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Prénom", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("téléphone", typeof(string));
            //dt.Columns.Add("date", typeof([));

            foreach (var res in query)
            {
                DataRow row = dt.NewRow();
                row["Nom"] = res.Id_user;
                row["Nom"] = res.nom;
                row["Prénom"] = res.prenom;
                row["Email"] = res.adresse_email;
                row["téléphone"] = res.numTelephone;
                dt.Rows.Add(row);
            }
            return dt;
        }
        public void mettreAjour(User user)
        {
            User user1 = dc.User.Single(u => u.Id_user == user.Id_user);
            user1.nom = user.nom;
            user1.prenom = user.prenom;
            user1.adresse_email = user.adresse_email;
            user1.password = user.password;
            user1.numTelephone = user.numTelephone;
            user1.sexe = user.sexe;
            user1.photo = user.photo;
            dc.SubmitChanges();
                    
        }

        public byte[] ReadFile(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        public Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
       

        public void creerMailBox(User user)
        {
            MailBox recu = new DataModel.MailBox(), envoi = new DataModel.MailBox();
            recu.UserId_user = user.Id_user;
            recu.libellé = "recu";

            envoi.UserId_user = user.Id_user;
            envoi.libellé = "envoi";
            dc.MailBox.InsertOnSubmit(recu);
            dc.MailBox.InsertOnSubmit(envoi);
            dc.SubmitChanges();
            
        }


        public User getUser (int id)
        {
            var query = from x in dc.User
                        where x.Id_user == id
                        select x;

            foreach (User user in query)
            {
                return user;
            }

            return null;
        }

        public User getUser1(string id)
        {
            var query = from x in dc.User
                        where x.adresse_email == id
                        select x;

            foreach (User user in query)
            {
                return user;
            }

            return null;
        }
        public DataTable getUserAdresse(string adresse)
        {
            var query = from x in dc.User
                        where x.adresse_email == adresse
                        select x;


            DataTable dt = new DataTable();
            
            dt.Columns.Add("Nom", typeof(string));
            dt.Columns.Add("Prénom", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("téléphone", typeof(string));
            //dt.Columns.Add("date", typeof([));

            foreach (var res in query)
            {
                DataRow row = dt.NewRow();
                
                row["Nom"] = res.nom;
                row["Prénom"] = res.prenom;
                row["Email"] = res.adresse_email;
                row["téléphone"] = res.numTelephone;
                dt.Rows.Add(row);
            }
            return dt;
        }
        public User getUserAdressePhone(string adresse, string phone)
        {
            var query = from x in dc.User
                        where x.adresse_email == adresse && x.numTelephone == phone
                        select x;
            foreach (User user in query)
            {
                return user;
            }

            return null;
        }
        public User seConnecter(string email, string password)
        {
            var query = from x in dc.User
                        where x.adresse_email == email
                        select x;
            foreach (User user in query)
            {
                user.connecté = 1;
                dc.SubmitChanges();

                return user;
            }
            //IEnumerable <string> rq = from x in dc.User
            //         where x.adresse_email == email
            //         select x.adresse_email;

            //foreach (string v in rq)
            //{
            //    //v.connecté = 1;
            //    //dc.SubmitChanges();


            //    return new ServicesMail().getUser(v);
            //}
            return null;
        }

        public void seDeconnecter(User user)
        {
            User user1 = dc.User.Single(u => u.Id_user == user.Id_user);
            user1.connecté = 0;
            dc.SubmitChanges();
        }

        public Boolean passwordCorrect(string email, string password)
        {
            var rq = from x in dc.User
                    where x.adresse_email == email && x.password == password 
                    select x;

            foreach (User v in rq)
            {
                if(v != null)
                {
                    return true;
                }
                
                else
                {
                 return false;
                }
            }
            return false;
            
        }


        public void envoyerDemande(int idUser1, int idUser2)
        {

            User user1 = this.getUser(idUser1);
            User user2 = this.getUser(idUser2);

            UserUser liens = new UserUser();
            liens.User1_Id_user = user1.Id_user;
            liens.User2_Id_user = user2.Id_user;
            dc.UserUser.InsertOnSubmit(liens);
            dc.SubmitChanges();

        }

        public void accepterInvitation(int idUser1, int idUser2)
        {
            this.envoyerDemande(idUser2, idUser1);
        }

        public void refuserInvitation(int idUser1, int idUser2)
        {
            User user1 = this.getUser(idUser1);
            User user2 = this.getUser(idUser2);

            UserUser liens = new UserUser();
            liens.User1_Id_user = user1.Id_user;
            liens.User2_Id_user = user2.Id_user;
            dc.UserUser.DeleteOnSubmit(liens);
            dc.SubmitChanges();
        }
    }
}
