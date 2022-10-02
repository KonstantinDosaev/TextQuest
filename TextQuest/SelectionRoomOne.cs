namespace TextQuest
{
    partial class SelectionRoom
    {
        public void SelectRoomOne()      
        {
            var roomOne = new Room
            {
                Head = "Первая комната",
                Head2 = " В этой комнате есть две двери: \n дверь со светящейся надписью ВЫХОД, \n и открытая дверь за которой темно."
            };
            string[] menu = { "1: Выбрать дверь с надписью ВЫХОД", "2: Выбрать вторую дверь", "3: Осмотреться" };
            roomOne.GetText(menu);

            switch (roomOne.CurrentArr)
            {
                case 0:
                    {
                        Console.Clear();
                        Console.Write(" Введите цифровой ключ: ");
                        int passExit;
                        while (!int.TryParse(Console.ReadLine(), out passExit)) ;
                        Console.Clear();
                        if (passExit == 1973)
                        { Console.WriteLine(" Поздравляю вы выбрались из лаборатории!!!!"); }
                        else
                        {
                            Console.WriteLine(" КЛЮЧ НЕ ВЕРЕН");
                            Console.ReadLine();
                            SelectRoomOne();
                        }

                        break;
                    }

                case 1:
                    SelectRoomTwo();
                    break;
                case 2:
                    Console.WriteLine("\tВ этой комнате нет ничего полезного");
                    Console.ReadLine();
                    SelectRoomOne();
                    break;
            }

            Console.ReadLine();
        }
    }
}

