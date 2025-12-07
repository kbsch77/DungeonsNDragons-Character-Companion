using System.Threading.Tasks;

namespace DungeonsNDragons_Character_Companion
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCharacterCreatorClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("CharacterCreatorPage");
        }
    }
}
