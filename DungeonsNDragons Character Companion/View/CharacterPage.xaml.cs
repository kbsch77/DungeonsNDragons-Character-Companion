namespace DungeonsNDragons_Character_Companion.View;

public partial class CharacterPage : ContentPage
{
	Character character;
	internal CharacterPage(Character character1)
	{
        CharacterViewModel viewModel = new CharacterViewModel();
        character = character1;
        InitializeComponent();
		BindingContext = viewModel;
	}

    private async void OnEditClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new View.CharacterCreatorPage(character));
    }
}