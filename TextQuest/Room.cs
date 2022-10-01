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
        public int curentArr = 0;


        public void GetText(string[] menu )
        {
             

            while (true)
            {
                char arr = '>';

                Console.Clear();
                Console.WriteLine($"\t\t\t{head}\n\n");
                Console.WriteLine($"{head_2}\n\n");
                for (int i = 0; i < menu.Length ; i++)
                {
                    if (curentArr == i) Console.WriteLine($" {arr} {menu[i]}");
                    else Console.WriteLine($"   {menu[i]}");
                }
                Console.WriteLine("\n\n");
                ConsoleKeyInfo keyPushed = Console.ReadKey();
                if (keyPushed.Key == ConsoleKey.DownArrow )
                {
                    if(curentArr < menu.Length)  curentArr++;
                    else curentArr = 0;
                }
                
                if (keyPushed.Key == ConsoleKey.UpArrow)
                {
                    if (curentArr > 0) curentArr--;
                    else curentArr = menu.Length;

                }
                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    return ;
                }
            }



        }

    }
}
