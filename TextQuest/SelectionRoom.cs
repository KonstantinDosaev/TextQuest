﻿namespace TextQuest
{
    partial class SelectionRoom
    {
        private bool _flashLight;
        private bool _arms;

        public void SelectRoomTwo()
        { 
            var room = new Room
            {
                Head = "Вторая комната."
            };
            if (!_flashLight)
            {
                room.Head2 = " В этой комнате темно, у вас есть фонарик";
                string[] menu = { "1: Включить фонарик", "2: Уйти обратно в первую комнату" };
                room.GetText(menu);
                switch (room.CurrentArr)
                {
                    case 0:
                        _flashLight = true;
                        SelectRoomTwo();
                        break;
                    case 1:
                        SelectRoomOne();
                        break;
                }
            }
            else
            {
                room.Head2 =
                    " В свете фонаря вы увидели неизвестное животное и два выхода\n первый свободен там горит голубой свет,\n второй загораживает животное ";
                string[] menu =
                {
                    "1: Попробовать пройти через вход с животным",
                    "2: Пройти в свободный проход с голубым свечением",
                    "3: Уйти в первую комнату"
                };
                room.GetText(menu);
                switch (room.CurrentArr)
                {
                    case 0 when _arms == false:
                        HandleConsole("Животное рычит на вас и не пропускает");
                        SelectRoomTwo();
                        break;
                    case 0 when _arms:
                        HandleConsole("Животное испугалось трубы и пропустило вас");
                        SelectRoomFour();
                        break;
                    case 1:
                        SelectRoomThree();
                        break;
                    case 2:
                        SelectRoomOne();
                        break;
                }
            }

            Console.ReadLine();
        }

        public void SelectRoomThree()
        {
            var room = new Room
            {
                Head = "Третья комната",
                Head2 = " Вы в комнате с голубым свечением."
            };
            string[] menu = { "1: Уйти в комнату с животным", "2: Осмотреться" };
            room.GetText(menu);
            switch (room.CurrentArr)
            {
                case 0:
                    SelectRoomTwo();
                    break;
                case 1:
                    HandleConsole(" Вы нашли тяжелую трубу возможно животное испугается. ");
                    _arms = true;
                    SelectRoomThree();
                    break;
            }
            Console.ReadLine();
        }

        public void SelectRoomFour()
        {
            var roomFour = new Room
            {
                Head = "Четвертая комната",
                Head2 = " Вы вощли в кабтнет с кипами бумаг."
            };
            string[] menu = { "1: Уйти в комнату с животным", "2: Осмотреться" };
            roomFour.GetText(menu);
            switch (roomFour.CurrentArr)
            {
                case 0:
                    SelectRoomTwo();
                    break;
                case 1:
                    HandleConsole(" Вы нашли блокнот на котором записаны четыре цифры: 1973\n Похоже это код от двери. ");
                    SelectRoomFour();

                    break;
            }
            Console.ReadLine();
        }


        private void HandleConsole(string mesage)
        {
            Console.Clear();
            Console.Write(mesage);
            Console.ReadLine();
        }
        
    }
}

