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


namespace StudentApp.PageAdmin
{
    /// <summary>
    /// Логика взаимодействия для PageMenuAdmin.xaml
    /// </summary>
    public partial class PageMenuAdmin : Page
    {
        public PageMenuAdmin()
        {
            InitializeComponent();
        }
   
      
        private void BtnListStudent_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageStudentList());
        }

           private void BtnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageDeleteStudent());
        }

        private void BtnAddStednt_Click_1(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageAddStudent());
        }
    }
}
