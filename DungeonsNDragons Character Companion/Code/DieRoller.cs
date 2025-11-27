class DieRoller{
    public int RollDice(int diceType)
    {
        Random rand = new Random();
        int roll = rand.Next(1, (diceType + 1));
        return roll;
    }

        public int RollStat()
    {
        //rolls dice 4 times, but only the best 3 are used
        int roll1 = RollDice(6);
        int roll2 = RollDice(6);
        int roll3 = RollDice(6);
        int roll4 = RollDice(6);
        int diceAdded = 0;
        int total = 0;

        //adds all but the lowest value
        if(roll1 > roll2 || roll1 > roll3 || roll1 > roll4)
        {
            total += roll1;
            diceAdded += 1;
        }
        if(roll2 > roll1 || roll2 > roll3 || roll2 > roll4)
        {
            total += roll2;
            diceAdded += 1;
        }
        if(roll3 > roll2 || roll3 > roll1 || roll3 > roll4)
        {
            total += roll3;
            diceAdded += 1;
        }
        if(roll4 > roll1 || roll4 > roll3 || roll4 > roll2)
        {
            total += roll4;
            diceAdded += 1;
        }
            
        if(diceAdded == 3)
            return total;
        //for the case of the lowest number being a tied
        else
            while(diceAdded != 3)
            {
                total += RollDice(6);
                diceAdded += 1;
            }
            return total;
    }
    public int AttackRoll(string diceInfo)
    {

        return 0;
    }
}