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
    /// Логика взаимодействия для PageEditEvalution.xaml
    /// </summary>
    public partial class PageEditEvalution : Page
    {
        public PageEditEvalution()
        {
            InitializeComponent();
            CmbNameGroup.SelectedValuePath = "id";
            CmbNameGroup.DisplayMemberPath = "Name";
            CmbNameGroup.ItemsSource = AppConnect.modelodb.NameDeport.ToList();

        }

          private void CmbNameGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectGroup = Convert.ToInt32(CmbNameGroup.SelectedValue);
            ListStudent.ItemsSource = AppConnect.modelodb.Employes.Where(x => x.idNameDeport == SelectGroup).ToList();
            ListStudent.SelectedIndex = 0;
        }

       
        private void BtnEditGrade_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
