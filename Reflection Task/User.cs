using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Task
{
   public class User
    {
        private int id;
        private string name;
        private string surname;
        private static int age;

        public void GetFullName()
        {
            Console.WriteLine(name + " " + surname);
        }
        public static void ChangeAge(int Age)
        {
            age = Age;
        }
        public static void NewAge()
        {
            Console.WriteLine($" age = {age}");
        }
    }
}
