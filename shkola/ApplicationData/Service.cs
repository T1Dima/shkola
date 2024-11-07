using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shkola.ApplicationData
{
    public class  Service
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public string Color { get; set; }

        public string PriceText => $"{Price} рублей за 30 минут";
        public string DiscountText => Discount > 0 ? $"Скидка {Discount * 100}%" : string.Empty;
    }
}
