
namespace Hero
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Engine
    {
        public IList<Item> ListOfItems { get; set; }
        public IList<Fighter> ListOfFighters { get; set; }
        public StringBuilder Builder { get; set; }
        public IList<Enemy> ListOfEnemies { get; set; }
        public Engine()
        {       
            this.Builder = new StringBuilder();
            this.ListOfFighters = new List<Fighter>();
            this.ListOfItems = new List<Item>();
            this.ListOfEnemies = new List<Enemy>();
        }


        public void Run()
        {
            try
            {


                bool isEmtyp = false;
                while (isEmtyp == false)
                {
                    string consoleCommands = Console.ReadLine();
                    if (consoleCommands == string.Empty)
                    {
                        Console.WriteLine(this.Builder.ToString());
                        break;
                    }
                    var readCommands = consoleCommands.Split(' ');
                    if (readCommands[0] == "Create")
                    {
                        Creat(readCommands[1], readCommands[2]);
                    }
                    else
                    {
                        switch (readCommands[1])
                        {
                            case "Attack":
                                ToggleAttack(readCommands[0], readCommands[2]);
                                break;
                            case "Pickup":
                                TogglePickup(readCommands[0], readCommands[2]);
                                break;
                            case "Equip":
                                ToggleEquip(readCommands[0], readCommands[2]);
                                break;
                            case "Drop":
                                ToggleDrop(readCommands[0], readCommands[2]);
                                break;
                            case "Cast":
                                ToggleCastOn(readCommands[0], readCommands[2]);
                                break;
                            case "Info":
                                ToggleInfo(readCommands[0]);
                                break;
                            default:
                                throw new Exception("Invalid command");

                        }
                    }

                }
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid command");
            }
        }

        private void ToggleInfo(string hero)
        {
            bool heroExist = false;
            int heroPosition = 0;
            bool enemyExist = false;
            int enemyPosition = 0;

            for (int i = 0; i < this.ListOfFighters.Count; i++)
            {
                if(this.ListOfFighters[i].Name == hero)
                {
                    heroExist = true;
                    heroPosition = i;
                }
            }
            for (int i = 0; i < this.ListOfEnemies.Count; i++)
            {
                if(this.ListOfEnemies[i].Name == hero)
                {
                    enemyExist = true;
                    enemyPosition = i;
                }
            }

            if(heroExist == true)
            {
                this.Builder.AppendLine(this.ListOfFighters[heroPosition].ToString());
            }
            else if(heroExist == false && enemyExist == true)
            {
                this.Builder.AppendLine(this.ListOfEnemies[enemyPosition].ToString());
            }
            else
            {
                this.Builder.AppendLine(hero + " doesn't exist");
            }

        }

        private void ToggleCastOn(string attacker, string magic)
        {
            bool attackerExists = false;
            int atrackerPosition = 0;
            for (int i = 0; i < this.ListOfFighters.Count; i++)
            {
                if (this.ListOfFighters[i].Name == attacker)
                {
                    attackerExists = true;
                    atrackerPosition = i;
                }
            }
            if (attackerExists == true && ListOfFighters[atrackerPosition].GetType().Name == "Barb")
            {
                switch (magic)
                {
                    case "Bash":
                        this.ListOfFighters[atrackerPosition].CastSpell(ListOfFighters[atrackerPosition],
                            this.ListOfFighters[atrackerPosition].Spells.Bash());
                        this.Builder.AppendLine(attacker + " casted " + magic);
                        break;
                    case "BloodBurst":
                        this.ListOfFighters[atrackerPosition].CastSpell(ListOfFighters[atrackerPosition],
                            this.ListOfFighters[atrackerPosition].Spells.BloodBurst());
                        this.Builder.AppendLine(attacker + " casted " + magic);
                        break;
                    default:
                        this.Builder.AppendLine(attacker + " " + "doesn't support " + magic);
                        break;
                }
            }
            if (attackerExists == true && ListOfFighters[atrackerPosition].GetType().Name == "Ama")
            {
                switch (magic)
                {
                    case "CriticalStrike":
                        this.ListOfFighters[atrackerPosition].CastSpell(ListOfFighters[atrackerPosition],
                            this.ListOfFighters[atrackerPosition].Spells.CriticalStrike());
                        this.Builder.AppendLine(attacker + " casted " + magic);
                        break;
                    case "MagicArrow":
                        if (this.ListOfEnemies.Count > 0)
                        {
                            this.ListOfFighters[atrackerPosition].CastSpell(this.ListOfEnemies[0],
                            this.ListOfFighters[atrackerPosition].Spells.MagicArrow());
                            this.Builder.AppendLine(attacker + " casted " + magic);
                            break;
                        }
                        else
                        {
                            this.Builder.AppendLine("No enemy to cast on");
                            break;
                            //throw new ArgumentException("No enemy to cast on");
                        }

                    default:
                        this.Builder.AppendLine(attacker + " " + "doesn't support " + magic);
                        break;
                        //throw new ArgumentException(attacker + " " + "doesn't support " + magic);
                }
            }
            if (attackerExists == true && ListOfFighters[atrackerPosition].GetType().Name == "Wizzard")
            {
                switch (magic)
                {
                    case "ManaSuck":
                        if (this.ListOfEnemies.Count > 0)
                        {
                            this.ListOfFighters[atrackerPosition].CastSpell(this.ListOfEnemies[0],
                            this.ListOfFighters[atrackerPosition].Spells.ManaSuck());
                            this.Builder.AppendLine(attacker + " casted " + magic);
                            break;
                        }
                        else
                        {
                            this.Builder.AppendLine("No enemy to cast on");
                            break;
                        }

                    case "Freeze":
                        if (this.ListOfEnemies.Count > 0)
                        {
                            this.ListOfFighters[atrackerPosition].CastSpell(this.ListOfEnemies[0],
                            this.ListOfFighters[atrackerPosition].Spells.Freeze());
                            this.Builder.AppendLine(attacker + " casted " + magic);
                            break;
                        }
                        else
                        {
                            this.Builder.AppendLine("No enemy to cast on");
                            break;
                        }

                    default:
                        this.Builder.AppendLine(attacker + " " + "doesn't support " + magic);
                        break;
                }
            }
            if(attackerExists == false)
            {
                this.Builder.AppendLine(attacker + "doesn't exist");
            }
        }
            

        private void ToggleDrop(string owner, string item)
        {
            bool ownerExist = false;
            bool itemExist = false;
            int ownerPosition = 0;
            int itemPosition = 0;
            for (int i = 0; i < this.ListOfFighters.Count; i++)
            {
                if (this.ListOfFighters[i].Name == owner)
                {
                    ownerExist = true;
                    ownerPosition = i;
                }
            }
            if (ownerExist == true)
            {
                for (int i = 0; i < ListOfFighters[ownerPosition].ListOfItems.Count; i++)
                {
                    if (ListOfFighters[ownerPosition].ListOfItems[i].Name == item)
                    {
                        itemExist = true;
                        itemPosition = i;
                    }
                }
                if (itemExist == true)
                {
                    ListOfFighters[ownerPosition].DropItem(); //can be changed to hold name
                    this.Builder.AppendLine(owner + " dropped " + item);
                }
                if (itemExist == false)
                {
                    this.Builder.AppendLine("No such item in the stash");
                }
            }
            if (ownerExist == false)
            {
                this.Builder.AppendLine(owner + " doesn't exist");
            }
        }

        private void ToggleEquip(string owner, string item)
        {
            bool ownerExist = false;
            bool itemExist = false;
            int ownerPosition = 0;
            int itemPosition = 0;//can be used
            for (int i = 0; i < this.ListOfFighters.Count; i++)
            {
                if (this.ListOfFighters[i].Name == owner)
                {
                    ownerExist = true;
                    ownerPosition = i;
                }
            }
            if(ownerExist == true)
            {
                for (int i = 0; i < ListOfFighters[ownerPosition].ListOfItems.Count; i++)
                {
                    if(ListOfFighters[ownerPosition].ListOfItems[i].Name == item)
                    {
                        itemExist = true;
                    }
                }
                if(itemExist == true)
                {
                    ListOfFighters[ownerPosition].EquipItem(); //can be changed to hold the name of item
                    this.Builder.AppendLine(owner + " equiped " + item);
                }
                if(itemExist == false)
                {
                    this.Builder.AppendLine("No such item in the stash");
                }
            }
            if(ownerExist == false)
            {
                this.Builder.AppendLine(owner + " doesn't exist");
            }
            
        }

        private void TogglePickup(string owner, string item)
        {
            bool ownerExist = false;
            bool itemExist = false;
            int ownerPosition = 0;
            int itemPosition = 0;
            for (int i = 0; i < this.ListOfFighters.Count; i++)
            {
                if(this.ListOfFighters[i].Name == owner)
                {
                    ownerExist = true;
                    ownerPosition = i;
                }
            }
            for (int i = 0; i < this.ListOfItems.Count; i++)
            {
                if(this.ListOfItems[i].Name == item)
                {
                    itemExist = true;
                    itemPosition = i;
                    
                }
            }
            if(ownerExist == true && itemExist == true)
            {

                //Tova moje da se iznese v metod pickup() na gerioite
                this.ListOfFighters[ownerPosition].ListOfItems.Add(this.ListOfItems[itemPosition]);

                this.Builder.AppendLine(owner + " picked " + item);
            }
            else if(ownerExist == false && itemExist == true)
            {
                this.Builder.AppendLine("Hero" + " " + owner + " doesn't exist");
            }
            else if(ownerExist == true && itemExist == false)
            {
                this.Builder.AppendLine("Item" + " " + item + " doesn't exist");
            }
            else
            {
                this.Builder.AppendLine("Both " + owner +" and " + item + " doesn't exist");
            }
            
        }

        private void ToggleAttack(string attacker, string defender)
        {
            bool attackerExists = false;
            bool defenderExists = false;
            int attackerPosition = 0;
            int defenderPosition = 0;
            for (int i = 0; i < this.ListOfFighters.Count; i++)
			{
                if(this.ListOfFighters[i].Name == attacker)
                {
                    attackerExists = true;
                    attackerPosition = i;
                }
            }
            for (int i = 0; i < this.ListOfEnemies.Count; i++)
			{
                if(this.ListOfEnemies[i].Name == defender)
                {
                    defenderExists = true;
                    defenderPosition = i;
                }
            }
            if(attackerExists == true && defenderExists == true)
            {
                this.ListOfFighters[attackerPosition].Attack(this.ListOfEnemies[defenderPosition]);
                this.Builder.AppendLine(attacker + " " + "strikes" + " " + defender);
            }
            else if(attackerExists == false && defenderExists == true)
            {
                this.Builder.AppendLine(attacker + " " + "doesn't exist");
            }
            else if(defenderExists == false && attackerExists == true)
            {
                this.Builder.AppendLine(defender + " " + "doesn't exist");
            }
            else 
            {
                this.Builder.AppendLine("No such creatures");
            }
        }

        private void Creat(string type, string name)
        {
            switch(type)
            {
                case "Barb":
                    this.ListOfFighters.Add(new Barb(name));
                    break;
                case "Ama":
                    this.ListOfFighters.Add(new Ama(name));
                    break;
                case "BodyArmor":
                    this.ListOfItems.Add(new BodyArmour(name,10));
                    break;
                case "Boots":
                    this.ListOfItems.Add(new Boots(name, 3));
                    break;
                case "Gloves":
                    this.ListOfItems.Add(new Gloves(name, 2));
                    break;
                case "Ring":
                    this.ListOfItems.Add(new Ring(name, 1));
                    break;
                case "HealthPotion":
                    this.ListOfItems.Add(new HealthPotion(name,4));
                    break;
                case "ManaPotion":
                    this.ListOfItems.Add(new ManaPotion(name, 4));
                    break;
                case "StaffWeapon":
                    this.ListOfItems.Add(new StaffWeapon(name, 2));
                    break;
                case "RangedWeapon":
                    this.ListOfItems.Add(new RangedWeapon(name, 4));
                    break;
                case "MeleeWeapon":
                    this.ListOfItems.Add(new MeleeWeapon(name, 6));
                    break;
                case "Enemy":
                    this.ListOfEnemies.Add(new Enemy(name));
                    break;
                case "Wizzard":
                    this.ListOfFighters.Add(new Wizzard(name));
                    break;
                default:
                    throw new ArgumentException("Invalid command");
            }

            this.Builder.AppendLine(type + " " + name + " " + "created");
            
        }
    }
}
