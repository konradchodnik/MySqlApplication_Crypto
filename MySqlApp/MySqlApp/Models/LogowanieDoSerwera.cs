using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlApp.Models
{
    public class LogowanieDoSerwera
    {
        private string Server;

        public string server
        {
            get { return Server; }
            set { Server = value; }
        }

        private string User;

        public string user
        {
            get { return User; }
            set { User = value; }
        }

        private string BazaDanych;

        public string bazadanych
        {
            get { return BazaDanych; }
            set { BazaDanych = value; }
        }

        private string Password;

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public LogowanieDoSerwera()
        {
            return;
        }


        public LogowanieDoSerwera(string server, string user, string bazadanych, string password)
        {
            Server = server;
            User = user;
            BazaDanych = bazadanych;
            Password = password;
        }
    }
}
