using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LuboTheHero.EvilCreatures;
using System.Threading;

namespace LuboTheHero
{
    class TestsMain
    {
        public static void Main()
        {
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


            ConsoleRenderer.SetGameWindow();
            Castle firstLevelCastle = new Castle("First");
            ConsoleRenderer.DrawFromCharacterTxt(@"..\..\textfiles\head-up_display.txt", new MatrixCoords(0, 0));

            var renderer = new ConsoleRenderer(Castle.ROOM_HEIGHT - 2, Castle.ROOM_WIDTH - 2);

            MatrixCoords temp = new MatrixCoords(17, 56);
            Hero hero = new Fighter("Pencho", temp);

            while (true)
            {
                ConsoleRenderer.ReadKeyInput(hero, firstLevelCastle);
                renderer.EnqueueForRendering(hero);
                //renderer.EnqueueForRendering(secondHero);
                renderer.RenderAll();
                //renderer.RenderAll(secondHero);
                renderer.ClearQueue();
                Console.WriteLine();
                Thread.Sleep(100);
            }

        }
    }
}
