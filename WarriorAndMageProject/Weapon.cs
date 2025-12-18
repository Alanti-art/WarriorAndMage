using WarriorAndMageProject;

internal class Weapon : Item, IEquipped
{
    private int baseDamage;
    private int strengthValue;
    private int intelligenceValue;
    private int rageValue;
    private int manaValue;
    private string alowClass;
    public int BaseDamage
    {
        get { return baseDamage; }
    }
    public int IntelligenceValue
    {
        get { return intelligenceValue; }
    }
    public int StrengthValue
    {     
        get { return strengthValue; }
    }
    public int ManaValue
    {
        get { return manaValue; }
    }

    public int RageValue
    {
        get { return rageValue; }
    }
    public string Class
    {
        get { return alowClass; }
    }


    public Weapon(int maxStack, string name, string description, string alowClass, int baseDamage, int strengthValue, int intelligenceValue, int rageValue, int manaValue)
        : base(maxStack, name, description)
    {
        this.alowClass = alowClass;
        this.baseDamage = baseDamage;
        this.strengthValue = strengthValue;
        this.rageValue = rageValue;
        this.manaValue = manaValue;
        this.intelligenceValue = intelligenceValue;
    }
}