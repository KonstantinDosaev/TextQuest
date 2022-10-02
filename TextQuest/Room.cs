namespace TextQuest;

internal class Room
{
    public string Head;
    public string Head2;
    public int CurrentArr;


    public void GetText(string[] menu)
    {


        while (true)
        {
            var arr = '>';

            Console.Clear();
            Console.WriteLine($"\t\t\t{Head}\n\n");
            Console.WriteLine($"{Head2}\n\n");
            for (var i = 0; i < menu.Length; i++)
            {
                Console.WriteLine(CurrentArr == i 
                    ? $" {arr} {menu[i]}" 
                    : $"   {menu[i]}");
            }
            Console.WriteLine("\n\n");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.DownArrow when CurrentArr < menu.Length-1:
                    CurrentArr++;
                    break;
                case ConsoleKey.DownArrow:
                    CurrentArr = 0;
                    break;
                case ConsoleKey.UpArrow when CurrentArr > 0:
                    CurrentArr--;
                    break;
                case ConsoleKey.UpArrow:
                    CurrentArr = menu.Length-1;
                    break;
                case ConsoleKey.Enter:
                    return;
            }
        }

    }

}