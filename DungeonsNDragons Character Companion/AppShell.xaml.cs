using DungeonsNDragons_Character_Companion.View;

namespace DungeonsNDragons_Character_Companion
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("CharacterCreatorPage", typeof(CharacterCreatorPage));
        }
    }
}
