using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlApp.Models
{
    public class Rejestracja 
    {
        private string loginR;

        public string LoginR
        {
            get { return loginR; }
            set { loginR = value; }
        }

        private string hasloR;

        public string HasloR
        {
            get { return hasloR; }
            set { hasloR = value; }
        }

        private string hasloReR;

        public string HasloReR
        {
            get { return hasloReR; }
            set { hasloReR = value; }
        }

        public Rejestracja()
        {
            return;
        }

        public Rejestracja(string _userName, string _passwordHash, string _passwordSalt)
        {
            LoginR = _userName;
            HasloR = _passwordHash;
            HasloReR = _passwordSalt;
            
        }

    }
}
