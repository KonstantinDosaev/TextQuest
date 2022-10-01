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
        public int curentArr = 1;


        public void GetText(int quantMas )
        {


            while (true)
            {
                char arr1 = ' '; char arr2 = ' '; char arr3 = ' ';
                switch (curentArr)
                {
                    case 1: arr1 = '>'; break;
                    case 2: arr2 = '>'; break;
                    case 3: arr3 = '>'; break;
                }
                Console.Clear();
                Console.WriteLine($"\t\t\t{head}\n\n");
                Console.WriteLine($"{head_2}\n\n");
                if (masage_1 != null) Console.WriteLine($" {arr1} {masage_1}");
                if (masage_2 != null) Console.WriteLine($" {arr2} {masage_2}");
                if (masage_3 != null) Console.WriteLine($" {arr3} {masage_3}");
                Console.WriteLine("\n\n");
                //Console.ReadKey();
                ConsoleKeyInfo keyPushed = Console.ReadKey();
                if (keyPushed.Key == ConsoleKey.DownArrow )
                {
                    if(curentArr < quantMas)  curentArr++;
                    else curentArr = 1;
                }
                
                if (keyPushed.Key == ConsoleKey.UpArrow)
                {
                    if (curentArr > 1) curentArr--;
                    else curentArr = 3;

                }
                if (keyPushed.Key == ConsoleKey.Enter)
                {
                    return ;
                }
                

            }



        }
       /* public void AddVariant(string variant)
        {
            char arr = ' ';

            
            Console.WriteLine($" {arr} {variant}");
        }*/

    }
}
