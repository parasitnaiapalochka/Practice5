using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForm
{
    public class _Switcher : _NetworkEquip
    {
        //поля
        private int num_ports; // число портов
        private string placement; // размещение
        //свойства
        public string Placement
        {
            get
            {
                return placement;
            }
            set
            {
                if (value == null) placement = "";
                else placement = value;
            }
        }
        public int Num_ports
        {
            get { return num_ports; }
            set
            {
                if (value < 0 || value > 9) num_ports = 0;
                else num_ports = value;
            }
        }
        //конструктор
        public _Switcher(string color = "", int price = 0,string firm = "", int num_ports = 0, string placement = "") : base(color, price,firm)
        {
            Placement = placement;
            Num_ports = num_ports;
        }
        //метод print
        public override void Print_Info()
        {
            Console.WriteLine("Информация о коммутаторе:");
            base.Print_Info();
            Console.WriteLine($"Размещение: {placement}");
            Console.WriteLine($"Количество портов(от 0 до 8): {num_ports}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}Размещение:{placement}\nКоличество портов(от 0 до 8):{num_ports}\n";
        }
    }
}
