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
using WpfOptionFiveApp.Context;
using WpfOptionFiveApp.Views.Windows;

namespace WpfOptionFiveApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AvtorizationWindow : Window
    {
        public AvtorizationWindow()
        {
            InitializeComponent();
        }

        private void Seebtn_Click(object sender, RoutedEventArgs e)
        {
            if (HidenPassword.Visibility == Visibility.Collapsed)
            {
                HidenPassword.Visibility = Visibility.Visible;
                SeePassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                HidenPassword.Visibility = Visibility.Collapsed;
                SeePassword.Visibility = Visibility.Visible;
            }
        }

        private void HidenBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SeePassword.Visibility == Visibility.Collapsed)
            {
                HidenPassword.Visibility = Visibility.Collapsed;
                SeePassword.Visibility = Visibility.Visible;
            }
            else
            {
                HidenPassword.Visibility = Visibility.Visible;
                SeePassword.Visibility = Visibility.Collapsed;
            }
        }

        private void Loginbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbPassword.Text == "" && Logintxb.Text == "")
                {
                    throw new Exception("Заполните все поля");
                }
                else
                {
                    // Запрос на авторизацию
                    var currentUser = Data.cc.User.FirstOrDefault(item => item.Username == Logintxb.Text && item.Password == psbPassword.Password);
                    if (currentUser != null)
                    {
                        switch (currentUser.IDRole)
                        {
                            case "a":
                                AdminWindow adminWindow = new AdminWindow();
                                adminWindow.ShowDialog();
                                break;

                            case "m":
                                ManagerWindow managerWindow = new ManagerWindow();
                                managerWindow.ShowDialog();
                                break;
                        }
                    }
                    else
                    {
                        throw new Exception("Пользователь не найден");
                    }
                }

            }
            catch
            {

            }
        }
      
        private void Cancelbtn_Click(object sender, RoutedEventArgs e)
        {
           Application.Current.Shutdown();
        }
    }
}
