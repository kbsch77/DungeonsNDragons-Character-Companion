class Character{
    private int _strength;
    private int _dexterity;
    private int _constitution;
    private int _intelligence;
    private int _wisdom;
    private int _charisma;
    private string _name;
    private int _level =1;

    public Character (string name)
    {
        _name = name;
        DieRoller dice = new DieRoller();
        _strength = dice.RollStat();
        _dexterity = dice.RollStat();
        _constitution = dice.RollStat();
        _intelligence = dice.RollStat();
        _wisdom = dice.RollStat();
        _charisma = dice.RollStat();
    }
    public Character (string name, int strength=1, int dexterity=1, int constitution=1, int intelligence=1, int wisdom=1, int charisma=1)
    {
        _name = name;
        _strength = strength;
        _dexterity = dexterity;
        _constitution = constitution;
        _intelligence = intelligence;
        _wisdom = wisdom;
        _charisma = charisma;
    }

    public int ModifyStats(string attribute)
    {
        int modifyer;
        int stat = 0;

        if(attribute == "strength")
            stat = _strength;
        else if(attribute == "dexterity")
            stat = _dexterity;
        else if(attribute == "constitution")
            stat = _constitution;
        else if(attribute == "intelligence")
            stat = _intelligence;
        else if(attribute == "wisdom")
            stat = _wisdom;
        else if(attribute == "charisma")
            stat = _charisma;

        if(stat == 30)
            modifyer = 10;
        else if(Enumerable.Range(28,30).Contains(stat))
            modifyer = 9;
        else if(Enumerable.Range(26,28).Contains(stat))
            modifyer = 8;
        else if(Enumerable.Range(24,26).Contains(stat))
            modifyer = 7;
        else if(Enumerable.Range(22,24).Contains(stat))
            modifyer = 6;
        else if(Enumerable.Range(20,22).Contains(stat))
            modifyer = 5;
        else if(Enumerable.Range(18,20).Contains(stat))
            modifyer = 4;
        else if(Enumerable.Range(16,18).Contains(stat))
            modifyer = 3;
        else if(Enumerable.Range(14,16).Contains(stat))
            modifyer = 2;
        else if(Enumerable.Range(12,14).Contains(stat))
            modifyer = 1;
        else if(Enumerable.Range(10,12).Contains(stat))
            modifyer = 0;
        else if(Enumerable.Range(8,10).Contains(stat))
            modifyer = -1;
        else if(Enumerable.Range(6,8).Contains(stat))
            modifyer = -2;
        else if(Enumerable.Range(4,6).Contains(stat))
            modifyer = -3;
        else if(Enumerable.Range(2,4).Contains(stat))
            modifyer = -4;
        else if(stat == 1)
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
    public void SetLevel(int level = 1)
    {
        _level = level;

    }
    public int GetLevel()
    {
        return _level;
    }
    public int GetStrength()
    {
        return _strength;
    }
    public int GetDexterity()
    {
        return _dexterity;
    }
    public int GetConstitution()
    {
        return _constitution;
    }
    public int GetIntelligence()
    {
        return _intelligence;
    }
    public int GetWisdom()
    {
        return _wisdom;
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