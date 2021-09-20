using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Motor goodMotor = new Motor();

            string Driving = myCar.Drive();

            string Properties = myCar.Properties();

            string Type = goodMotor.Type();

            int RPM = goodMotor.RPM();
            
            Console.WriteLine(Driving);
            
            Console.WriteLine(Properties);
            
            Console.WriteLine(Type);
            
            Console.WriteLine(RPM);
        }
    }
}