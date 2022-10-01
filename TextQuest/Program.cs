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
            roomOne.masage_1 = " 1: Выбрать дверь с надписью ВЫХОД";
            roomOne.masage_2 = " 2: Выбрать вторую дверь";
            roomOne.masage_3 = " 3: Осмотреться";
            roomOne.GetText(3);

            
            switch (roomOne.curentArr)
            {
                case 1:
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

                case 2:
                    RoomTwo();
                    break;
                case 3:
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
                roomTwo.masage_1 = " 1: Включить фонарик";
                roomTwo.masage_2 = " 2: Уйти обратно в первую комнату";
                roomTwo.GetText(2);
                //int operNum = OperNum(2);
                switch (roomTwo.curentArr)
                {
                    case 1:
                        flashLight = true;
                        RoomTwo();
                        break;
                    case 2:
                        RoomOne();
                        break;
                }
            }
            else if(flashLight == true && animal == true)
            {
                roomTwo.head_2 = " В свете фонаря вы увидели неизвестное животное и два выхода\n первый свободен там горит голубой свет,\n второй загораживает животное ";
                roomTwo.masage_1 = " 1: Попробовать пройти через вход с животным";
                roomTwo.masage_2 = " 2: Пройти в свободный проход с голубым свечением";
                roomTwo.masage_3 = " 3: Уйти в первую комнату";
                roomTwo.GetText(3);
                //int operNum = OperNum(3);
                if (roomTwo.curentArr == 1 && arms == false)
                {
                    Console.Clear();
                    Console.WriteLine("Животное рычит на вас и не пропускает");
                    Console.ReadLine();
                    RoomTwo();
                }
                else if (roomTwo.curentArr == 1 && arms == true)
                {
                    Console.Clear();
                    Console.WriteLine("Животное испугалось трубы и пропустило вас");
                    Console.ReadLine();
                    RoomFour();
                }
                else if (roomTwo.curentArr == 2) RoomThre();
                else if (roomTwo.curentArr == 3) RoomOne();


            }
            else if (flashLight == true && animal == false)
            {
                roomTwo.head_2 = " Вы в комнате с животным, но у вас есть труба и оно боится\n  ";
                roomTwo.masage_1 = " 1: Пройти через вход с животным";
                roomTwo.masage_2 = " 2: Пройти в проход с голубым свечением";
                roomTwo.masage_3 = " 2: Уйти в первую комнату";
                roomTwo.GetText(3);
                //int operNum = OperNum(3);
                switch (roomTwo.curentArr)
                {
                    case 1:
                        RoomFour();
                        break;
                    case 2:
                        RoomThre();
                        break;
                    case 3:
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
            roomThre.masage_1 = " 1: Уйти в комнату с животным";
            roomThre.masage_2 = " 2: Осмотреться";
            roomThre.GetText(3);

            //int operNum = OperNum(2);
            switch (roomThre.curentArr)
            {
                case 1:
                    RoomTwo();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write(" Вы нашли тяжелую трубу возможно животное испугается. ");
                    arms = true;
                    Console.ReadLine();
                    RoomFour();
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
            roomFour.masage_1 = " 1: Уйти в комнату с животным";
            roomFour.masage_2 = " 2: Осмотреться";
            roomFour.GetText(2);

            //int operNum = OperNum(2);
            switch (roomFour.curentArr)
            {
                case 1:
                    RoomTwo();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write(" Вы нашли блокнот на котором записаны четыре цифры: 1973\n Похоже это код от двери. ");
                    Console.ReadLine();
                    RoomFour();

                    break;
            }
            Console.ReadLine();
        }




        static int OperNum(int quantityMasage)
        {
            int operNum;
            while (!int.TryParse(Console.ReadLine(), out operNum)) ;
            while (operNum > quantityMasage)
            {
                Console.WriteLine("выбирайте из списка");
                while (!int.TryParse(Console.ReadLine(), out operNum)) ;
                
            }
            return operNum;
        }
    }
}

