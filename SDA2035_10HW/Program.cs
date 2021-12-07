using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_10HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение градусов угла:");
            int AngleGradus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение минут угла:");
            int AngleMinutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение секунд угла:");
            int AngleSeconds = Convert.ToInt32(Console.ReadLine());

            MyAngle angle = new MyAngle(AngleSeconds, AngleMinutes, AngleGradus);
            Console.WriteLine("Указанный вами угол составляет в радианах: {0:F4}", angle.ToRadians());

            Console.ReadKey();
        }
    }

    class MyAngle
    {
        int gradus;
        int min;
        int sec;

        public int Gradus
        {
            set
            {
                if ((value <= 360) && (value >= 0))
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Указано неверное значение градусов - Должно быть не отрицательным и не превышать 360");
                    Console.WriteLine("# Установлено значение по умолчанию: 0");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {
                if ((value < 60) && (value >= 0))
                {
                    min = value;
                }
                else
                {
                    Console.WriteLine("Указано неверное значение минут - Должно быть не отрицательным и не превышать 60");
                    Console.WriteLine("# Установлено значение по умолчанию: 0");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {
                if ((value < 60) && (value >= 0))
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Указано неверное значение секунд - Должно быть не отрицательным и не превышать 60");
                    Console.WriteLine("# Установлено значение по умолчанию: 0");
                }
            }
            get
            {
                return sec;
            }
        }

        public MyAngle(int sec, int min, int gradus)
        {
            Sec = sec;
            Min = min;
            Gradus = gradus;
        }
        public double ToRadians()
        {
            return Gradus * (Math.PI / 180) +
                     Min * (Math.PI / (180 * 60)) +
                      Sec * (Math.PI / (180 * 60 * 60));
        }

    }
}
