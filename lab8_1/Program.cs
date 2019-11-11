using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_1
{
   
    class Car 
    {
        

        protected int price, maxspeed, year,power;

        // свойство Стоимость
        public int Price
        {
            get { return price; }
            set
            {
                if (value > 0) price = value;
                else
                {
                    Console.WriteLine("Вы ввели неверную цену!");

                }
            }
        }

        // свойство Максимальная скорость
        public int Maxspeed
        {
            get { return maxspeed; }
            set
            {
                if (value > 0) maxspeed = value;
                else
                {
                    Console.WriteLine("Вы ввели неверную скорость!");
                }
            }
        }

        // свойство Год выпуска
        public int Year
        {
            get { return year; }
            set
            {
                if (value <= DateTime.Today.Year && value>=1885) year = value;
                else
                {
                    Console.WriteLine("Вы ввели неверный год! Год должен быть указан от 1885 до 2019!");
                }
            }
        }

        public int Power
        {
            get { return power; }
            set
            {
                if (value > 0) power = value;
                else
                {
                    Console.WriteLine("Вы ввели неверную мощьность!");
                }
            }
        }


       
       
        

        //конструктор 
        public Car(int price, int maxspeed, int year, int power)
        {
            this.Price = price;
            this.Maxspeed = maxspeed;
            this.Year = year;
            this.Power = power;
        }
    }


    class Garrage
    {
        public List<Car> cars = new List<Car>();
        public void AddCar()
        {
            int prise = 0, maxspeed = 0, year = 0, Power = 0;
            Console.WriteLine("Введите цену:");
            try
            {
                prise = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите максимальную скорость");
            try
            {
                maxspeed = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите год:");
            try
            {
                year = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            Console.WriteLine("Введите мощьность:");
            try
            {
                Power = Convert.ToInt32(Console.ReadLine());
            }
            catch { }
            cars.Add(new Car(prise, maxspeed, year, Power));
        }

        public void GetAllCar()
        {
            int i = 1;
            foreach (Car car in cars)
            {
                Console.WriteLine($"[{i}] - Цена: {car.Price}, Максимальная скорость: {car.Maxspeed}, Год: {car.Year}, Мощьность: {car.Power}");
                i++;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберете действие:");
            Console.WriteLine("1 - добавить машину");
            Console.WriteLine("2 - удалить машину");
            Console.WriteLine("3 - посмотреть гараж");
            Console.WriteLine("4 - Выход");
            string answer;
            bool exit = false;
            Garrage garrage = new Garrage();
            int n = 0,k=0;
            do
            {
                Console.Write("Действие - ");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                    {
                        garrage.AddCar();
                        break;
                    }
                    case "2":
                    {
                        n = garrage.cars.Count;
                        if (n > 0)
                        {
                            Console.WriteLine("Введите номер машины которую хотите удалить (k):");
                            do
                            {
                                Console.Write("k = ");
                                k = Convert.ToInt32(Console.ReadLine());
                                if (k <= 0)
                                    Console.WriteLine("Вы ввели значение <=0!");
                                if (k > n)
                                    Console.WriteLine($"k должно быть не больше {k}!");
                            } while (k <= 0 || k > n);

                            k--;
                            garrage.cars.RemoveAt(k);
                        }
                        else
                        {
                            Console.WriteLine("В гараже пусто!");
                        }

                        break;
                    }
                    case "3":
                    {
                        n = garrage.cars.Count;
                        if(n>0)
                            garrage.GetAllCar();
                        else
                        {
                            Console.WriteLine("В гараже пусто!");
                        }
                        break;
                    }
                    case "4":
                    {
                        exit = true;
                        break;
                    }
                    default:
                        Console.WriteLine("Вы нажали не верную клавишу!");
                        break;
                        answer = Console.ReadLine();
                } 
            } while (exit == false);
        }
    }
}
