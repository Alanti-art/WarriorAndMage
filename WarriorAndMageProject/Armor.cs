using System.Data;
using System.Runtime.InteropServices;

namespace WarriorAndMageProject
{
    internal class Armor : Item, IEquipped
    {
        private int armorValue;
        private string alowClass;
        private int intelligenceValue;
        private int manaValue;
        private int rageValue;
        private int strengthValue;


        public int ArmorValue
        {
            get { return armorValue; }
        }
        public string Class
        {
            get { return alowClass; } 
        }
        public int StrengthValue
        {
            get { return strengthValue; }
        }
        public int IntelligenceValue
        {
            get { return intelligenceValue; }
        }
        public int ManaValue
        {
            get { return manaValue; }
        }
        public int RageValue
        {
            get { return rageValue; }
        }




        public Armor(int maxStack, string name, string description, int armorValue, string alowClass, int intelligenceValue, int manaValue, int rageValue)
            : base(maxStack, name, description)
        {
            this.armorValue = armorValue;
            this.alowClass = alowClass;
            this.rageValue = rageValue;
            this.manaValue = manaValue;
            this.intelligenceValue = intelligenceValue;

        }
    }

    internal class Head : Armor
    {
        public Head(int maxStack, string name, string description, int armorValue, string alowClass, int intelligenceValue, int manaValue, int rageValue)
            : base(maxStack, name, description, armorValue, alowClass, intelligenceValue, manaValue, rageValue)
        {

        }
    }

    internal class Body : Armor
    {
        public Body(int maxStack, string name, string description, int armorValue, string alowClass, int intelligenceValue, int manaValue, int rageValue)
            : base(maxStack, name, description, armorValue, alowClass, intelligenceValue, manaValue, rageValue)
        {

        }
    }

    internal class Hands : Armor
    {
        public Hands(int maxStack, string name, string description, int armorValue, string alowClass, int intelligenceValue, int manaValue, int rageValue)
            : base(maxStack, name, description, armorValue, alowClass, intelligenceValue, manaValue, rageValue)
        {

        }
    }

    internal class Legs : Armor
    {
        public Legs(int maxStack, string name, string description, int armorValue, string alowClass, int intelligenceValue, int manaValue, int rageValue)
            : base(maxStack, name, description, armorValue, alowClass, intelligenceValue, manaValue, rageValue)
        {

        }
    }

    internal class Boots : Armor
    {
        public Boots(int maxStack, string name, string description, int armorValue, string alowClass, int intelligenceValue, int manaValue, int rageValue)
            : base(maxStack, name, description, armorValue, alowClass, intelligenceValue, manaValue, rageValue)
        {

        }
    }

    internal class Ring : Armor
    {
        public Ring(int maxStack, string name, string description, int armorValue, string alowClass, int intelligenceValue, int manaValue, int rageValue)
            : base(maxStack, name, description, armorValue, alowClass, intelligenceValue, manaValue, rageValue)
        {

        }
    }


    internal class Necklace : Armor
    {
        public Necklace(int maxStack, string name, string description, int armorValue, string alowClass, int intelligenceValue, int manaValue, int rageValue)
            : base(maxStack, name, description, armorValue, alowClass, intelligenceValue, manaValue, rageValue)
        { 

        }
    }
}