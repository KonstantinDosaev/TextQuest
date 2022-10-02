namespace TextQuest
{
    partial class SelectionRoom
    {
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

    }
}

