namespace DungeonsNDragons_Character_Companion.View;

public partial class CharacterPage : ContentPage
{
	public CharacterPage(CharacterViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}