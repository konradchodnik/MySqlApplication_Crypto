using GalaSoft.MvvmLight.Command;
using MySql.Data.MySqlClient;
using MySqlApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MySqlApp.ViewModels
{
    public class ViewModelDodaj
    {
        public ICommand DodajUzytkownika { get; set; }
        private Users danePrzesylane;
        public Users PrzeslaneDan { get { return danePrzesylane; } }

        public ViewModelDodaj()
        {
            //konstruktor staly nr
            danePrzesylane = new Users();
            DodajUzytkownika = new RelayCommand(DodajUzytkownikaButton);
        }
        private void DodajUzytkownikaButton()
        {
           
            try
            {

                var passwordSalt = CryptoService.GenerateSalt();
                var passwordHash = CryptoService.ComputeHash(danePrzesylane.Haslo, passwordSalt);

               
                //inserty dzialaja
                string connectionString = @"server=localhost;
                                            user id=root;
                                            database=bazadanych;
                                            password=1234";


                MySqlConnection Polaczenie = new MySqlConnection(connectionString);

                //Wstawienie aktualnej daty dodania
                DateTime nowaData = DateTime.Now;
                string date = nowaData.ToString("yyyy-MM-dd H:mm:ss");


                MySqlCommand komenda = Polaczenie.CreateCommand();
                Polaczenie.Open();
                komenda.CommandText = @"INSERT INTO user2(Id, FirstName, LastName, UserName, PasswordHash, PasswordSalt, LastLongon, Role)"
                                     + "values(@id, @imie, @nazwisko, @login, @haslo, @hasloSalt, @data, @rola)";

                komenda.Parameters.AddWithValue("@id", danePrzesylane.Nr);
                komenda.Parameters.AddWithValue("@imie", danePrzesylane.Imie);
                komenda.Parameters.AddWithValue("@nazwisko", danePrzesylane.Nazwisko);
                komenda.Parameters.AddWithValue("@login", danePrzesylane.Login);
                komenda.Parameters.AddWithValue("@haslo", Convert.ToBase64String(passwordHash));
                komenda.Parameters.AddWithValue("@hasloSalt", Convert.ToBase64String(passwordSalt));
                komenda.Parameters.AddWithValue("@data", date);
                komenda.Parameters.AddWithValue("@rola", danePrzesylane.Rola);
                komenda.ExecuteNonQuery();

                Polaczenie.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
