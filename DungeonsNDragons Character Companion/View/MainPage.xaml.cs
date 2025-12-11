using System.Threading.Tasks;

namespace DungeonsNDragons_Character_Companion
{
    public partial class MainPage : ContentPage
    {
        Character playerCharacter = new Character("Test");
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCharacterCreatorClicked(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync("CharacterCreatorPage");
            await Navigation.PushAsync(new View.CharacterCreatorPage(playerCharacter));
        }
        private async void OnLoadCharacterClicked(object sender, EventArgs e)
        {
            //await Shell.Current.GoToAsync("CharacterPage");
            await Navigation.PushAsync(new View.CharacterPage(playerCharacter));
        }
    }
}
