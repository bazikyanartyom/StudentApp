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

namespace StudentApp.PageStudent
{
    /// <summary>
    /// Логика взаимодействия для PageAccountStydent.xaml
    /// </summary>
    public partial class PageAccountStydent : Page
    {
        public PageAccountStydent()
        {
            InitializeComponent();
            var studentObj = AppConnect.modelodb.User.FirstOrDefault(x => x.id == AccountHelpClass.id);
            TxtNameStudent.Text = studentObj.Name;
            TxtDateEvent.Text = Convert.ToString(studentObj.DateIn);
            TxtLoginUser.Text = studentObj.Login;
            listGridView.ItemsSource = AppConnect.modelodb.User.ToList();


        }

        private void listGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
