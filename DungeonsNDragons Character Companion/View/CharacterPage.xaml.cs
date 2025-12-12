using Microsoft.Maui;

namespace DungeonsNDragons_Character_Companion.View;

public partial class CharacterPage : ContentPage
{
	Character character;
	internal CharacterPage(Character character1)
	{
        character = character1;

        InitializeComponent();
        //CharacterViewModel viewModel = new CharacterViewModel();
        //BindingContext = viewModel;

        SetCharacterValues();
    }

    private void SetCharacterValues()
    {
        CharacterName.Text = character.GetName();
        CharacterClass.Text = character.GetClass();
        CharacterBackground.Text = character.GetBackground();

        StrLabel.Text = $"Strength: {Convert.ToString(character.GetStrength())}";
        DexLabel.Text = $"Dexterity: {Convert.ToString(character.GetDexterity())}";
        ConLabel.Text = $"Constitution: {Convert.ToString(character.GetConstitution())}";
        IntLabel.Text = $"Intelligence: {Convert.ToString(character.GetIntelligence())}";
        WisLabel.Text = $"Wisdom: {Convert.ToString(character.GetWisdom())}";
        ChaLabel.Text = $"Charisma: {Convert.ToString(character.GetCharisma())}";

        StrSaveLabel.Text = $"Strength Save: {Convert.ToString(character._strengthSave)}";
        DexSaveLabel.Text = $"Dexterity Save: {Convert.ToString(character._dexteritySave)}";
        ConSaveLabel.Text = $"Constitution Save: {Convert.ToString(character._constitutionSave)}";
        IntSaveLabel.Text = $"Intelligence Save: {Convert.ToString(character._intelligenceSave)}";
        WisSaveLabel.Text = $"Wisdom Save: {Convert.ToString(character._wisdomSave)}";
        ChaSaveLabel.Text = $"Charisma Save: {Convert.ToString(character._charismaSave)}";

        AthleticsLabel.Text = $"Athletics: {Convert.ToString(character._athletics)}";
        AcrobaticsLabel.Text = $"Acrobatics: {Convert.ToString(character._acrobatics)}";
        SleightOfHandLabel.Text = $"Sleight of Hand: {Convert.ToString(character._sleightOfHand)}";
        StealthLabel.Text = $"Stealth: {Convert.ToString(character._stealth)}";
        ArcanaLabel.Text = $"Arcana: {Convert.ToString(character._arcana)}";
        HistoryLabel.Text = $"History: {Convert.ToString(character._history)}";
        InvestigationLabel.Text = $"Investigation: {Convert.ToString(character._investigation)}";
        NatureLabel.Text = $"Nature: {Convert.ToString(character._nature)}";
        ReligionLabel.Text = $"Religion: {Convert.ToString(character._religion)}";
        AnimalHandlingLabel.Text = $"Animal Handling: {Convert.ToString(character._animalHandling)}";
        InsightLabel.Text = $"Insight: {Convert.ToString(character._insight)}";
        MedicineLabel.Text = $"Medicine: {Convert.ToString(character._medicine)}";
        PerceptionLabel.Text = $"Perception: {Convert.ToString(character._perception)}";
        SurvivalLabel.Text = $"Survival: {Convert.ToString(character._survival)}";
        DeceptionLabel.Text = $"Deception: {Convert.ToString(character._deception)}";
        IntimidationLabel.Text = $"Intimidation: {Convert.ToString(character._intimidation)}";
        PerformanceLabel.Text = $"Performance: {Convert.ToString(character._performance)}";
        PersuasionLabel.Text = $"Persuasion: {Convert.ToString(character._persuasion)}";
    }

    private async void OnEditClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.CharacterCreatorPage(character));
    }
}