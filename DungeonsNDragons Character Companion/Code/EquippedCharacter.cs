class EquippedCharacter : Character
{
    private MeleeWeapons _meleeWeapon;
    private RangedWeapons _rangedWeapon;
    private Armors _armor;
    private bool _sheild;
    private bool _proficiency = false;

    public EquippedCharacter 
    (string name, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, 
        MeleeWeapons meleeWeapon = null, RangedWeapons rangedWeapon = null, Armors armor = null, bool sheild = false) 
    : base (name, strength, dexterity, constitution, intelligence, wisdom, charisma)
    {
        SetName(name);

        _meleeWeapon = meleeWeapon;
        _rangedWeapon = rangedWeapon;
        _armor = armor;
        _sheild = sheild;
    }

    public void ApplyWeaponProficiency()
    {

    }
    public void EquipArmor()
    {

    }
    public void EquipMeleeWeapon()
    {

    }
    public void EquipRangedWeapon()
    {

    }


    public override MeleeWeapons GetMeleeWeapon()
    {
        return _meleeWeapon;
    }
    public override RangedWeapons GetRangedWeapon()
    {
        return _rangedWeapon;
    }
    public override Armors GetArmor()
    {
        return _armor;
    }

    public void SetProficency(bool proficient)
    {
        _proficiency = proficient;
    }
    public bool getProficiency()
    {
        return _proficiency;
    }
}