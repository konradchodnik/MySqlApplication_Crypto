using GalaSoft.MvvmLight.Command;
using MySql.Data.MySqlClient;
using MySqlApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MySqlApp.ViewModels
{
    public class MainViewModel
    {
        public ICommand Usuń { get; set; }
        public ICommand Odśwież { get; set; }
        public ICommand Wyczyść { get; set; }
        public ICommand Zmienianie { get; set; }
        public ICommand ZmienHaslo { get; set; }
        public ICommand DodajVM { get; set; }
        //Widok MainWindow
        public ICommand ZmienHaslaVol2 { get; set; }
        //prototyp do - widoku NoweHaslo i Zmiana hasla
        public ICommand NoweHaslo { get; set; }
        //to jest przycisk wewnatrz NoweHaslo do zmiany
        public ICommand ZmienHaslaN { get; set; }
        //Zmienione na czytelne

        public ObservableCollection<Users> PrzeslaneDane { get; set; } = new ObservableCollection<Users>();

        private Rejestracja _daneRejestracja;
        public Rejestracja Rejestruj { get { return _daneRejestracja; } }
        public ObservableCollection<Rejestracja> Rejestr { get; set; } = new ObservableCollection<Rejestracja>();

        //zaznaczenie
        private Users _Zaznaczenie;
        public Users Zaznaczenie { get { return _Zaznaczenie; } set { _Zaznaczenie = value; } }

        public MainViewModel()
        {   
            _daneRejestracja = new Rejestracja();
            Usuń = new RelayCommand(UsuńButton);
            Wyczyść = new RelayCommand(WyczyśćButton);
            Odśwież = new RelayCommand(OdświeżButton);  
            ZmienHaslo = new RelayCommand(ZmienHasloOpenView); 
            Zmienianie = new RelayCommand(ZmienianieButton_ZmienRola);
            ZmienHaslaN = new RelayCommand(ButtonZmienHaslaN);
            ZmienHaslaVol2 = new RelayCommand(ZmienHaslaVol2Button);
            DodajVM = new RelayCommand(DodajVMButton);
            OdświeżButton();
        }
        private void UsuńButton()
        {
            try
            {
                string connectionString = @"server=localhost;
                                            user id=root;
                                            database=bazadanych;
                                            password=1234";


                MySqlConnection Polaczenie = new MySqlConnection(connectionString);


                MySqlCommand komenda = Polaczenie.CreateCommand();
                Polaczenie.Open();

                var obj = (Users)Zaznaczenie;

                //usowanie dla uzytkownika z kolekjci
                PrzeslaneDane.Remove(Zaznaczenie);

                komenda.CommandText = @"DELETE FROM user2 WHERE UserName = @uchwytZaznaczenia";

                komenda.Parameters.AddWithValue("@uchwytZaznaczenia", obj.Login);

                komenda.ExecuteNonQuery();

                Polaczenie.Close();

                MessageBox.Show("Czy aby napewno chcesz usunać : " + obj.Login);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void WyczyśćButton()
        {
            PrzeslaneDane.Clear();
        }
        private void OdświeżButton()
        {

            PrzeslaneDane.Clear();

            try
            {
                string connectionString = @"server=localhost;
                                            user id=root;
                                            database=bazadanych;
                                            password=1234";

                MySqlConnection Polaczenie = new MySqlConnection(connectionString);

                string Zapytanie = "SELECT * FROM bazadanych.user2";

                Polaczenie.Open();

                MySqlCommand komenda = new MySqlCommand(Zapytanie, Polaczenie);
                
                var reader = komenda.ExecuteReader();
                while (reader.Read())
                {

                    var imie = reader.GetString(1);
                    var nazwisko = reader.GetString(2);
                    var login = reader.GetString(3);
                    var haslo = reader.GetString(4);
                    var haslosalt = reader.GetString(5);
                    var data = reader.GetString(6);
                    var rola = reader.GetString(7);

                    PrzeslaneDane.Add(new Users
                    {

                        Imie = imie,
                        Nazwisko = nazwisko,
                        Login = login,
                        Haslo = haslo,
                        HasloSalt = haslosalt,
                        Data = data,
                        Rolax = rola
                    });

                }
                Polaczenie.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void ZmienHasloOpenView()
        {
            (new NoweHaslo()).Show();

        }
        private void ZmienianieButton_ZmienRola()
        {
            try
            {

                string connectionString = @"server=localhost;
                                            user id=root;
                                            database=bazadanych;
                                            password=1234";


                MySqlConnection Polaczenie = new MySqlConnection(connectionString);


                MySqlCommand komenda = Polaczenie.CreateCommand();

                Polaczenie.Open();

                var obj = (Users)Zaznaczenie;



                string query = "SELECT COUNT(*) FROM user2 WHERE UserName = @UserName ";
                komenda = new MySqlCommand(query, Polaczenie);
                komenda.CommandType = CommandType.Text;
                komenda.Parameters.AddWithValue("@UserName", obj.Login);

                komenda.ExecuteScalar();


                var openRola = new NowaRola();

                var context = new ViewModelNowaRola();
                context.Przesyl = Zaznaczenie;
                openRola.DataContext = context;
                openRola.Show();


                Polaczenie.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void ButtonZmienHaslaN()
        {
            string connectionString = @"server=localhost;
                                            user id=root;
                                            database=bazadanych;
                                            password=1234";

            MySqlConnection Polaczenie = new MySqlConnection(connectionString);
            Polaczenie.Open();

            try
            {
 
                var passwordSalt = CryptoService.GenerateSalt();
                var newPassword = _daneRejestracja.HasloR.ToString();
                var passwordHash = CryptoService.ComputeHash(newPassword, passwordSalt);

                string pobranie = "SELECT * FROM user2 WHERE UserName = @UserName";

                MySqlCommand komenda = new MySqlCommand(pobranie, Polaczenie);

                komenda.CommandType = CommandType.Text;
                //user

                komenda.Parameters.AddWithValue("@UserName", _daneRejestracja.LoginR.ToString());
                komenda.Parameters.AddWithValue("@password", _daneRejestracja.HasloR.ToString());
                komenda.Parameters.AddWithValue("@ZmienHaslo", _daneRejestracja.HasloReR.ToString());

                string passwordsalt = string.Empty, passwordhash = string.Empty, username = string.Empty;
                var reader = komenda.ExecuteReader();
                while (reader.Read())
                {
                    username = reader.GetString(3);
                    passwordhash = reader.GetString(4); // odczytane hash
                    passwordsalt = reader.GetString(5); //odczytane salt
                }

                if (username != null)
                {
                    PrzeslaneDane.Add(new Users { Imie = username, Haslo = Convert.ToString(passwordHash), HasloSalt = passwordsalt.ToString() });
                    reader.Close();
                    //rozkodowanie
                    var passRozkodowanie = CryptoService.VerifyPassword(_daneRejestracja.HasloR, Convert.FromBase64String(passwordsalt), Convert.FromBase64String(passwordhash));

                    MessageBox.Show("w tym moemecie jest " + passRozkodowanie + " pass: " + _daneRejestracja.HasloR);
                    if (passRozkodowanie == true)
                    {
                        var salt = CryptoService.GenerateSalt();
                        var hash = CryptoService.ComputeHash(_daneRejestracja.HasloR, salt);


                        string zapSQL = "UPDATE user2 SET PasswordHash = @ZmienHaslo, PasswordSalt = @ZmienSalt WHERE UserName = @Username";
                        MySqlCommand sqlCmd = new MySqlCommand(zapSQL, Polaczenie);


                        sqlCmd.Parameters.AddWithValue("@ZmienHaslo", Convert.ToBase64String(hash));
                        sqlCmd.Parameters.AddWithValue("@ZmienSalt", Convert.ToBase64String(salt));
                        sqlCmd.Parameters.AddWithValue("@Username", _daneRejestracja.LoginR.ToString());

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Czy chesz zmienic haslo ????");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Polaczenie.Close();
            }

        }   
        private void ZmienHaslaVol2Button()
        {
            try
            {

                string connectionString = @"server=localhost;
                                            user id=root;
                                            database=bazadanych;
                                            password=1234";


                MySqlConnection Polaczenie = new MySqlConnection(connectionString);


                MySqlCommand komenda = Polaczenie.CreateCommand();

                Polaczenie.Open();

                var obj = (Users)Zaznaczenie;

                string query = "SELECT COUNT(*) FROM user2 WHERE UserName = @UserName ";
                komenda = new MySqlCommand(query, Polaczenie);
                komenda.CommandType = CommandType.Text;
                komenda.Parameters.AddWithValue("@UserName", obj.Login);

                komenda.ExecuteScalar();


                var openHaslo = new ZmianaHasla();

                var context = new ViewModelZmianaHasla();
                
                context.Odniesienie = Zaznaczenie;
                openHaslo.DataContext = context;
                openHaslo.Show();


                Polaczenie.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }
        private void DodajVMButton()
        {
            var openDodaj = new ViewDodaj();
            var context = new ViewModelDodaj();

            openDodaj.DataContext = context;
            openDodaj.Show();

        }
    }
}
