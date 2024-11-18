using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyForm
{
    public class _NetworkEquip
    {
        // поля
        private string color;
        private int price;
        private string firm;
        // свойства
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value == null) color = "";
                else color = value;
            }
        }
        public string Firm
        {
            get
            {
                return firm;
            }
            set
            {
                if (value == null) firm = "";
                else firm = value;
            }
        }
        public int Price
        {
            get { return price; }
            set
            {
                if (value < 0 || value > 1999999) price = 0;
                else price = value;
            }
        }
        // конструктор
        public _NetworkEquip(string color = "", int price = 0,string firm = "")
        {
            Color = color;
            Price = price;
            Firm = firm;
        }
        // метод Print
        public virtual void Print_Info()
        {
            Console.WriteLine($"Цвет: {Color}");
            Console.WriteLine($"Цена (Руб.): {Price}");
            Console.WriteLine($"Фирма: {Firm}");
        }
        public override string ToString()
        {
            return $"Цвет:{color}\nЦена (Руб.):{price}\nФирма:{firm}\n";
        }
    }
}
