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

namespace CollageDevices
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

        public void userLogin (string Login, string Password)
        {
            var userLogin = CollegeDevicesEntities.GetContext().Users.Where(p => p.login == Login && p.password == Password).FirstOrDefault();
            if(userLogin != null)
            {
                MessageBox.Show($"Зравствуйте {userLogin.fullname}");
            }
            else
            {
                MessageBox.Show("Введен неверный логин или пароль!");
            }
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            userLogin(tbLogin.Text, tbPassword.Password);
        }
    }
}
