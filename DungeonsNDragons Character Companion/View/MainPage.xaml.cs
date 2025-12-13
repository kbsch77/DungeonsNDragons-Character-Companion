using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;

namespace DungeonsNDragons_Character_Companion
{
    public partial class MainPage : ContentPage
    {
        Character playerCharacter;
        string characterName = "";
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCharacterCreatorClicked(object sender, EventArgs e)
        {
            playerCharacter = new Character("");
            //await Shell.Current.GoToAsync("CharacterCreatorPage");
            await Navigation.PushAsync(new View.CharacterCreatorPage(playerCharacter));
        }

        // entry text changes
        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            string myText = entry.Text;
        }

        void NameChanged(object sender, EventArgs e)
        {
            //changes character's name
            string text = ((Entry)sender).Text;
            characterName = text;
        }
        private async void OnLoadCharacterClicked(object sender, EventArgs e)
        {
            string filename = FileSystem.AppDataDirectory + $"/{characterName}.json";
            LoadCharacter(filename);

            //await Shell.Current.GoToAsync("CharacterPage");
            await Navigation.PushAsync(new View.CharacterPage(playerCharacter));
        }
        private async void LoadCharacter(string fileName)
        {
            //Json Deserialization
            Character readCharacter = new Character("");
            try
            {
                if (File.Exists(fileName) == false)
                {
                    //no file
                    return;
                }
                var json = File.ReadAllText(fileName);
                readCharacter = JsonSerializer.Deserialize<Character>(json);

                playerCharacter.SetName(readCharacter.GetName());
                playerCharacter.SetClass(readCharacter.GetClass());
                playerCharacter.SetBackground(readCharacter.GetBackground());
                playerCharacter.SetLevel(readCharacter.GetLevel());
                playerCharacter.SetStrength(readCharacter.GetStrength());
                playerCharacter.SetDexterity(readCharacter.GetDexterity());
                playerCharacter.SetConstitution(readCharacter.GetConstitution());
                playerCharacter.SetIntelligence(readCharacter.GetIntelligence());
                playerCharacter.SetWisdom(readCharacter.GetWisdom());
                playerCharacter.SetCharisma(readCharacter.GetCharisma());
            }
            catch (Exception ex) 
            { 
                return;
            }
            
        }
    }
}
