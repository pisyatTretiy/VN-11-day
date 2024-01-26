using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;

namespace VN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginUser.Text;
            string password = PasswordUser.Password;

            var userCred = new List<(string login, string password)>
            {
                ("123", "123"),
                ("admin", "admin"),
                ("admin", "123"),
                ("user", "user"),
                ("user", "123"),
                ("test", "test"),
                ("test", "123"),
                ("demo", "demo"),
                ("demo", "123"),
            };

            if(userCred.Any(creds => creds.login == login && creds.password == password))
            {
                Window1 window1 = new Window1();
                window1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Не найдено совпадений в логине и пароле!");
            }

        }
    }
}
