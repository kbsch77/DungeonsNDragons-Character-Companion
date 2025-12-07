using Microsoft.Maui.Controls;

namespace DungeonsNDragons_Character_Companion.View;

public partial class CharacterCreatorPage : ContentPage
{
    Character playerCharacter = new Character("Test");
    string characterName = "";
    int strength;
    int dexterity;
    int constitution;
    int intelligence;
    int wisdom;
    int charisma;

    public CharacterCreatorPage()
	{
		InitializeComponent();
    }
    private async void OnRollForStatsClicked(object sender, EventArgs e)
    {
        playerCharacter = new Character(characterName);
    }
    private async void OnPointBuyClicked(object sender, EventArgs e)
    {
        return;
    }
    private async void OnManuelClicked(object sender, EventArgs e)
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
    }
}