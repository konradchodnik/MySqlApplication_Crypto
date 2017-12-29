using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlApp.Models
{
    public enum Rola { Administrator, Obserwator }
    public enum LogDoServa { localhost, MysqlServ, Sqlite }

    public class Users
    {
        private int _Nr;
        private string _Imie;
        private string _Nazwisko;
        private string _Login;
        private string _Haslo;
        private string _HasloSalt;
        private string _Data;
        private string _Rolax;
        private Rola _Rola;


        public Int32 Nr
        {
            get { return _Nr; }
            set
            {
                _Nr = value;
              
            }
        }
        public string Imie
        {
            get { return _Imie; }
            set
            {
                _Imie = value;
              
            }
        }
        public string Nazwisko
        {
            get { return _Nazwisko; }
            set
            {
                _Nazwisko = value;
              
            }
        }
        public string Login
        {
            get { return _Login; }
            set
            {
                _Login = value;
             
            }
        }
        public string Haslo
        {
            get { return _Haslo; }
            set
            {
                _Haslo = value;
              
            }
        }
        public string HasloSalt
        {
            get { return _HasloSalt; }
            set
            {
                _HasloSalt = value;
               
            }
        }
        public string Data
        {
            get { return _Data; }
            set
            {
                _Data = value;
              
            }
        }
        //rola jako string
        public string Rolax
        {
            get { return _Rolax; }
            set
            {
                _Rolax = value;
               
            }
        }

        public Rola Rola
        {
            get { return _Rola; }
            set
            {
                _Rola = value;
               
            }
        }
        public string Error
        {
            get;
            private set;
        }



        public Users(int nr, string imie, string nazwisko, string login, string haslo,
                                string haslosalt, string data, string rolax/*  Rola rola*/)
        {
            Nr = nr;
            Imie = imie;
            Nazwisko = nazwisko;
            Login = login;
            Haslo = haslo;
            HasloSalt = haslosalt;
            Data = data;
            Rolax = rolax;
        }

        public Users()
        {
        }
    }
}
