class Armors : Gear
{
    private string _armorName;
    private string _armorType;
    private int _armorClassBonus;
    private int _streangthRequirement;
    private bool _stealthDisadvantage;

    public Armors(string name)
    {
        var armors = GetArmors();
        List<string> info = armors[name];

        _armorName = name;
        _armorType = info[0];
        SetCost(info[1]);
        string modifyerInfo = info[2];
        _streangthRequirement = int.Parse(info[3]);
        string stealthInfo = info[4];
        SetWeight(info[5]);
    }

    public string GetArmorInfo ()
    {
        string armorInfo = (_armorName + ", " + _armorType + ", AC +" + _armorClassBonus + ", " + "Strength of " + _streangthRequirement + " required");
        
        if(_stealthDisadvantage)
        {
            armorInfo = armorInfo + (", Stealth Disadvantage");
        }

        return armorInfo;
    }
    public override  string GetArmor(string armor)
    {

        return armor;
    }
    public override string GetWeapon (string weapon)
    {
        return weapon;
    }
}