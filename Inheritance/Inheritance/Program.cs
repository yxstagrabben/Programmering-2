using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            School mySchool = new School();
            Student myStudent = new Student();
            Teacher myTeacher = new Teacher();
            
            mySchool.SchoolSays();

            myStudent.SchoolSays();
            
            myTeacher.SchoolSays();
            
            myStudent.student();
            
            myTeacher.teacher();
        }
    }
}