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
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass = TextBoxPassword.Password.Trim(); ;
            if (login.Length < 5)
            {
                
                TextBoxLogin.ToolTip = "Это поле введено не корректно!";
                TextBoxLogin.Background = Brushes.DarkRed;
            }

            else if (pass.Length < 5)
            {
                
                TextBoxPassword.ToolTip = "Это поле введено не корректно!";
                TextBoxPassword.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPassword.ToolTip = "";
                TextBoxPassword.Background = Brushes.Transparent;

                User authUser = null;
                using(ApplicationContext context = new ApplicationContext())
                {
                    authUser = context.Users.Where(b=>b.Login == login && b.Pass == pass).FirstOrDefault();
                }
                if(authUser != null)
                {
                    
                    UserPageWindow userPageWindow = new UserPageWindow();
                    userPageWindow.Show();
                    Hide();
                }
                
                else
                    MessageBox.Show("Вы ввели что-то не корректно)");
            }
        }

        private void Button_B_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
