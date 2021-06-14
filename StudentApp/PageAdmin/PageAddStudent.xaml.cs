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
    /// Логика взаимодействия для PageAddStudent.xaml
    /// </summary>
    public partial class PageAddStudent : Page
    {
        public PageAddStudent()
        {
            InitializeComponent();

            CmbFormTime.SelectedValuePath = "id";
            CmbFormTime.DisplayMemberPath = "Name";
            CmbFormTime.ItemsSource = AppConnect.modelodb.FormTime.ToList();

            CmbNameGr.SelectedValuePath = "id";
            CmbNameGr.DisplayMemberPath = "Name";
            CmbNameGr.ItemsSource = AppConnect.modelodb.NameDeport.ToList();

            Cmbspecial.SelectedValuePath = "id";
            Cmbspecial.DisplayMemberPath = "Name";
            Cmbspecial.ItemsSource = AppConnect.modelodb.Special.ToList();

            CmbYear.SelectedValuePath = "id";
            CmbYear.DisplayMemberPath = "Year";
            CmbYear.ItemsSource = AppConnect.modelodb.YearAdd.ToList();


        }

        private void BtnCreat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Employes studObj = new Employes()
                {
                    Name = TxbNameStudent.Text,
                    Special = Cmbspecial.SelectedItem as Special,
                    YearAdd = CmbYear.SelectedItem as YearAdd,
                    NameDeport = CmbNameGr.SelectedItem as NameDeport,
                    FormTime = CmbFormTime.SelectedItem as FormTime

                };
                AppConnect.modelodb.Employes.Add(studObj);
                AppConnect.modelodb.SaveChanges();
                MessageBox.Show("Студент добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                AppFrame.FrameMain.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка" + ex.Message.ToString(), "Критическая ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
