namespace TextQuest
{
class Program
    {
        static bool flashLight = false;
        static bool animal = true;
        static bool arms = false;

        static void Main(string[] args)
        {
            Intro();
            RoomOne();
        }
        static void Intro()
        {
            Console.WriteLine("\t\t\tText quest\n==========================================\n\n");
            Console.WriteLine("Вы очнулись в лаборатории, видите дверь с надписью выход но она закрыта,\nдля того чтобы покинуть лабораторию, вам нужно найти код от цифрового замка.\n");
            Console.WriteLine("Press Enter");
            Console.ReadLine();
            
        }
        //111111111111111111111111111111111111111111111111111111111111111
        static void RoomOne()      
        {
            Room roomOne = new Room();
            roomOne.head = "Первая комната";
            roomOne.head_2 = " В этой комнате есть две двери: \n дверь со светящейся надписью ВЫХОД, \n и открытая дверь за которой темно.";
            string[] menu = { "1: Выбрать дверь с надписью ВЫХОД", "2: Выбрать вторую дверь", "3: Осмотреться" };
            roomOne.GetText(menu);

            switch (roomOne.curentArr)
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
                            RoomOne();
                        }

                        break;
                    }

                case 1:
                    RoomTwo();
                    break;
                case 2:
                    Console.WriteLine("\tВ этой комнате нет ничего полезного");
                    Console.ReadLine();
                    RoomOne();
                    break;
            }

            Console.ReadLine();
        }

        
        //222222222222222222222222222222222222222222222222222222222222222222
        static void RoomTwo()
        {   Room roomTwo = new Room();
            roomTwo.head = "Вторая комната.";
            if (flashLight == false)
            { 
                roomTwo.head_2 = " В этой комнате темно, у вас есть фонарик";
                string[] menu = { "1: Включить фонарик", "2: Уйти обратно в первую комнату" };
                roomTwo.GetText(menu);
                switch (roomTwo.curentArr)
                {
                    case 0:
                        flashLight = true;
                        RoomTwo();
                        break;
                    case 1:
                        RoomOne();
                        break;
                }
            }
            else if(flashLight == true && animal == true)
            {
                roomTwo.head_2 = " В свете фонаря вы увидели неизвестное животное и два выхода\n первый свободен там горит голубой свет,\n второй загораживает животное ";
                string[] menu = { "1: Попробовать пройти через вход с животным",
                                "2: Пройти в свободный проход с голубым свечением", 
                                "3: Уйти в первую комнату" };
                roomTwo.GetText(menu);
                if (roomTwo.curentArr == 0 && arms == false)
                {
                    Console.Clear();
                    Console.WriteLine("Животное рычит на вас и не пропускает");
                    Console.ReadLine();
                    RoomTwo();
                }
                else if (roomTwo.curentArr == 0 && arms == true)
                {
                    Console.Clear();
                    Console.WriteLine("Животное испугалось трубы и пропустило вас");
                    Console.ReadLine();
                    RoomFour();
                }
                else if (roomTwo.curentArr == 1) RoomThre();
                else if (roomTwo.curentArr == 2) RoomOne();


            }
            else if (flashLight == true && animal == false)
            {
                roomTwo.head_2 = " Вы в комнате с животным, но у вас есть труба и оно боится\n  ";
                string[] menu = { "1: Пройти через вход с животным", "2: Пройти в проход с голубым свечением", "2: Уйти в первую комнату" };
                roomTwo.GetText(menu);
                switch (roomTwo.curentArr)
                {
                    case 0:
                        RoomFour();
                        break;
                    case 1:
                        RoomThre();
                        break;
                    case 2:
                        RoomOne();
                        break;
                }

            }


            Console.ReadLine();
        }
        //3333333333333333333333333333333333333333333333
        static void RoomThre()
        {
            Room roomThre = new Room();
            roomThre.head = "Третья комната";
            roomThre.head_2 = " Вы в комнате с голубым свечением.";
            string[] menu = { "1: Уйти в комнату с животным", "2: Осмотреться" };
            roomThre.GetText(menu);
            switch (roomThre.curentArr)
            {
                case 0:
                    RoomTwo();
                    break;
                case 1:
                    Console.Clear();
                    Console.Write(" Вы нашли тяжелую трубу возможно животное испугается. ");
                    arms = true;
                    Console.ReadLine();
                    RoomThre();
                    break;
            }
            Console.ReadLine();
        }
        //44444444444444444444444444444444444444444444444444
        static void RoomFour()
        {
            Room roomFour = new Room();
            roomFour.head = "Четвертая комната";
            roomFour.head_2 = " Вы вощли в кабтнет с кипами бумаг.";
            string[] menu = { "1: Уйти в комнату с животным", "2: Осмотреться" };
            roomFour.GetText(menu);
            switch (roomFour.curentArr)
            {
                case 0:
                    RoomTwo();
                    break;
                case 1:
                    Console.Clear();
                    Console.Write(" Вы нашли блокнот на котором записаны четыре цифры: 1973\n Похоже это код от двери. ");
                    Console.ReadLine();
                    RoomFour();

                    break;
            }
            Console.ReadLine();
        }



    }
}

