class RangedWeapons : Weapons
{
    private int _optimalRange;
    private int _maxRange;
    private int _ammunitionAmmount;
    private string _attackType;

    public RangedWeapons(string name)
    {
        var weapons = GetRangedWeapons();
        List<string> info = weapons[name];

        SetWeaponName(name);
        SetCost(info[0]);
        SetDamageDice(info[1]);
        SetDamageType(info[2]);
        SetWeight(info[3]);
        _attackType = info[4];
        _optimalRange = int.Parse(info[5]);
        _maxRange = int.Parse(info[6]);
        List<string> attributes = new List<string>()
        {
            info[7], info[8], info[9]
        };
        SetAttributes(attributes);
    }

    public override string GetWeaponInfo()
    {
        string weaponInfo = (GetWeaponName() + ", " + GetDamageDice() + " " + GetDamageType() + ", (Range " + _optimalRange + "/" + _maxRange + ")");

        List<string> attributes = GetAttributes();
        foreach(string attribute in attributes)
        {
            if(attribute != "n/a")
            {
                weaponInfo = weaponInfo + (", " + attribute);
            }
        }

        return weaponInfo;
    }
    public override string GetWeapon (string weapon)
    {

        return weapon;
    }
    public override  string GetArmor(string armor)
    {
        return armor;
    }
    
    public void SetAmmunitionAmmount(int ammount)
    {
        _ammunitionAmmount = ammount;
    }
    public int GetAmmunitionAmmount()
    {
        return _ammunitionAmmount;
    }
}