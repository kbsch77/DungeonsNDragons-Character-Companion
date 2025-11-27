class MeleeWeapons : Weapons
{
    public MeleeWeapons(string name)
    {
        var weapons = GetMeleeWeapons();
        List<string> info = weapons[name];

        SetWeaponName(name);
        SetCost(info[0]);
        SetDamageDice(info[1]);
        SetDamageType(info[2]);
        SetWeight(info[3]);
        List<string> attributes = new List<string>()
        {
            info[4], info[5], info[6]
        };
        SetAttributes(attributes);
    }

    public override string GetWeaponInfo ()
    {
        string weaponInfo = (GetWeaponName() + ", " + GetDamageDice() + " " + GetDamageType());

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
}