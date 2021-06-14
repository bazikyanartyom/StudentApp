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
    /// Логика взаимодействия для PageDeleteStudent.xaml
    /// </summary>
    public partial class PageDeleteStudent : Page
    {
        public PageDeleteStudent()
        {
            InitializeComponent();
            GridDeleteStudent.ItemsSource = AppConnect.modelodb.Employes.ToList();
            CmbGroup.SelectedValuePath = "id";
            CmbGroup.DisplayMemberPath = "Name";
            CmbGroup.ItemsSource = AppConnect.modelodb.NameDeport.ToList();
        }

        private void CmbGroup_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int SelectGroup = Convert.ToInt32(CmbGroup.SelectedValue);
            GridDeleteStudent.ItemsSource = AppConnect.modelodb.Employes.Where(x => x.idNameDeport == SelectGroup).ToList();

        }

        private void BtnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            int SelectGroup = Convert.ToInt32(CmbGroup.SelectedValue);
            try
            {
                if (GridDeleteStudent.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < GridDeleteStudent.SelectedItems.Count; i++)
                    {
                        Employes studentObj = GridDeleteStudent.SelectedItems[i] as Employes;
                        AppConnect.modelodb.Employes.Remove(studentObj);
                    }
                    AppConnect.modelodb.SaveChanges();
                    MessageBox.Show("студент удален");
                    GridDeleteStudent.ItemsSource = AppConnect.modelodb.Employes.Where(x => x.idNameDeport == SelectGroup).ToList();
                }
                else
                {
                    MessageBox.Show("В таблице нет данных");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка работы приложения" + ex.Message.ToString());
            }
        }
    }
}
