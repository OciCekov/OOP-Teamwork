using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LuboTheHero
{
    public class ConsoleRenderer
    {
        private const int GameScreenHeight = 30;
        private const int GameScreenWidth = 120;

        private const int PLAY_FIELD_TOP = 0;
        private const int PLAY_FIELD_LEFT = 1;

        int renderContextMatrixRows;
        int renderContextMatrixCols;
        char[,] renderContextMatrix;

        public ConsoleRenderer(int playFieldConsoleRows, int playFieldConsoleCols)
        {
            renderContextMatrix = new char[playFieldConsoleRows, playFieldConsoleCols];

            this.renderContextMatrixRows = renderContextMatrix.GetLength(0);
            this.renderContextMatrixCols = renderContextMatrix.GetLength(1);

            this.ClearQueue();
        }

        public void EnqueueForRendering(dynamic obj)
        {
            char[,] objImage = GetImage(obj);

            int imageRows = objImage.GetLength(0);
            int imageCols = objImage.GetLength(1);

            MatrixCoords objTopLeft = obj.GetTopLeft();
            objTopLeft.Col -= 2; //Compensate for room wall width and HUD
            objTopLeft.Row -= 1; //Compensate for room wall width

            int lastRow = Math.Min(objTopLeft.Row + imageRows, this.renderContextMatrixRows);
            int lastCol = Math.Min(objTopLeft.Col + imageCols, this.renderContextMatrixCols);

            for (int row = objTopLeft.Row; row < lastRow; row++)
            {
                for (int col = objTopLeft.Col; col < lastCol; col++)
                {
                    if (row >= 0 && row < renderContextMatrixRows &&
                        col >= 0 && col < renderContextMatrixCols)
                    {
                        renderContextMatrix[row, col] = objImage[row - objTopLeft.Row, col - objTopLeft.Col];
                    }
                }
            }
        }

        public void RenderAll()
        {
            Console.SetCursorPosition(PLAY_FIELD_LEFT + Castle.WALL_WIDTH, PLAY_FIELD_TOP + Castle.WALL_WIDTH);

            StringBuilder scene = new StringBuilder();
            int rowIncrease = 0;

            for (int row = 0; row < this.renderContextMatrixRows; row++) //this.renderContextMatrixRows
            {
                for (int col = 0; col < this.renderContextMatrixCols; col++)//this.renderContextMatrixCols
                {
                    scene.Append(this.renderContextMatrix[row, col]);
                }
                Console.Write(scene.ToString());
                rowIncrease++;
                Console.SetCursorPosition(PLAY_FIELD_LEFT + Castle.WALL_WIDTH, PLAY_FIELD_TOP + Castle.WALL_WIDTH + rowIncrease);
                scene.Clear();
            }
        }

        public void ClearQueue()
        {
            for (int row = 0; row < this.renderContextMatrixRows; row++)
            {
                for (int col = 0; col < this.renderContextMatrixCols; col++)
                {
                    this.renderContextMatrix[row, col] = ' ';
                }
            }
        }

        public static void DrawFromCharacterTxt(string textFilePath, MatrixCoords cursorPosition)
        {
            Console.SetCursorPosition(cursorPosition.Col, cursorPosition.Row);
            StreamReader reader = new StreamReader(textFilePath);

            using (reader)
            {
                string currentLine;

                while ((currentLine = reader.ReadLine()) != null)
                {
                    Console.WriteLine(currentLine);
                }
            }
        }

        public static void DrawFromCharacterMatrix(char[,] matrix, MatrixCoords cursorPosition)
        {
            Console.SetCursorPosition(cursorPosition.Col, cursorPosition.Row);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.SetCursorPosition(cursorPosition.Col, ++cursorPosition.Row);
            }
        }

        public static void SetGameWindow()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WindowHeight = GameScreenHeight;
            Console.BufferHeight = GameScreenHeight;
            Console.WindowWidth = GameScreenWidth;
            Console.BufferWidth = GameScreenWidth;
        }
        public static void ReadKeyInput(Hero hero, Castle castle)
        {
            //while (true)
            //{
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable) Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    hero.DeltaPosition = MatrixCoords.LEFT_VECTOR;
                    bool[] move = hero.CheckIfMoveIsPossible(castle, hero.DeltaPosition);
                    if (move[0] == true)
                    {
                        hero.Move();
                    }
                    else if (move[0] == false && move[1] == true)
                    {
                        ConsoleRenderer.DrawFromCharacterMatrix(castle.GetCurrentRoom(), new MatrixCoords(0, 1));
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    hero.DeltaPosition = MatrixCoords.RIGHT_VECTOR;
                    bool[] move = hero.CheckIfMoveIsPossible(castle, hero.DeltaPosition);
                    if (move[0] == true)
                    {
                        hero.Move();
                    }
                    else if (move[0] == false && move[1] == true)
                    {
                        ConsoleRenderer.DrawFromCharacterMatrix(castle.GetCurrentRoom(), new MatrixCoords(0, 1));
                    }
                }
                else if (pressedKey.Key == ConsoleKey.UpArrow)
                {
                    hero.DeltaPosition = MatrixCoords.UP_VECTOR;
                    bool[] move = hero.CheckIfMoveIsPossible(castle, hero.DeltaPosition);
                    if (move[0] == true)
                    {
                        hero.Move();
                    }
                    else if (move[0] == false && move[1] == true)
                    {
                        ConsoleRenderer.DrawFromCharacterMatrix(castle.GetCurrentRoom(), new MatrixCoords(0, 1));
                    }
                }
                else if (pressedKey.Key == ConsoleKey.DownArrow)
                {
                    hero.DeltaPosition = MatrixCoords.DOWN_VECTOR;
                    bool[] move = hero.CheckIfMoveIsPossible(castle, hero.DeltaPosition);
                    if (move[0] == true)
                    {
                        hero.Move();
                    }
                    else if (move[0] == false && move[1] == true)
                    {
                        ConsoleRenderer.DrawFromCharacterMatrix(castle.GetCurrentRoom(), new MatrixCoords(0, 1));
                    }
                }
            }

            //if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            //break;
            //}
        }

        private dynamic GetImage(dynamic hero)
        {
            if (hero.DeltaPosition.Equals(MatrixCoords.LEFT_VECTOR))
            {
                hero.CurrentImage = hero.LeftMatrix;
                return hero.LeftMatrix;
            }
            else if (hero.DeltaPosition.Equals(MatrixCoords.RIGHT_VECTOR))
            {
                hero.CurrentImage = hero.RightMatrix;
                return hero.RightMatrix;
            }
            else if (hero.DeltaPosition.Equals(MatrixCoords.DOWN_VECTOR))
            {
                if (hero.CurrentImage == hero.RightDownMatrix || hero.CurrentImage == hero.RightUpMatrix || hero.CurrentImage == hero.RightMatrix)
                {
                    hero.CurrentImage = hero.RightDownMatrix;
                    return hero.RightDownMatrix;
                }
                else
                {
                    hero.CurrentImage = hero.LeftDownMatrix;
                    return hero.LeftDownMatrix;
                }
            }
            else
            {
                if (hero.CurrentImage == hero.RightDownMatrix || hero.CurrentImage == hero.RightUpMatrix || hero.CurrentImage == hero.RightMatrix)
                {
                    hero.CurrentImage = hero.RightUpMatrix;
                    return hero.RightUpMatrix;
                }
                else
                {
                    hero.CurrentImage = hero.LeftUpMatrix;
                    return hero.LeftUpMatrix;
                }
            }
        }
    }
}
