using System;
using System.Collections.Generic;

namespace Homework_15_Delegate
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Haqverdi");
            names.Add("Akif");
            names.Add("Akif");
            names.Add("Akif");
            names.Add("Akif");

            CheckWords(m => m == "Akif", names);
           
        }

        public static void CheckWords(Predicate<string> func, List<string>words)
        {
            var result = words.FindAll(func);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
                        
        }

        
       
    }
}
