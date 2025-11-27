class MeleeCombat : Combat
{
        public override void Attack (int attackRoll, string weapon)
    {
        Console.Write("What is the enemy's AC? ");
        SetEnemyArmorClass(int.Parse(Console.ReadLine()));

        if(attackRoll >= GetEnemyArmorClass())
        {
            Hit(weapon, attackRoll);
        }
        else Console.WriteLine("You missed.");
    }
    
    public override int UseAmmunition(int v)
    {
        throw new NotImplementedException();
    }
}