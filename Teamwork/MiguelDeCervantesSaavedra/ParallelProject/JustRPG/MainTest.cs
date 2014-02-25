namespace JustRPG
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading;

    class MainTest
    {
        const int GameScreenHeight = 30;
        const int GameScreenWidth = 120;

        private static void SetConsoleInitialSettings()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WindowHeight = GameScreenHeight;
            Console.BufferHeight = GameScreenHeight;
            Console.WindowWidth = GameScreenWidth;
            Console.BufferWidth = GameScreenWidth;
        }

        static void Main()
        {
            SetConsoleInitialSettings();

            ConsoleRenderer.DrawFromCharacterTxt(@"..\..\textfiles\head-up_display.txt", new MatrixCoords(0, 0));            

            Castle firstLevelCastle = new Castle("First");

            ConsoleRenderer.DrawFromCharacterMatrix(firstLevelCastle.GetCurrentRoom(), new MatrixCoords(0, 1));

            var renderer = new ConsoleRenderer(Castle.ROOM_HEIGHT - 2, Castle.ROOM_WIDTH - 2);

            Fighter hero = new Fighter(new MatrixCoords(17, 56));

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                    while (Console.KeyAvailable) Console.ReadKey(true);

                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        hero.DeltaPosition = MatrixCoords.LEFT_VECTOR;
                        bool[] move = hero.CheckIfMoveIsPossible(firstLevelCastle, hero.DeltaPosition);
                        if (move[0] == true)
                        {
                            hero.Move();
                        }
                        else if (move[0] == false && move[1] == true)
                        {
                            ConsoleRenderer.DrawFromCharacterMatrix(firstLevelCastle.GetCurrentRoom(), new MatrixCoords(0, 1));
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        hero.DeltaPosition = MatrixCoords.RIGHT_VECTOR;
                        bool[] move = hero.CheckIfMoveIsPossible(firstLevelCastle, hero.DeltaPosition);
                        if (move[0] == true)
                        {
                            hero.Move();
                        }
                        else if (move[0] == false && move[1] == true)
                        {
                            ConsoleRenderer.DrawFromCharacterMatrix(firstLevelCastle.GetCurrentRoom(), new MatrixCoords(0, 1));
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.UpArrow)
                    {
                        hero.DeltaPosition = MatrixCoords.UP_VECTOR;
                        bool[] move = hero.CheckIfMoveIsPossible(firstLevelCastle, hero.DeltaPosition);
                        if (move[0] == true)
                        {
                            hero.Move();
                        }
                        else if (move[0] == false && move[1] == true)
                        {
                            ConsoleRenderer.DrawFromCharacterMatrix(firstLevelCastle.GetCurrentRoom(), new MatrixCoords(0, 1));
                        }
                    }
                    else if (pressedKey.Key == ConsoleKey.DownArrow)
                    {
                        hero.DeltaPosition = MatrixCoords.DOWN_VECTOR;
                        bool[] move = hero.CheckIfMoveIsPossible(firstLevelCastle, hero.DeltaPosition);
                        if (move[0] == true)
                        {
                            hero.Move();
                        }
                        else if (move[0] == false && move[1] == true)
                        {
                            ConsoleRenderer.DrawFromCharacterMatrix(firstLevelCastle.GetCurrentRoom(), new MatrixCoords(0, 1));
                        }
                    }
                }

                renderer.EnqueueForRendering(hero);
                renderer.RenderAll();
                renderer.ClearQueue();
                Thread.Sleep(100);
            }
        }
    }
}
