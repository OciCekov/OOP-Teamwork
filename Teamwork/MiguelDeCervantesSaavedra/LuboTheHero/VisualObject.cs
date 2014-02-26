using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuboTheHero
{
    public abstract class VisualObject
    {
          public int IMAGE_WITDTH
        {
            get { return 7; }
        }
        public int IMAGE_HEIGHT
        {
            get { return 4; }
        }
        public char[,] CurrentImage { get; set; }

        private MatrixCoords deltaPosition;

        private MatrixCoords postion;
        public MatrixCoords Position 
        {
            get { return this.postion; }
            set { this.postion = value; }
        }

        public MatrixCoords DeltaPosition
        {
            get
            {
                return this.deltaPosition;
            }
            set
            {
                if (value.Row < -1 || value.Row > 1 || value.Col < -1 || value.Col > 1)
                {
                    throw new ArgumentOutOfRangeException("Cannot move with more than one position in each direction");
                }
                this.deltaPosition = value;
            }
        }

        public VisualObject()
        {
        }
        public VisualObject(MatrixCoords position)
        {
            this.postion = position;
        }

        public MatrixCoords GetTopLeft()
        {
            return this.Position;
        } 

        public bool[] CheckIfMoveIsPossible(Castle castle, MatrixCoords vector)
        {
            bool[] answer = new bool[2];
            bool ableToMove = new bool();
            bool mustChangeRoom = new bool();

            char[,] currentRoom = castle.GetCurrentRoom();
            MatrixCoords newHeroTopLeft = this.GetTopLeft() + vector;
            //newHeroTopLeft.Col -= 1; Problem may occur here!!!!

            int lastRow = Math.Min(newHeroTopLeft.Row + IMAGE_HEIGHT, currentRoom.GetLength(0));
            int lastCol = Math.Min(newHeroTopLeft.Col + IMAGE_WITDTH, currentRoom.GetLength(1));

            for (int row = newHeroTopLeft.Row; row < lastRow; row++)
            {
                for (int col = newHeroTopLeft.Col; col < lastCol; col++)
                {
                    if (currentRoom[row, col] != ' ')
                    {
                        ableToMove = false;
                        mustChangeRoom = false;
                        answer[0] = ableToMove;
                        answer[1] = mustChangeRoom;
                        return answer;
                    }
                }
            }

            if (newHeroTopLeft.Row == 0) //On upper room wall
            {
                ableToMove = false;
                mustChangeRoom = true;
                this.Position += new MatrixCoords(Castle.ROOM_HEIGHT - (IMAGE_HEIGHT + 2), 0);
                castle.ChangeCurrentRoom(1);
            }
            else if (newHeroTopLeft.Col == Castle.ROOM_WIDTH - IMAGE_WITDTH + 1) //On right wall
            {
                ableToMove = false;
                mustChangeRoom = true;
                this.Position -= new MatrixCoords(0, Castle.ROOM_WIDTH - (IMAGE_WITDTH + 2));
                castle.ChangeCurrentRoom(1);
            }
            else if (newHeroTopLeft.Row == Castle.ROOM_HEIGHT - IMAGE_HEIGHT) //On bottom wall
            {
                ableToMove = false;
                mustChangeRoom = true;
                this.Position -= new MatrixCoords(Castle.ROOM_HEIGHT - (IMAGE_HEIGHT + 2), 0);
                castle.ChangeCurrentRoom(-1);
            }
            else if (newHeroTopLeft.Col == 0 + Castle.WALL_WIDTH) //On left wall
            {
                ableToMove = false;
                mustChangeRoom = true;
                this.Position += new MatrixCoords(0, Castle.ROOM_WIDTH - (IMAGE_WITDTH + 2));
                castle.ChangeCurrentRoom(-1);
            }
            else
            {
                ableToMove = true;
                mustChangeRoom = false;
            }

            answer[0] = ableToMove;
            answer[1] = mustChangeRoom;
            return answer;
        }       

        

        public void Move()
        {
            this.Position += this.DeltaPosition;
        }
    }
}
