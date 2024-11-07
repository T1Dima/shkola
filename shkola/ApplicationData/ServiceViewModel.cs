using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shkola.ApplicationData
{
    internal class ServiceViewModel
    {
        // Коллекция услуг, которая будет привязана к интерфейсу
        public ObservableCollection<Service> Services { get; set; }

        public ServiceViewModel()
        {
            
            Services = new ObservableCollection<Service>
            {
                new Service { Name = "Английский", Price = 800, Discount = 0.1m, Color = "LightPink" },
                new Service { Name = "Испанский", Price = 600, Discount = 0.15m, Color = "LightBlue" },
                new Service { Name = "Португальский", Price = 900, Discount = 0.05m, Color = "LightGreen" }
            };
        }
        }
}
