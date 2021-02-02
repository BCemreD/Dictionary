using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employeId = new Dictionary<int, string>();
            employeId.Add(155, "Canan");
            employeId.Add(187, "Bülent");
            employeId.Add(166, "Ayşe");
            employeId.Add(145, "Mesut");

            if (employeId.ContainsKey(187))
            {
                string value = employeId[187];
                Console.WriteLine("Aradığınız Çalışan" + " " + value);
            }
            Console.ReadLine();

        }

    }
}
