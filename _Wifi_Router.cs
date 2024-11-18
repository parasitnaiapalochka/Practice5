using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyForm
{
    public class _Wifi_Router : _NetworkEquip
    {
        //поля
        private string VPN_func; // функция VPN
        private int speed; // скорость передачи
        //свойства
        public string VPN_Func
        {
            get
            {
                return VPN_func;
            }
            set
            {
                if (value == null) VPN_func = "No name";
                else VPN_func = value;
            }
        }
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value < 0 || value > 100000) speed = 0;
                else speed = value;
            }
        }
        //конструктор
        public _Wifi_Router(string color = "", int price = 0, string firm = "",int speed = 0, string VPN_func = "") : base(color, price,firm)
        {
            VPN_Func = VPN_func;
            Speed = speed;
        }
        //Метод print
        public override void Print_Info()
        {
            Console.WriteLine("Информация о Wi-fi роутере:");
            base.Print_Info();
            Console.WriteLine($"Функция VPN: {VPN_func}");
            Console.WriteLine($"Скорость передачи(Мбит/С): {speed}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}Функция VPN:{VPN_func}\nСкорость передачи(Мбит/С):{speed}\n";
        }
    }
}