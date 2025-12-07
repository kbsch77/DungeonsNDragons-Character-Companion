internal class RecordHub
{
    public void SaveCharacter(Character character, string fileName)
    {
        // add csv write code for CharacterList.csv or maybe a json file later on
    }
    public Character LoadCharacter(string fileName)
    {
        Character loadedCharacter = new Character(fileName);

        // add csv read code for CharacterList.csv or maybe a json file later on

        return loadedCharacter;
    }
}