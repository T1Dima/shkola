using shkola.ApplicationData;
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

namespace shkola.MainPage
{
    /// <summary>
    /// Логика взаимодействия для ServicesWindow.xaml
    /// </summary>
    public partial class ServicesWindow : Window
    {
        private ServiceViewModel viewModel;
        public ServicesWindow()
        {
            InitializeComponent();
            viewModel = new ServiceViewModel();
            DataContext = viewModel; // Устанавливаем DataContext для привязки данных в XAML
           
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var addEditServiceWindow = new AddEditServiceWindow();
            if (addEditServiceWindow.ShowDialog() == true)
            {
                viewModel.Services.Add(addEditServiceWindow.Service);  // Добавляем новую услугу
            }
        }


        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
           if (((Button)sender).Tag is Service selectedService)
        {
            var addEditServiceWindow = new AddEditServiceWindow(selectedService);
            if (addEditServiceWindow.ShowDialog() == true)
            {
                // Обновляем элемент в списке для отображения изменений
                int index = viewModel.Services.IndexOf(selectedService);
                viewModel.Services[index] = addEditServiceWindow.Service;
            }
            }
        }
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Tag is Service selectedService)
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить эту услугу?", "Подтверждение удаления",
                                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    viewModel.Services.Remove(selectedService);
                }
            }
        } 
    }
}
