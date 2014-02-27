namespace LuboTheHero
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class Castle
    {
        public const int NUMBER_OF_ROOMS_IN_LEVEL = 4;
        public const int ROOM_HEIGHT = 24;
        public const int ROOM_WIDTH = 117;
        public const int WALL_WIDTH = 1;

        private readonly List<char[,]> rooms;
        private int currentRoomIndex;
        private string level;

        public Castle(string level)
        {
            this.Level = level;
            this.rooms = new List<char[,]>();
            this.LoadLevelRooms(this.Level);
        }

        public int CurrentRoomIndex
        {
            get
            {
                return this.currentRoomIndex;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Room index must be positive number");
                }
                this.currentRoomIndex = value;
            }
        }

        public string Level
        {
            get
            {
                return this.level;
            }
            set
            {
                switch (value)
                {
                    case "First":
                    case "Second":
                        level = value;
                        break;
                    default:
                        throw new ArgumentException("Invalid level");
                }
            }
        }

        private void LoadLevelRooms(string level)
        {
            for (int roomNumber = 1; roomNumber <= NUMBER_OF_ROOMS_IN_LEVEL; roomNumber++)
            {
                string txtFileName = level + "LevelRoom" + roomNumber + ".txt";
                this.LoadSingleRoom(@"..\..\textfiles\" + txtFileName);
            }
        }

        private void LoadSingleRoom(string roomPath)
        {
            StreamReader reader = new StreamReader(roomPath);

            char[,] roomMatrix = new char[ROOM_HEIGHT, ROOM_WIDTH];
            int currentMatrixRow = 0;

            using (reader)
            {
                string currentTextFileLine;

                while ((currentTextFileLine = reader.ReadLine()) != null)
                {
                    string[] strArr = currentTextFileLine.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int index = 0; index < strArr.Length; index++)
                    {
                        int code;
                        if (int.TryParse(strArr[index], out code))
                        {
                            roomMatrix[currentMatrixRow, index] = Convert.ToChar((char.ConvertFromUtf32(code)));
                        }
                        else
                        {
                            roomMatrix[currentMatrixRow, index] = Convert.ToChar(strArr[index]);
                        }
                    }

                    currentMatrixRow++;
                }

                rooms.Add(roomMatrix);
            }
        }

        public char[,] GetCurrentRoom()
        {
            return this.rooms[currentRoomIndex];
        }

        public void ChangeCurrentRoom(int deltaIndex)
        {
            if (deltaIndex != 1 && deltaIndex != -1)
            {
                throw new ArgumentOutOfRangeException("The current room index can change with only plus or minus one");
            }

            CurrentRoomIndex += deltaIndex;
        }
    }
}
