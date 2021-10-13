using System;

namespace Inheritance
{
    public class School
    {
        private string WorkSchedule;

        private int Pay;

        public int pay
        {
            set { Pay = value;}
            
            get { return Pay; }
        }

        public string workschedule
        {
            set { WorkSchedule = value; }

            get { return WorkSchedule; }
        }

        public virtual void SchoolSays()
        {
            Console.WriteLine("Everyone is happy in school!");
        }
    }

    public class Student : School
    {
        public override void SchoolSays()
        {
            Console.WriteLine("Most of us hate school!");
        }

        public void student()
        {
            pay = 120;
            workschedule = "8:30-16:00";
            
            Console.WriteLine("Students get a pay of " + pay + " USD per month! They have school between " + workschedule + "!");
        }
    }

    public class Teacher : School
    {
        public override void SchoolSays()
        {
            Console.WriteLine("We hate the students!");
        }

        public void teacher()
        {
            pay = 3000;
            workschedule = "7:00-17:00";
            
            Console.WriteLine("Teachers get a pay of " + pay + " USD per month! They work between " + workschedule + "!");
        }
    }
}