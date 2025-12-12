using Microsoft.Maui.Controls;

namespace DungeonsNDragons_Character_Companion.View;

public partial class CharacterCreatorPage : ContentPage
{
    Character playerCharacter;
    string characterName = "";
    string characterClass;
    string characterbacground;
    int strength;
    int dexterity;
    int constitution;
    int intelligence;
    int wisdom;
    int charisma;

    internal CharacterCreatorPage(Character character)
    {
        playerCharacter = character;
        InitializeComponent();

        UpdateStats();
    }

    private void UpdateStats()
    {
        StrLabel.Text = $"Strength: {Convert.ToString(playerCharacter.GetStrength())}";
        DexLabel.Text = $"Dexterity: {Convert.ToString(playerCharacter.GetDexterity())}";
        ConLabel.Text = $"Constitution: {Convert.ToString(playerCharacter.GetConstitution())}";
        IntLabel.Text = $"Intelligence: {Convert.ToString(playerCharacter.GetIntelligence())}";
        WisLabel.Text = $"Wisdom: {Convert.ToString(playerCharacter.GetWisdom())}";
        ChaLabel.Text = $"Charisma: {Convert.ToString(playerCharacter.GetCharisma())}";
    }
    private void OnRollForStatsClicked(object sender, EventArgs e)
    {
        playerCharacter = new Character(characterName);
        strength = playerCharacter.GetStrength();
        dexterity = playerCharacter.GetDexterity();
        constitution = playerCharacter.GetConstitution();
        intelligence = playerCharacter.GetIntelligence();
        wisdom = playerCharacter.GetWisdom();
        charisma = playerCharacter.GetCharisma();

        UpdateStats();
    }
    private void OnPointBuyClicked(object sender, EventArgs e)
    {
        //work in progress
        //playerCharacter = new Character(characterName);
    }

    // entry text changes
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
    }

    // manuel stat changes
    void OnStrCompleted(object sender, EventArgs e) //str
    {
        string text = ((Entry)sender).Text;
        strength = int.Parse(text);
        playerCharacter.SetStrength(strength);
        StrLabel.Text = $"Strength: {text}";
    }
    void OnDexCompleted(object sender, EventArgs e) //dex
    {
        string text = ((Entry)sender).Text;
        dexterity = int.Parse(text);
        playerCharacter.SetDexterity(dexterity);
        DexLabel.Text = $"Dexterity: {text}";
    }
    void OnConCompleted(object sender, EventArgs e) //con
    {
        string text = ((Entry)sender).Text;
        constitution = int.Parse(text);
        playerCharacter.SetConstitution(constitution);
        ConLabel.Text = $"Constitution: {text}";
    }
    void OnIntCompleted(object sender, EventArgs e) //int
    {
        string text = ((Entry)sender).Text;
        intelligence = int.Parse(text);
        playerCharacter.SetIntelligence(intelligence);
        IntLabel.Text = $"Intelligence: {text}";
    }
    void OnWisCompleted(object sender, EventArgs e) //wis
    {
        string text = ((Entry)sender).Text;
        wisdom = int.Parse(text);
        playerCharacter.SetWisdom(wisdom);
        WisLabel.Text = $"Wisdom: {text}";
    }
    void OnChaCompleted(object sender, EventArgs e) //cha
    {
        string text = ((Entry)sender).Text;
        charisma = int.Parse(text);
        playerCharacter.SetCharisma(charisma);
        ChaLabel.Text = $"Charisma: {text}";
    }

    //changes character's name
    void NameChanged(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
        characterName = text;
        playerCharacter.SetName(characterName);
    }

    //picker index changes 
    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;

        if (selectedIndex != -1)
        {
            if(picker.Title == "ClassPicker")
            {
                characterClass = picker.Items[selectedIndex];
                playerCharacter.SetClass(characterClass);
            }
            else if(picker.Title == "BackgroundPicker")
            {
                characterbacground = picker.Items[selectedIndex];
                playerCharacter.SetBackground(characterbacground);
            }
                
        }
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.CharacterPage(playerCharacter));
    }
}