using StudentApp.ApplicationData;
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

namespace StudentApp.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageCreatApp.xaml
    /// </summary>
    public partial class PageCreatApp : Page
    {
        public PageCreatApp()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.GoBack();

        }

        private void BtnCreat_Click(object sender, RoutedEventArgs e)
        {
            if (AppConnect.modelodb.User.Count(x => x.Login == TxbLogin.Text) > 0)
            {
                MessageBox.Show("Такой пользоваетль существует", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
            try
            {
                User userObj = new User()
                {
                    Login = TxbLogin.Text,
                    Name = TxbName.Text,
                    Password = TxbPass.Text,
                    idRole = 2,
                    DateIn = DateTime.Now
                };
                AppConnect.modelodb.User.Add(userObj);
                AppConnect.modelodb.SaveChanges();
                MessageBox.Show("данные добавлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении данных", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void PsbPass_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (TxbPass.Text != PsbPass.Password)
            {
                BtnCreat.IsEnabled = false;
                PsbPass.Background = Brushes.LightCoral;
                PsbPass.BorderBrush = Brushes.Red;
            }
            else
            {
                BtnCreat.IsEnabled = true;
                PsbPass.Background = Brushes.LightGreen;
                PsbPass.BorderBrush = Brushes.Green;
            }
        }
    }
}
