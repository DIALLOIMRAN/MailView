using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailView.DataModel;
using System.Text.RegularExpressions;

namespace MailView.Services
{
    class Validation
    {
        ModelDataContext dc = new ModelDataContext();
        private static int Chiffre(String pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsDigit(ch)) { num++; }
            }
            return num;
        }

        private static int UpperCase(String pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsUpper(ch)) { num++; }
            }
            return num;
        }

        private static int LowerCase(String pass)
        {
            int num = 0;
            foreach (char ch in pass)
            {
                if (char.IsLower(ch)) { num++; }
            }
            return num;
        }

        public static string validerPassword(string pass)
        {
            int min_lengh = 6;
            if (pass.Length < min_lengh || UpperCase(pass) < 1 || Chiffre(pass) < 1 || LowerCase(pass) < 1)
            {
                return "Invalide";
            }
            return "Valide";
        }

        public static string identique(string pass, string pass1)
        {
            if (pass == pass1)
            {
                return "identique";
            }

            return "nom identique";
        }

        public  Boolean adresseExiste(String email)
        {
            IEnumerable <string> query = from x in dc.User
                                        where
                                            x.adresse_email == email
                                        select  x.adresse_email ;
            foreach (string var in query)
            {
                if (var != "")
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean PasswordCorrect(string email, string pass)
        {
        //    if (this.adresseExiste(email))
        //    {
                IEnumerable <string> query = from x in dc.User
                            where
                                x.adresse_email == email && x.password == pass
                            select x.password;

                foreach (String password in query)
                {
                    if (password != "")
                    {
                        return true;
                    }
                }
                    
            //}
            return false ;
           
        }

        public Boolean adresseValide(string email)
        {
            Regex myRegex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", RegexOptions.IgnoreCase);
            return myRegex.IsMatch(email);
        }

        public Boolean phoneValide(string phone)
        {
            Regex myRegex = new Regex(@"(^06[0-9]{8}$|^00[0-9]{11,13}$)", RegexOptions.IgnoreCase);
            return myRegex.IsMatch(phone);
        }

    }
}
