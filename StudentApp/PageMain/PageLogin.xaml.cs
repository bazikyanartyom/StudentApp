using StudentApp.ApplicationData;
using StudentApp.PageAdmin;
using StudentApp.PageStudent;
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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }
        private void BtnInLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.modelodb.User.FirstOrDefault(x => x.Login == TxbLogin.Text && x.Password == PxbPassword.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Такого нет", "Ошибка при авторизации", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    AccountHelpClass.id = userObj.id;
                    switch (userObj.idRole)
                    {
                        case 1:
                            AppFrame.FrameMain.Navigate(new PageMenuAdmin());
                            //MessageBox.Show ("Привет,"+ userObj.Role.Name+"," + userObj.Name, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                        case 2:
                            AppFrame.FrameMain.Navigate(new PageAccountStydent());
                            //MessageBox.Show("Привет," + userObj.Role.Name + "," + userObj.Name, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                        
                        default:
                            MessageBox.Show("NET", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка" + ex.Message.ToString(), "Критическая ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }



        private void BtnInLogin_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageCreatApp());
        }
    }
}
