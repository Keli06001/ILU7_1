using System;
using System.Collections.Generic;
using System.Xml;

namespace ILU7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();

            Console.WriteLine("Skriv in så många namn som du vill, när du känner dig klar så skickar du en tom rad");
            string namn = " ";
            while (namn!="") 
            {
                namn = Console.ReadLine();
                
                if (namn!="")
                {
                    list.Add(namn);
                }
            }
            Console.WriteLine("Här är namnen sorterade alfabetiskt fast baklänges");
            list.Sort();
            list.Reverse();
            foreach (String s in list) 
            {
                Console.WriteLine(s);

            }

        }
    }
}