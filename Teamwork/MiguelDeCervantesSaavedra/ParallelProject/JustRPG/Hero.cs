using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustRPG
{
    using System;

    public abstract class Hero : IRenderable, IMovable
    {
        public const int HERO_IMAGE_WIDTH = 7;
        public const int HERO_IMAGE_HEIGHT = 4;

        private MatrixCoords deltaPosition;

        public Hero(MatrixCoords position)
        {
            this.Position = position;            
        }

        public MatrixCoords Position { get; protected set; }

        public char[,] CurrentImage { get; protected set; }

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

            int lastRow = Math.Min(newHeroTopLeft.Row + HERO_IMAGE_HEIGHT, currentRoom.GetLength(0));
            int lastCol = Math.Min(newHeroTopLeft.Col + HERO_IMAGE_WIDTH, currentRoom.GetLength(1));

            for (int row = newHeroTopLeft.Row; row < lastRow; row++)
            {
                for (int col = newHeroTopLeft.Col - 1; col < lastCol; col++)
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
                this.Position += new MatrixCoords(Castle.ROOM_HEIGHT - (HERO_IMAGE_HEIGHT + 2), 0);
                castle.ChangeCurrentRoom(1);
            }
            else if (newHeroTopLeft.Col == Castle.ROOM_WIDTH - HERO_IMAGE_WIDTH + 1) //On right wall
            {
                ableToMove = false;
                mustChangeRoom = true;
                this.Position -= new MatrixCoords(0, Castle.ROOM_WIDTH - (HERO_IMAGE_WIDTH + 2));
                castle.ChangeCurrentRoom(1);
            }
            else if (newHeroTopLeft.Row == Castle.ROOM_HEIGHT - HERO_IMAGE_HEIGHT) //On bottom wall
            {
                ableToMove = false;
                mustChangeRoom = true;
                this.Position -= new MatrixCoords(Castle.ROOM_HEIGHT - (HERO_IMAGE_HEIGHT + 2), 0);
                castle.ChangeCurrentRoom(-1);
            }
            else if (newHeroTopLeft.Col == 0 + Castle.WALL_WIDTH) //On left wall
            {
                ableToMove = false;
                mustChangeRoom = true;
                this.Position += new MatrixCoords(0, Castle.ROOM_WIDTH - (HERO_IMAGE_WIDTH + 2));
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

        public abstract char[,] GetImage();

        public void Move()
        {
            this.Position += this.DeltaPosition;
        }
    }
}
