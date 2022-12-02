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
using System.Windows.Media.Animation;
namespace WpfApp3
{
    
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            
            InitializeComponent();
            db = new ApplicationContext();

            DoubleAnimation btAnimation = new DoubleAnimation();
            btAnimation.From = 0;
            btAnimation.To = 450;
            btAnimation.Duration = TimeSpan.FromSeconds(3);
            animatButton.BeginAnimation(Button.WidthProperty, btAnimation);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass = TextBoxPassword.Password.Trim(); ;
            if (login.Length < 5)
            {
                Clear();
                TextBoxLogin.ToolTip = "Это поле введено не корректно!";
                TextBoxLogin.Background = Brushes.DarkRed;
            }
            
            else if (pass.Length < 5)
            {
                Clear();
                TextBoxPassword.ToolTip = "Это поле введено не корректно!";
                TextBoxPassword.Background = Brushes.DarkRed;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                TextBoxPassword.ToolTip = "";
                TextBoxPassword.Background = Brushes.Transparent;

               

                User user = new User(login, pass);
                db.Users.Add(user);
                db.SaveChanges();

                AuthWindow authWindow = new AuthWindow();
                authWindow.Show();
                Hide();

            }
        }
        private void Clear()
        {

            TextBoxLogin.ToolTip = "";
            TextBoxLogin.Background = Brushes.Transparent;
            TextBoxPassword.ToolTip = "";
            TextBoxPassword.Background = Brushes.Transparent;
        }
        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            Hide();
        }
    }
}
