using Microsoft.Maui.Controls;

namespace DungeonsNDragons_Character_Companion.View;

public partial class CharacterCreatorPage : ContentPage
{
    Character playerCharacter = new Character("Test");
    string characterName = "";
    string characterClass;
    string characterbacground;
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
    private void OnRollForStatsClicked(object sender, EventArgs e)
    {
        playerCharacter = new Character(characterName);
    }
    private void OnPointBuyClicked(object sender, EventArgs e)
    {
        //currently same as rolled stats, work in progress
        playerCharacter = new Character(characterName);
    }

    // entry text changes
    void OnEntryTextChanged(object sender, TextChangedEventArgs e)
    {
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = entry.Text;
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

    void OnEntryCompleted(object sender, EventArgs e)
    {
        string text = ((Entry)sender).Text;
    }
}