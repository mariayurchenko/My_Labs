using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11_1_4
{
    class AmusementPark
    {
        public void SetVisitor(Visitor obj)
        {
            visitor = obj;
        }
        private Visitor visitor;

        public AmusementPark()
        {
            this.visitor= new Visitor();
        }
        public void RodeTheAmericanRollerCoaster()
        {
            Console.WriteLine($"Покататься на амереканських горках - {visitor.rode_the_American_roller_coaster}");
        }
        public void ShotInTheDash()
        {
            Console.WriteLine($"Пострелять в тире - {visitor.shot_in_the_dash}");
        }
        public void WentDownToTheRoomOfFear()
        {
            Console.WriteLine($"Сходить в комнату страха - {visitor.went_down_to_the_room_of_fear}");
        }
        public void WentIntoTheRoomOfCurvedMirrors()
        {
            Console.WriteLine($"Сходить в комнату кривых зеркал - {visitor.went_into_the_room_of_curved_mirrors}");
        }
        public void AtePopcorn()
        {
            Console.WriteLine($"Съесть попкорна - {visitor.ate_popcorn}");
        }
        public void RideTheWheel()
        {
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
        delegate void MyDelegate();

        static void Main(string[] args)
        {
            Visitor Mari = new Visitor();
            Mari.shot_in_the_dash = true;
            Mari.ate_popcorn = true;
            AmusementPark vis1 = new AmusementPark();
            vis1.SetVisitor(Mari);
            Console.WriteLine("Mari:");
            vis1.RodeTheAmericanRollerCoaster();
            vis1.ShotInTheDash();
            vis1.WentDownToTheRoomOfFear();
            vis1.WentIntoTheRoomOfCurvedMirrors();
            vis1.AtePopcorn();
            vis1.RideTheWheel();
            Visitor Alex = new Visitor();
            Alex.rode_the_American_roller_coaster = true;
            Alex.went_down_to_the_room_of_fear = true;
            Alex.went_into_the_room_of_curved_mirrors = true;
            Alex.ride_the_wheel = true;
            AmusementPark vis2 = new AmusementPark();
            vis2.SetVisitor(Alex);
            Console.WriteLine("Alex:");
            vis2.RodeTheAmericanRollerCoaster();
            vis2.ShotInTheDash();
            vis2.WentDownToTheRoomOfFear();
            vis2.WentIntoTheRoomOfCurvedMirrors();
            vis2.AtePopcorn();
            vis2.RideTheWheel();


            Console.ReadKey();

        }
    }
}
