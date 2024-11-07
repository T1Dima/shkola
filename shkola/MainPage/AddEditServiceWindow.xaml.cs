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
    /// Логика взаимодействия для AddEditServiceWindow.xaml
    /// </summary>
    public partial class AddEditServiceWindow : Window
    {
        private Service selectedService;

        public Service Service { get; private set; }

        public AddEditServiceWindow()
        {
            InitializeComponent();
            Service = new Service();  // Создаем новый объект Service
            DataContext = Service;
        }

        public AddEditServiceWindow(Service selectedService)
        {
            this.selectedService = selectedService;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;  // Закрыть окно и вернуть результат
        }
    }
}
