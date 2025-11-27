abstract class Weapons : Gear
{
    private string _damageType;
    private string _damageDice;
    private string _modifyerAttribute;
    private string _weaponName;
    private List<string> _attributes;

    public abstract string GetWeaponInfo();

    public void SetDamageType(string damageType)
    {
        _damageType = damageType;
    }
    public string GetDamageType()
    {
        return _damageType;
    }
    public void SetDamageDice(string dice)
    {
        _damageDice = dice;
    }
    public string GetDamageDice()
    {
        return _damageDice;
    }
    public void SetModifyerAttribute(string modifyer)
    {
        _modifyerAttribute = modifyer;
    }
    public string GetModifyerAttribute()
    {
        return _modifyerAttribute;
    }
    public void SetWeaponName(string name)
    {
        _weaponName = name;
    }
    public string GetWeaponName()
    {
        return _weaponName;
    }
    public void SetAttributes(List<string> attributes)
    {
        _attributes = attributes;
    }
    public List<string> GetAttributes()
    {
        return _attributes;
    }
}