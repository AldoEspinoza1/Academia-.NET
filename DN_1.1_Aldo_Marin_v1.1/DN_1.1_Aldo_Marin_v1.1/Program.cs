using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioManager;
namespace DN_1._1_Jorge_DeLara_v1._1
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Console.Write("Vehicle sound");
            Console.WriteLine("Don't have sounds");
            Vehicle vehicle=new Vehicle();
            vehicle.VehicleSound();
            Console.ReadKey();

        }
    }
}
