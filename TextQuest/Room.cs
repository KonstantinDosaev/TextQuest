using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TextQuest
{
    internal class Room
    {
        public string head;
        public string head_2;
        public string masage_1;
        public string masage_2;
        public string masage_3;

        public void GetText()
        {
            Console.Clear();
            Console.WriteLine($"\t\t\t{head}\n\n");
            Console.WriteLine($"{head_2}\n\n");
            if (masage_1 != null) Console.WriteLine(masage_1);
            if (masage_2 != null) Console.WriteLine(masage_2);
            if (masage_3 != null) Console.WriteLine(masage_3);
            Console.WriteLine("\n\n");


        }
    }
}
