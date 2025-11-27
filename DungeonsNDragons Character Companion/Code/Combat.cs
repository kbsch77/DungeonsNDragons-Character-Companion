abstract class Combat
{
    private int _enemyArmorClass;

    public abstract void Attack (int attackRoll, string weapon);
    public void Hit (string weapon, int damageRoll)
    {
        Console.WriteLine("");
        Console.WriteLine();
    }
    public void Miss()
    {
        Console.WriteLine("You missed.");
        Console.WriteLine();
    }

    public void SetEnemyArmorClass(int armorClass)
    {
        _enemyArmorClass = armorClass;
    }
    public int GetEnemyArmorClass()
    {
        return _enemyArmorClass;
    }

    public abstract int UseAmmunition(int v);
}