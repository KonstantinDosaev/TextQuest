namespace TextQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Intro();
            try
            {
                var selectRoom = new SelectionRoom();
                selectRoom.SelectRoomOne();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Intro()
        {
            Console.WriteLine("\t\t\tText quest\n==========================================\n\n");
            Console.WriteLine("Вы очнулись в лаборатории, видите дверь с надписью выход но она закрыта,\nдля того чтобы покинуть лабораторию, вам нужно найти код от цифрового замка.\n");
            Console.WriteLine("Press Enter");
            Console.ReadLine();
        }
        
    }
}

