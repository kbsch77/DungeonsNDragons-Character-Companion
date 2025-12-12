internal class Character
{
    //Character Bio
    private string _name;
    private int _level = 1;
    private string _class;
    private string _background;

    //stats
    private int _strength = 0;
    private int _dexterity = 0;
    private int _constitution = 0;
    private int _intelligence = 0;
    private int _wisdom = 0;
    private int _charisma = 0;

    //saving throws
    public int _strengthSave;
    public int _dexteritySave;
    public int _constitutionSave;
    public int _intelligenceSave;
    public int _wisdomSave;
    public int _charismaSave;

    //str
    public int _athletics;
    //dex
    public int _acrobatics;
    public int _sleightOfHand;
    public int _stealth;
    //int
    public int _arcana;
    public int _history;
    public int _investigation;
    public int _nature;
    public int _religion;
    //wis
    public int _animalHandling;
    public int _insight;
    public int _medicine;
    public int _perception;
    public int _survival;
    //cha
    public int _deception;
    public int _intimidation;
    public int _performance;
    public int _persuasion;

    public Character(string name)
    {
        _name = name;
        DieRoller dice = new DieRoller();
        _strength = dice.RollStat();
        _dexterity = dice.RollStat();
        _constitution = dice.RollStat();
        _intelligence = dice.RollStat();
        _wisdom = dice.RollStat();
        _charisma = dice.RollStat();

        _strengthSave = ModifyStats("str");
        _dexteritySave = ModifyStats("dex");
        _constitutionSave = ModifyStats("con");
        _intelligenceSave = ModifyStats("int");
        _wisdomSave = ModifyStats("wis");
        _charismaSave = ModifyStats("cha");

        _athletics = ModifyStats("str");
        _acrobatics = ModifyStats("dex");
        _sleightOfHand = ModifyStats("dex");
        _stealth = ModifyStats("dex");
        _arcana = ModifyStats("int");
        _history = ModifyStats("int");
        _investigation = ModifyStats("int");
        _nature = ModifyStats("int");
        _religion = ModifyStats("int");
        _animalHandling = ModifyStats("wis");
        _insight = ModifyStats("wis");
        _medicine = ModifyStats("wis");
        _perception = ModifyStats("wis");
        _survival = ModifyStats("wis");
        _deception = ModifyStats("cha");
        _intimidation = ModifyStats("cha");
        _performance = ModifyStats("cha");
        _persuasion = ModifyStats("cha");
    }
    public Character(string name, int strength = 1, int dexterity = 1, int constitution = 1, int intelligence = 1, int wisdom = 1, int charisma = 1)
    {
        _name = name;
        _strength = strength;
        _dexterity = dexterity;
        _constitution = constitution;
        _intelligence = intelligence;
        _wisdom = wisdom;
        _charisma = charisma;
    }

    public int ModifyStats(string attribute) //enter str, dex, con, int, wis, & cha
    {
        int modifyer;
        int stat = 0;

        if (attribute == "str")
            stat = _strength;
        else if (attribute == "dex")
            stat = _dexterity;
        else if (attribute == "con")
            stat = _constitution;
        else if (attribute == "int")
            stat = _intelligence;
        else if (attribute == "wis")
            stat = _wisdom;
        else if (attribute == "cha")
            stat = _charisma;

        if (stat == 30)
            modifyer = 10;
        else if (Enumerable.Range(28, 30).Contains(stat))
            modifyer = 9;
        else if (Enumerable.Range(26, 28).Contains(stat))
            modifyer = 8;
        else if (Enumerable.Range(24, 26).Contains(stat))
            modifyer = 7;
        else if (Enumerable.Range(22, 24).Contains(stat))
            modifyer = 6;
        else if (Enumerable.Range(20, 22).Contains(stat))
            modifyer = 5;
        else if (Enumerable.Range(18, 20).Contains(stat))
            modifyer = 4;
        else if (Enumerable.Range(16, 18).Contains(stat))
            modifyer = 3;
        else if (Enumerable.Range(14, 16).Contains(stat))
            modifyer = 2;
        else if (Enumerable.Range(12, 14).Contains(stat))
            modifyer = 1;
        else if (Enumerable.Range(10, 12).Contains(stat))
            modifyer = 0;
        else if (Enumerable.Range(8, 10).Contains(stat))
            modifyer = -1;
        else if (Enumerable.Range(6, 8).Contains(stat))
            modifyer = -2;
        else if (Enumerable.Range(4, 6).Contains(stat))
            modifyer = -3;
        else if (Enumerable.Range(2, 4).Contains(stat))
            modifyer = -4;
        else if (stat == 1)
            modifyer = -5;
        else
            modifyer = 0;

        return modifyer;
    }

    //Getters & Setters
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetClass(string characterClass)
    {
        _class = characterClass;
    }
    public string GetClass()
    {
        return _class;
    }
    public void SetBackground(string background)
    {
        _background = background;
    }
    public string GetBackground() 
    { 
        return _background; 
    }
    public void SetLevel(int level = 1)
    {
        _level = level;
    }
    public int GetLevel()
    {
        return _level;
    }
    public void SetStrength(int strength)
    {
        _strength = strength;
        _strengthSave = ModifyStats("str");
        _athletics = ModifyStats("str");
    }
    public int GetStrength()
    {
        return _strength;
    }
    public void SetDexterity(int dexterity)
    {
        _dexterity = dexterity;
        _dexteritySave = ModifyStats("dex");
        _acrobatics = ModifyStats("dex");
        _sleightOfHand = ModifyStats("dex");
        _stealth = ModifyStats("dex");
    }
    public int GetDexterity()
    {
        return _dexterity;
    }
    public void SetConstitution(int constitution) 
    { 
        _constitution = constitution;
        _constitutionSave = ModifyStats("con");
    }
    public int GetConstitution()
    {
        return _constitution;
    }
    public void SetIntelligence(int intelligence)
    {
        _intelligence = intelligence;
        _intelligenceSave = ModifyStats("int");
        _arcana = ModifyStats("int");
        _history = ModifyStats("int");
        _investigation = ModifyStats("int");
        _nature = ModifyStats("int");
        _religion = ModifyStats("int");
    }
    public int GetIntelligence()
    {
        return _intelligence;
    }
    public void SetWisdom(int wisdom)
    {
        _wisdom = wisdom;
        _wisdomSave = ModifyStats("wis");
        _animalHandling = ModifyStats("wis");
        _insight = ModifyStats("wis");
        _medicine = ModifyStats("wis");
        _perception = ModifyStats("wis");
        _survival = ModifyStats("wis");
    }
    public int GetWisdom()
    {
        return _wisdom;
    }
    public void SetCharisma(int charisma)
    {
        _charisma = charisma;
        _charismaSave = ModifyStats("cha");
        _deception = ModifyStats("cha");
        _intimidation = ModifyStats("cha");
        _performance = ModifyStats("cha");
        _persuasion = ModifyStats("cha");
    }
    public int GetCharisma()
    {
        return _charisma;
    }

    //Technical Difficulties
    public virtual MeleeWeapons GetMeleeWeapon()
    {
        return null;
    }
    public virtual RangedWeapons GetRangedWeapon()
    {
        return null;
    }
    public virtual Armors GetArmor()
    {
        return null;
    }
}