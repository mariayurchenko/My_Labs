using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab11_1_4
{
    class AmusementPark
    {

      
        
        public static void RodeTheAmericanRollerCoaster(Visitor a)
        {
            
            a.rode_the_American_roller_coaster = true;
        }
        public static void ShotInTheDash(Visitor a)
        {
            a.shot_in_the_dash = true;
        }
        public static void WentDownToTheRoomOfFear(Visitor a)
        {
            a.went_down_to_the_room_of_fear = true;
        }
        public static void WentIntoTheRoomOfCurvedMirrors(Visitor a)
        {
            a.went_into_the_room_of_curved_mirrors = true;
        }
        public static void AtePopcorn(Visitor a)
        {
            a.ate_popcorn = true;
        }
        public static void RideTheWheel(Visitor a)
        {
            a.ride_the_wheel = true;
        }

        public static void Show(Visitor visitor)
        {
            Console.WriteLine($"Покататься на амереканських горках - {visitor.rode_the_American_roller_coaster}");
            Console.WriteLine($"Пострелять в тире - {visitor.shot_in_the_dash}");
            Console.WriteLine($"Сходить в комнату страха - {visitor.went_down_to_the_room_of_fear}");
            Console.WriteLine($"Сходить в комнату кривых зеркал - {visitor.went_into_the_room_of_curved_mirrors}");
            Console.WriteLine($"Съесть попкорна - {visitor.ate_popcorn}");
            Console.WriteLine($"Покататься на чертовом колесе - {visitor.ride_the_wheel}");
        }
    }
    class Visitor
    {
        public bool rode_the_American_roller_coaster;
        public bool shot_in_the_dash;
        public bool went_down_to_the_room_of_fear;
        public bool went_into_the_room_of_curved_mirrors;
        public bool ate_popcorn;
        public bool ride_the_wheel;
    }

    class Program
    {
        delegate void MyDelegate(Visitor v);

        static void Main(string[] args)
        {
            Visitor vis1 = new Visitor();
            MyDelegate Mary = null;
            MyDelegate Mary1 = new MyDelegate(AmusementPark.AtePopcorn);
            MyDelegate Mary2 = new MyDelegate(AmusementPark.RideTheWheel);
            MyDelegate Mary3 = new MyDelegate(AmusementPark.Show);
            Mary = Mary1 + Mary2 + Mary3;
            Console.WriteLine("Mary:");
            Mary(vis1);
            Visitor vis2 = new Visitor();
            MyDelegate Alex = null;
            MyDelegate Alex1 = new MyDelegate(AmusementPark.WentDownToTheRoomOfFear);
            MyDelegate Alex2 = new MyDelegate(AmusementPark.ShotInTheDash);
            MyDelegate Alex3 = new MyDelegate(AmusementPark.Show);
            Alex = Alex1 + Alex2 + Alex3;
            Console.WriteLine("Alex:");
            Alex(vis2);

            Console.ReadKey();

        }
    }
}
