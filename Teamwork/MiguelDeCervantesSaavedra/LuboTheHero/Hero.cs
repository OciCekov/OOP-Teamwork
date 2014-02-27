using LuboTheHero.Spells;

namespace LuboTheHero
{
    using System;
    using System.Collections.Generic;            
    using LuboTheHero.Items;
    using LuboTheHero.UIClasses;

    public abstract class Hero : Creature, IHero, IRenderable, IMovable
    {
        public const int IMAGE_HEIGHT = 4;
        public const int IMAGE_WIDTH = 7;
        public const int returnInitialStateOfDamage = 5; //added by Ivo
        public const int returnInitialStateOfHealth = 5; //added by ivo
        public const int BacpackCapacity = 50; //added by Tsveti

        public Hero(MatrixCoords position)
            : base(position)
        {
            this.Spells = new List<Spell>(); //added by Ivo
        }
        
        public static KeyValuePair<ItemType, uint>[] ItemRestrictions = 
        { 
            new KeyValuePair<ItemType, uint> (ItemType.bodyArmour,1),
            new KeyValuePair<ItemType, uint> (ItemType.helmet,1),
            new KeyValuePair<ItemType, uint> (ItemType.boots,1),
            new KeyValuePair<ItemType, uint> (ItemType.gloves,1),
            new KeyValuePair<ItemType, uint> (ItemType.ring,10),
            new KeyValuePair<ItemType, uint> (ItemType.meleeWeapon,2),
            new KeyValuePair<ItemType, uint> (ItemType.rangedWeapon,1),
            new KeyValuePair<ItemType, uint> (ItemType.staffWeapon,1)
        };

        public List<Spell> Spells { get; protected set; } //added by Ivo                    

        public List<Item> BackpackInventar { get; set; }

        public List<EquippableItem> EquippedInventar { get; set; }

        public void Equip(EquippableItem itemToEquip) //Equip item from the backpack to the hero if the item meets requirements
        {
            int countItemTypeEquipped = 0;

            foreach (var item in EquippedInventar)
            {
                if (item.Type == itemToEquip.Type)
                {
                    countItemTypeEquipped++;
                }
            }

            uint restriction = TypeAllowedNumber(itemToEquip);
            bool meetsRequirements = CheckItemRequiremets(itemToEquip) && CheckClassConstraints(itemToEquip);

            if (countItemTypeEquipped >= restriction)
            {
                throw new CannotEquipItemException("This equipment can not be equiped because maximum allowed number of items from this type is reached.", itemToEquip, restriction);
            }
            else if (!(meetsRequirements))
            {
                throw new CannotEquipItemException("This equipment can not be equiped because you don't meet the item requirements.", itemToEquip);
            }
            else
            {
                this.EquippedInventar.Add(itemToEquip);
            }
        }

        public void UnEquip(EquippableItem item)  //Unequip item from the hero and put it in the backpack.
        {
            if (!(EquippedInventar.Contains(item)))
            {
                throw new ArgumentException("Cannot unquip item which is not equipped");
            }
            else if (BackpackInventar.Count >= BacpackCapacity)
            {
                // TODO : MUst be an exception
                Console.WriteLine("This equipment can not be unequiped because your backpack is full.");
                Console.WriteLine("Please remove something from the backpack and try again.");
            }
            else
            {
                EquippedInventar.Remove(item);
                BackpackInventar.Add(item);
            }
        }

        public void Drop(Item item) //Drop item from the backpack to the ground
        {
            if (!(BackpackInventar.Contains(item)))
            {
                // TODO : MUst be an exception
                Console.WriteLine("This item is not in your backpack.");
            }
            else
            {
                BackpackInventar.Remove(item);
            }
        }

        public void PickUp(Item item) //Pick up item from the ground if there is space in your backpack.
        {
            if (BackpackInventar.Count >= BacpackCapacity)
            {
                // TODO : MUst be an exception
                Console.WriteLine("You can't get this item because your backpack is full.");
                Console.WriteLine("Please remove something from the backpack and try again.");
            }
            else
            {
                BackpackInventar.Add(item);
            }
        }

        public uint TypeAllowedNumber(Item item) //check if the limit for this item type is reached
        {
            foreach (var pair in ItemRestrictions)
            {
                if (pair.Key == item.Type)
                {
                    return pair.Value;
                }
            }

            return uint.MaxValue;
        }

        public bool CheckItemRequiremets(EquippableItem item) //check if the hero meets the skill requirements for this item
        {
            foreach (var pair in item.Requirements)
            {
                switch (pair.Key)
                {
                    case SkillType.Level:
                        if (this.Level < pair.Value)
                            return false;
                        break;
                    case SkillType.Strenght:
                        if (this.Strenght < pair.Value)
                            return false;
                        break;
                    case SkillType.Dexterity:
                        if (this.Dexterity < pair.Value)
                            return false;
                        break;
                    case SkillType.Inteligence:
                        if (this.Inteligence < pair.Value)
                            return false;
                        break;
                    case SkillType.Wisdom:
                        if (this.Wisdom < pair.Value)
                            return false;
                        break;
                    default:
                        break;
                }
            }
            return true;
        }

        public bool CheckClassConstraints(EquippableItem item) //check if the hero meets User Class requirements for this item
        {
            return item.ClassConstraints == UserClassType.All || this.GetType().Name == item.ClassConstraints.ToString();
        }

        //Added by Ivo, for magig updates, terminates the duration of magic after the next physical attack
        public void UpdateHero()
        {
            foreach (var spell in Spells)
            {
                if (spell is BashSpell && spell.IsCasted == true)
                {
                    spell.Target.PhysicalDamage -= returnInitialStateOfDamage;
                    spell.IsCasted = false;
                }
                if (spell is BloodBurstSpell && spell.IsCasted == true)
                {
                    spell.Target.Health -= returnInitialStateOfHealth;
                    spell.IsCasted = false;
                }
                if (spell is FreezeSpell && spell.IsCasted == true)
                {
                    spell.Target.PhysicalDamage = (byte)FreezeSpell.initialAttackPoints;
                    FreezeSpell.initialAttackPoints = 0;
                    spell.IsCasted = false;
                }
            }
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
            int lastCol = Math.Min(newHeroTopLeft.Col + IMAGE_WIDTH, currentRoom.GetLength(1));

            for (int row = newHeroTopLeft.Row; row < lastRow; row++)
            {
                for (int col = newHeroTopLeft.Col - Castle.WALL_WIDTH; col < lastCol; col++)
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
            else if (newHeroTopLeft.Col == Castle.ROOM_WIDTH - IMAGE_WIDTH + 1) //On right wall
            {
                ableToMove = false;
                mustChangeRoom = true;
                this.Position -= new MatrixCoords(0, Castle.ROOM_WIDTH - (IMAGE_WIDTH + 2));
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
                this.Position += new MatrixCoords(0, Castle.ROOM_WIDTH - (IMAGE_WIDTH + 2));
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

        //added by ivo - heroes cast spells with it.
        public virtual void CastSpell(Creature fighter, Spell spell)
        {
            spell.CastOn(fighter);
        }

        public void LevelUp()
        {
            throw new NotImplementedException();
        }        
    }
}
