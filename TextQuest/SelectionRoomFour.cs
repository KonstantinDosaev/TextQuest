namespace TextQuest
{
    partial class SelectionRoom
    {
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

    }
}

