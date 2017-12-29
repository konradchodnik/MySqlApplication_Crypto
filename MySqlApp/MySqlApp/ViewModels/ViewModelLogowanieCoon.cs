using GalaSoft.MvvmLight.Command;
using MySqlApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MySqlApp.ViewModels
{
    public class ViewModelLogowanieCoon
    {
        public ICommand ZalogujDoAplikacji { get; set; }
        private LogowanieDoSerwera logowanieDoSerwera;
        public LogowanieDoSerwera LogowanieDoSerwera
        {
            get { return logowanieDoSerwera; }
            set { logowanieDoSerwera = value; }
        }

        //powpisywanie danych, zeby nie trzeba wpisywac
        public ObservableCollection<LogowanieDoSerwera> iLogowanieDoSerwera { get; set; }
        ObservableCollection<LogowanieDoSerwera> listaLogowanieDoSerwera = new ObservableCollection<LogowanieDoSerwera>();

        public ViewModelLogowanieCoon()
        {
            logowanieDoSerwera = new LogowanieDoSerwera("localhost", "root", "bazadanych", "1234");
            ZalogujDoAplikacji = new RelayCommand(ZalogujDoAplikacjiButton);
            iLogowanieDoSerwera = listaLogowanieDoSerwera;
        }
        private void ZalogujDoAplikacjiButton()
        {
            //wazne - connection string bez bialych znakow
            string connectionString = string.Format(@"server={0}; user id={1}; database={2}; password={3}"
                                                    ,logowanieDoSerwera.server, logowanieDoSerwera.user
                                                    ,logowanieDoSerwera.bazadanych, logowanieDoSerwera.password);

            try
            {

                SqlHelper odczyt = new SqlHelper(connectionString);
                if (odczyt.IsConnection)
                {
                    var openMain = new MainWindow();
                    var context = new MainViewModel();
                    openMain.DataContext = context;
                    openMain.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Podane dane do logowana sia nieprawidłowe.");
            }
        }
    }
}
