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
    public class ViewModelZmianaHasla
    {
        public ICommand NoweHaslo { get; set; }

        private Users odniesienie;
        public Users Odniesienie
        {
            get { return odniesienie; }
            set { odniesienie = value; }
        }

        private DanePass danepassy;
        public DanePass Danepassy
        {
            get { return danepassy; }
            set { danepassy = value; }
        }


        public ObservableCollection<Users> PrzeslaneDane { get; set; } = new ObservableCollection<Users>();

        public ViewModelZmianaHasla()
        {
            NoweHaslo = new RelayCommand(NoweHasloZmien);
            danepassy = new DanePass("", "");
        }

        private void NoweHasloZmien()
        {
            string connectionString = @"server=localhost;
                                            user id=root;
                                            database=bazadanych;
                                            password=1234";

            MySqlConnection Polaczenie = new MySqlConnection(connectionString);
            Polaczenie.Open();

            try
            {
              
                var salt = CryptoService.GenerateSalt();
                var hash = CryptoService.ComputeHash(Danepassy.HaslosaltPass, salt);


                string zapSQL = "UPDATE user2 SET PasswordHash = @ZmienHaslo, PasswordSalt = @ZmienSalt WHERE UserName = @Username";
                MySqlCommand sqlCmd = new MySqlCommand(zapSQL, Polaczenie);


                sqlCmd.Parameters.AddWithValue("@ZmienHaslo", Convert.ToBase64String(hash));
                sqlCmd.Parameters.AddWithValue("@ZmienSalt", Convert.ToBase64String(salt));
                sqlCmd.Parameters.AddWithValue("@Username", Odniesienie.Login.ToString());

                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Czy chesz zmienic haslo na nowe ????");

              
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
    }
}
