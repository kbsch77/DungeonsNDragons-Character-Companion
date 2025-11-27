using System;

internal class Program
{
    static void MainTest(string[] args)
    {
        Character playerCharacter = new Character("placeholder");
        Gear gear = new Gear();
        MeleeWeapons meleeWeapon;
        RangedWeapons rangedWeapon;
        Armors armor;
        Combat fight;
        DieRoller roller = new DieRoller();
        RecordHub records = new RecordHub();

        Console.WriteLine("Welcome to D&D Character and Combat Manager!");

        bool endLoop = false;
        string playerChoice;

        string characterName = "";
        int strength;
        int dexterity;
        int constitution;
        int intelligence;
        int wisdom;
        int charisma;

        //Character Creation and Loading options and processes
        do
        {
            Console.WriteLine("Would you like to load or make a new Character? ");
            Console.Write("Enter 'L' for load or 'N' for new: ");
            playerChoice = Console.ReadLine();

            //Loads a previously made Character
            if (playerChoice.ToUpper() == "L")
            {
                Console.Write("Enter the character's name: ");
                characterName = Console.ReadLine();
                records.LoadCharacter(characterName);

                endLoop = true;
            }

            else if (playerChoice.ToUpper() == "N")
            {
                Console.Write("What is your new character's name? ");
                characterName = Console.ReadLine();

                Console.WriteLine("Would you like to roll for stats or manually enter them?");
                Console.Write("Enter 'R' for rolled (suggested) or 'M' for manual: ");
                playerChoice = Console.ReadLine();

                do
                {
                    //Roll for Stats option
                    if (playerChoice.ToUpper() == "R")
                    {
                        playerCharacter = new Character(characterName);
                    }

                    //Manual entry for Stats option
                    else if (playerChoice.ToUpper() == "M")
                    {
                        Console.WriteLine("Strength is your ability to crush a tomato.");
                        Console.Write("Enter your strength (min 1 - max 20):");
                        string playerStatChoice = Console.ReadLine();
                        strength = int.Parse(playerStatChoice);

                        Console.WriteLine("Dexterity is your ability to dodge a thrown tomato.");
                        Console.Write("Enter your dexterity (min 1 - max 20):");
                        playerStatChoice = Console.ReadLine();
                        dexterity = int.Parse(playerStatChoice);

                        Console.WriteLine("Constitution is your ability to eat a rotten tomato.");
                        Console.Write("Enter your constitution (min 1 - max 20):");
                        playerStatChoice = Console.ReadLine();
                        constitution = int.Parse(playerStatChoice);

                        Console.WriteLine("Intelligence is knowing that a tomato is a fruit.");
                        Console.Write("Enter your intelligence (min 1 - max 20):");
                        playerStatChoice = Console.ReadLine();
                        intelligence = int.Parse(playerStatChoice);

                        Console.WriteLine("Wisdom is knowing not to put a tomato in a fruit salad.");
                        Console.Write("Enter your wisdom (min 1 - max 20):");
                        playerStatChoice = Console.ReadLine();
                        wisdom = int.Parse(playerStatChoice);

                        Console.WriteLine("Charisma is your ability to sell a tomato based fruit salad.");
                        Console.Write("Enter your charisma (min 1 - max 20):");
                        playerStatChoice = Console.ReadLine();
                        charisma = int.Parse(playerStatChoice);

                        playerCharacter = new Character(characterName, strength, dexterity, constitution, intelligence, wisdom, charisma);
                        endLoop = true;
                    }

                    //For User Error
                    else
                    {
                        Console.Write("Enter 'R' for rolled (suggested) or 'M' for manual: ");
                        playerChoice = Console.ReadLine();
                    }
                } while (endLoop);
            }

            //For User Error
            else Console.WriteLine("Please enter in either 'L' or 'N'.");

        } while (endLoop);
        endLoop = false;
        Console.Clear();


        strength = playerCharacter.GetStrength();
        dexterity = playerCharacter.GetDexterity();
        constitution = playerCharacter.GetConstitution();
        intelligence = playerCharacter.GetIntelligence();
        wisdom = playerCharacter.GetWisdom();
        charisma = playerCharacter.GetCharisma();

        //Character equipment, combat, and saving options and processes
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine(" 1. Add or Change Adventure Gear");
            Console.WriteLine(" 2. Combat");
            Console.WriteLine(" 3. Save Character");
            Console.WriteLine(" 4. View Character information");
            Console.WriteLine(" 5. Quit");
            Console.Write("Enter your number: ");
            playerChoice = Console.ReadLine();
            Console.WriteLine();

            //Adds Equipment to a Character with Gear
            if (playerChoice == "1")
            {
                string playerEquiptChoice;
                string equipment;
                do
                {
                    Console.WriteLine("Choose what you would like to add or change:");
                    Console.WriteLine(" 1. A Melee Weapon");
                    Console.WriteLine(" 2. A Ranged Weapon");
                    Console.WriteLine(" 3. Armor");
                    Console.WriteLine(" 4. All Three");
                    Console.Write("Enter your number: ");
                    playerEquiptChoice = Console.ReadLine();

                    //New Melee Weapon
                    if (playerEquiptChoice == "1")
                    {
                        Console.WriteLine();
                        foreach (KeyValuePair<string, List<string>> weaponOption in gear.GetMeleeWeapons())
                            Console.WriteLine("{0}", weaponOption.Key);

                        Console.Write("Enter your melee weapon: ");
                        equipment = Console.ReadLine();

                        if (gear.GetMeleeWeapons().ContainsKey(equipment))
                            playerCharacter = new EquippedCharacter(characterName, strength, dexterity, constitution, intelligence, wisdom, charisma, new MeleeWeapons(equipment));

                        else Console.WriteLine("Please enter a weapon from the list exactly as shown.");

                        endLoop = true;
                    }

                    //New Ranged Weapon
                    else if (playerEquiptChoice == "2")
                    {
                        Console.WriteLine();
                        foreach (KeyValuePair<string, List<string>> weaponOption in gear.GetRangedWeapons())
                            Console.WriteLine("{0}", weaponOption.Key);

                        Console.Write("Enter your ranged weapon: ");
                        equipment = Console.ReadLine();

                        if (gear.GetRangedWeapons().ContainsKey(equipment))
                            playerCharacter = new EquippedCharacter(characterName, strength, dexterity, constitution, intelligence, wisdom, charisma, null, new RangedWeapons(equipment));

                        else Console.WriteLine("Please enter a weapon from the list exactly as shown.");

                        endLoop = true;
                    }

                    //New Armor
                    else if (playerEquiptChoice == "3")
                    {
                        Console.WriteLine();
                        foreach (KeyValuePair<string, List<string>> armorOption in gear.GetArmors())
                            Console.WriteLine("{0}", armorOption.Key);

                        Console.Write("Enter your armor: ");
                        equipment = Console.ReadLine();

                        if (gear.GetArmors().ContainsKey(equipment))
                            playerCharacter = new EquippedCharacter(characterName, strength, dexterity, constitution, intelligence, wisdom, charisma, null, null, new Armors(equipment));

                        else Console.WriteLine("Please enter an armor from the list exactly as shown.");

                        endLoop = true;
                    }

                    //New Melee Weapon, Ranged Weapon, and Armor
                    else if (playerEquiptChoice == "4")
                    {
                        Console.WriteLine();
                        foreach (KeyValuePair<string, List<string>> weaponOption in gear.GetMeleeWeapons())
                            Console.WriteLine("{0}", weaponOption.Key);

                        Console.Write("Enter your melee weapon: ");
                        string melee = Console.ReadLine();

                        Console.WriteLine();
                        foreach (KeyValuePair<string, List<string>> weaponOption in gear.GetRangedWeapons())
                            Console.WriteLine("{0}", weaponOption.Key);

                        Console.Write("Enter your ranged weapon: ");
                        string ranged = Console.ReadLine();

                        Console.WriteLine();
                        foreach (KeyValuePair<string, List<string>> armorOption in gear.GetArmors())
                            Console.WriteLine("{0}", armorOption.Key);

                        Console.Write("Enter your armor: ");
                        equipment = Console.ReadLine();

                        if (gear.GetMeleeWeapons().ContainsKey(melee) && gear.GetRangedWeapons().ContainsKey(ranged) && gear.GetArmors().ContainsKey(equipment))
                            playerCharacter = new EquippedCharacter(characterName, strength, dexterity, constitution, intelligence, wisdom, charisma, new MeleeWeapons(melee), new RangedWeapons(ranged), new Armors(equipment));

                        else Console.WriteLine("Please enter equipment from the lists exactly as shown.");

                        endLoop = true;
                    }

                    else Console.WriteLine("please enter a number from the menu.");
                } while (!endLoop);
                endLoop = false;
            }

            //Both Melee and Ranged Combat options
            else if (playerChoice == "2")
            {
                Console.WriteLine("Are you engaging in melee or ranged combat?");
                Console.WriteLine(" 1. Melee Combat");
                Console.WriteLine(" 2. Ranged Combat");
                Console.Write("Enter your number: ");
                string combatChoice = Console.ReadLine();

                do
                {
                    //Melee Combat
                    if (combatChoice != "1")
                    {
                        fight = new MeleeCombat();
                        Weapons melee = playerCharacter.GetMeleeWeapon();
                        fight.Attack(roller.AttackRoll(melee.GetDamageDice()), melee.GetWeaponName());
                    }

                    //Ranged Combat
                    else if (combatChoice != "2")
                    {
                        fight = new RangedCombat();
                        RangedWeapons ranged = playerCharacter.GetRangedWeapon();
                        if (ranged.GetAmmunitionAmmount() > 0)
                        {
                            ranged.SetAmmunitionAmmount(fight.UseAmmunition(ranged.GetAmmunitionAmmount()));
                            fight.Attack(roller.AttackRoll(ranged.GetDamageDice()), ranged.GetWeaponName());
                        }
                        else Console.WriteLine("You have no ammunition for the attack.");
                    }

                    else Console.WriteLine("please enter a number from the menu.");
                } while (combatChoice != "1" || combatChoice != "2");
            }

            //Save Character and it's Equippment
            else if (playerChoice == "3")
            {
                records.SaveCharacter(playerCharacter, characterName);
            }

            //Shows Character Information
            else if (playerChoice == "4")
            {
                Console.WriteLine($"Name: {characterName}");
                Console.WriteLine($"Level: {playerCharacter.GetLevel()}");
                Console.WriteLine($"Strength: {strength}");
                Console.WriteLine($"Dexterity: {dexterity}");
                Console.WriteLine($"Constitution: {constitution}");
                Console.WriteLine($"Intelligence: {intelligence}");
                Console.WriteLine($"Wisdom: {wisdom}");
                Console.WriteLine($"Charisma: {charisma}");
                Console.WriteLine();

                if (playerCharacter is EquippedCharacter)
                {
                    meleeWeapon = playerCharacter.GetMeleeWeapon();
                    rangedWeapon = playerCharacter.GetRangedWeapon();
                    armor = playerCharacter.GetArmor();

                    Console.WriteLine($"Melee Weapon: {meleeWeapon.GetWeaponInfo()}");
                    Console.WriteLine($"Ranged Weapon: {rangedWeapon.GetWeaponInfo()}");
                    Console.WriteLine($"Armor: {armor.GetArmorInfo()}");
                }

                Console.WriteLine();
                Console.WriteLine("Presss enter when you're ready.");
                Console.ReadLine();
            }

            //Quit
            else if (playerChoice == "5")
            {
                Console.WriteLine("Thank You, plese come again!");
                endLoop = true;
            }

            //For User Error
            else
            {
                Console.WriteLine("Please enter a number from the Menu.");
                Thread.Sleep(1000);
            }

            Console.Clear();
        } while (!endLoop);
    }
}
