using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{

    public class OutLander : RaceCar
    {
        public OutLander()
        {
            Name = "OutLander";
            TopSpeed = 90;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} roars to life!!");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} squeals to a stop!");
            base.Brake();
        }
    }
}