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
    /// Логика взаимодействия для PageStudentList.xaml
    /// </summary>
    public partial class PageStudentList : Page
    {
        public PageStudentList()
        {
            InitializeComponent();
            CmbGroup.DisplayMemberPath = "Name";
            CmbGroup.SelectedValuePath = "Id";
            CmbGroup.ItemsSource = AppConnect.modelodb.NameDeport.ToList();

            ListStudent.ItemsSource = AppConnect.modelodb.Employes.ToList();
             
        }
        public void UpdateData(object sender, object e)
        {
            ListStudent.ItemsSource = AppConnect.modelodb.Employes.ToList();
        }
        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAccept_Click(object sender, RoutedEventArgs e)
        {
            int SelectGroup = Convert.ToInt32(CmbGroup.SelectedValue);
            ListStudent.ItemsSource = AppConnect.modelodb.Employes.Where(x => x.idNameDeport == SelectGroup).ToList();
            ListStudent.SelectedIndex = 0;
        }
        private void BtnSelectStudent_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
