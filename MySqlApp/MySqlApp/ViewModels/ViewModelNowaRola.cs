using GalaSoft.MvvmLight.Command;
using MySql.Data.MySqlClient;
using MySqlApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MySqlApp.ViewModels
{
    public class ViewModelNowaRola
    {
        public ICommand ButtonZmienRola { get; set; }

        private Users przesyl;

        public Users Przesyl
        {
            get { return przesyl; }
            set { przesyl = value; }
        }

        public ViewModelNowaRola()
        {
            ButtonZmienRola = new RelayCommand(ButtonZmienRolaChange);
        }

        private void ButtonZmienRolaChange()
        {
            string connectionString = @"server=localhost;
                                            user id=root;
                                            database=bazadanych;
                                            password=1234";

            MySqlConnection Polaczenie = new MySqlConnection(connectionString);
            Polaczenie.Open();
            try
            {
                

                string query = "SELECT COUNT(*) FROM user2 WHERE UserName = @UserName ";
                MySqlCommand komenda = new MySqlCommand(query, Polaczenie);

                komenda.CommandType = CommandType.Text;
                komenda.Parameters.AddWithValue("@UserName", Przesyl.Login.ToString());

                int licznik = Convert.ToInt32(komenda.ExecuteScalar());
                if (licznik == 1)
                {
                    string zapSQL = "UPDATE user2 SET Role = @Rola WHERE UserName = @Username";
                    MySqlCommand sqlCmd = new MySqlCommand(zapSQL, Polaczenie);

                    sqlCmd.Parameters.AddWithValue("@Rola", Przesyl.Rola.ToString());
                    sqlCmd.Parameters.AddWithValue("@Username", Przesyl.Login.ToString());

                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Czy chesz zmienic role na nowe ????");
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
    }
}