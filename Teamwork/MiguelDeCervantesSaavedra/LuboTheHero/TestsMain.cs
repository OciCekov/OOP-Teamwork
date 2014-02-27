namespace LuboTheHero
{
    using System;
    using System.Collections.Generic;        
    using LuboTheHero.EvilCreatures;
    using System.Threading;
    using UIClasses;
    using System.Text;

    class TestsMain
    {
        private const int GameScreenHeight = 30;
        private const int GameScreenWidth = 120;

        private static void SetConsoleSettings()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WindowHeight = GameScreenHeight;
            Console.BufferHeight = GameScreenHeight;
            Console.WindowWidth = GameScreenWidth;
            Console.BufferWidth = GameScreenWidth;
        }

        private static void ReadKeyInput(Hero hero, Castle castle)
        {
            //while (true)
            //{
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);

                while (Console.KeyAvailable) Console.ReadKey(true);

                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    hero.DeltaPosition = MatrixCoords.LeftVector;
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
                    hero.DeltaPosition = MatrixCoords.RightVector;
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
                    hero.DeltaPosition = MatrixCoords.UpVector;
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
                    hero.DeltaPosition = MatrixCoords.DownVector;
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
                else if (pressedKey.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }

        public static void Main()
        {
            #region TESTING
            //List<KeyValuePair<string, uint>> req = new List<KeyValuePair<string, uint>>();
            //req.Add(new KeyValuePair<string, uint>("Stregth", 5));
            ////req.Add(new KeyValuePair<string, uint>("Dexterity", 0));
            //req.Add(new KeyValuePair<string, uint>("Inteligence", 2));
            ////req.Add(new KeyValuePair<string, uint>("Wisdom", 0));
            //req.Add(new KeyValuePair<string, uint>("Level", 2));

            //MeleeWeapon Axe = new MeleeWeapon("Axe", 3, 5, req);

            //Potion manaPotion = new Potion("health", 50);


            //MAGIC TEST
            //var fighter = new Fighter("Ivo");
            //fighter.Spells.Add(new BashSpell(2, fighter));
            //fighter.Spells.Add(new BloodBurstSpell(3, fighter));

            //var ranger = new Ranger("Pushechno meso");

            ////Console.WriteLine(fighter.PhysicalDamage);

            //fighter.CastSpell(fighter, fighter.Spells.Bash());

            ////Console.WriteLine(fighter.PhysicalDamage);
            //var monster = new Monster(20,5,3,1,1);


            //fighter.Attacking(fighter, monster);
            ////Console.WriteLine(fighter.PhysicalDamage);

            //var wizz = new Wizard("Pesho");
            //wizz.Spells.Add(new FreezeSpell(2, wizz));
            //Console.WriteLine(monster.PhysicalDamage);
            //Console.WriteLine(monster.Health);

            //wizz.CastSpell(monster, wizz.Spells.Freeze());
            //Console.WriteLine(monster.PhysicalDamage);
            //Console.WriteLine(monster.Health);

            //wizz.Attacking(wizz, monster);
            //Console.WriteLine(monster.PhysicalDamage);
            //Console.WriteLine(monster.Health);
            #endregion

            SetConsoleSettings();

            Castle firstLevelCastle = new Castle("First");

            ConsoleRenderer.DrawFromCharacterTxt(@"..\..\textfiles\head-up_display.txt", new MatrixCoords(0, 0));

            ConsoleRenderer.DrawFromCharacterMatrix(firstLevelCastle.GetCurrentRoom(), new MatrixCoords(0, 1));

            var renderer = new ConsoleRenderer(Castle.ROOM_HEIGHT - 2, Castle.ROOM_WIDTH - 2);

            MatrixCoords temp = new MatrixCoords(17, 56);
            Hero hero = new Fighter(temp, "Pencho");
            
            while (true)
            {
                ReadKeyInput(hero, firstLevelCastle);
                renderer.EnqueueForRendering(hero);                
                renderer.RenderAll();                
                renderer.ClearQueue();
            
                Console.WriteLine();
                Thread.Sleep(100);
            }
        }
    }
}
