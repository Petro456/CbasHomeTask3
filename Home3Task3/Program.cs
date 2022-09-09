using System;
using System.Numerics;



namespace Home3Task3
{
    
  internal  class Vehicle
    {
        double koordynataX;
        double koordynataY;
       
        double cena, svydkist, rikVypusky;

        public double KoordynataX

        {
            get { return koordynataX; }
            set { koordynataX = value;}
        }

        public double KoordynataY
        {
            get { return koordynataY; }
            set { koordynataY = value;}
        }
        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public double Csvydkist
        {
            get { return svydkist; }
            set { svydkist = value; }
        }
        public double RkVypusky
        {
            get { return rikVypusky;}
            set { rikVypusky = value;}
        }
        public void Koordynatu (double KoordynataX, double KoordynataY)
        {
            this.koordynataX=KoordynataX;
            this.koordynataY=KoordynataY;
        }

        public Vehicle (double Csvydkist)
        {
            this.svydkist = Csvydkist;
        }             

    }

    class Plane : Vehicle
    {
        public double Vysota { get; set; }
        public double Passengers { get; set; }
        public Plane(double Csvydkist)
                     : base(Csvydkist)
        {
            Vysota = 5000;
            Passengers = 2000;
        }
    }
    class Auto : Vehicle
    {
        public double Probih { get; set; }
        public Auto (double svydkist)
                    : base(svydkist)
        {
            Probih = 10000;
        }

    }

    class Ship : Vehicle
    {
        public double Passengers { get; set; }
        public string Port { get; set; }
        public Ship(double svydkist)
                    : base(svydkist)
        {
            Passengers = 10000;
            Port = "Порт № 1";
        }
    }


    internal class Program
    {
        /*Задание 3 

        Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: Создать класс Vehicle. 
        В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). 
        Создайте 3 производных класса Plane, Саг и Ship. Для класса Plane должна быть определена высота и количество пассажиров. 
        Для класса Ship — количество пассажиров и порт приписки. Написать программу, которая выводит на экран информацию о каждом
        средстве передвижения. */




        static void Main(string[] args)
        {
            
            //Plane plane = new Plane(300);

            var plane = new Plane (3005) { RkVypusky = 2001, Cena = 500000, Vysota = 2000,  Passengers = 10, Csvydkist = 400 };
            
            Console.WriteLine(new String('/', 80));
            Console.WriteLine("Лiтак");
            Console.WriteLine("Характеристики лiтака");
            Console.WriteLine("Рiк випуску: {0}", plane.RkVypusky.ToString());
            Console.WriteLine("Вартiсть лiтака {0}:", plane.Cena.ToString());
            Console.WriteLine("Висота польоту {0}:", plane.Vysota.ToString());
            Console.WriteLine("Кiлькiсть пасажиров {0}:", plane.Passengers.ToString());
            Console.WriteLine("Швидкiсть {0}:", plane.Csvydkist.ToString());
            


            //Ship ship = new Ship(20);
            var ship = new Ship(20) { Cena = 10000000, RkVypusky = 2006, Csvydkist =105, Port = "Порт Одесса"};
            Console.WriteLine(new String('/', 80));
            Console.WriteLine("Корабель Мрiя");
            Console.WriteLine("Характеристики корабля");
            Console.WriteLine("Координати корабля X:{0},Y: {1}", ship.KoordynataX.ToString(), ship.KoordynataY.ToString());
            Console.WriteLine("Рiк випуску: {0}", ship.RkVypusky.ToString());
            Console.WriteLine("Вартiсть корабля {0}:", ship.Cena.ToString());
            Console.WriteLine("Швидкiсть {0}:", ship.Csvydkist.ToString());
            Console.WriteLine("Порт прибуття {0}:", ship.Port.ToString());


            var car = new Auto (3005) { RkVypusky = 2022, Cena = 510000, Csvydkist = 250, };

            Console.WriteLine(new String('/', 80));
            Console.WriteLine("Авто ферарi");
            Console.WriteLine("Характеристики авта");
            Console.WriteLine("Рiк випуску: {0}", car.RkVypusky.ToString());
            Console.WriteLine("Вартiсть авта {0}:", car.Cena.ToString());
            Console.WriteLine("Швидкiсть {0}:", car.Csvydkist.ToString());
           



            //Console.WriteLine("****Машина****");
            //Console.WriteLine("Характеристики Машина");
            //var car = new Car(60) { Price = 50000,/*цена*/ Year = 1996, /*год производства*/ Speed = 250 /*скорость*/};
            //car.Coordinate(40000, 30000);
            //Console.WriteLine("Стоимость машины {0}:", car.Price.ToString());
            //Console.WriteLine("Координаты машины X:{0},Y: {1}", car.CoordinateX.ToString(), car.CoordinateY.ToString());
            //Console.WriteLine("Год выпуска: {0}", car.Year.ToString());
            //Console.WriteLine("Стоимость машины {0}:", car.Price.ToString());
            //Console.WriteLine("Скорость {0}:", car.Speed.ToString());

            Console.ReadKey();
        }
    }
}
