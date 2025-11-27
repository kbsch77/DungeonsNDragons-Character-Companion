class Gear
{
    private Dictionary<string, List<string>> _meleeWeapons = new Dictionary<string, List<string>>();
    private Dictionary<string, List<string>> _RangedWeapons = new Dictionary<string, List<string>>();
    private Dictionary<string, List<string>> _armors = new Dictionary<string, List<string>>();
    private string _weight;
    private string _cost;

    public Gear(){
        SetArmors();
        SetMeleeWeapons();
        SetRangedWeapons();
    }

    public virtual string GetWeapon (string weapon)
    {
        return null;
    }
    public virtual string GetArmor(string armor)
    {
        return null;
    }

    public void SetMeleeWeapons()
    {
        string[] lines = System.IO.File.ReadAllLines("MeleeWeapons.csv");

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string name = parts[0];
            List<string> info = new List<string>()
            {
                parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7]
            };

            _meleeWeapons.Add(name, info);
        }
    }
    public Dictionary<string, List<string>> GetMeleeWeapons()
    {
        return _meleeWeapons;
    }
    public void SetRangedWeapons()
    {
        string[] lines = System.IO.File.ReadAllLines("RangedWeapons.csv");

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string name = parts[0];
            List<string> info = new List<string>()
            {
                parts[1], parts[2], parts[3], parts[4], parts[5], parts[6], parts[7], parts[8], parts[9], parts[10]
            };

            _RangedWeapons.Add(name, info);
        }
    }
    public Dictionary<string, List<string>> GetRangedWeapons()
    {
        return _RangedWeapons;
    }
    public void SetArmors()
    {
        string[] lines = System.IO.File.ReadAllLines("Armor.csv");

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string name = parts[0];
            List<string> info = new List<string>()
            {
                parts[1], parts[2], parts[3], parts[4], parts[5], parts[6]
            };

            _armors.Add(name, info);
        }
    }
    public Dictionary<string, List<string>> GetArmors()
    {
        return _armors;
    }
    public void SetWeight(string weight)
    {
        _weight = weight;
    }
    public string GetWeight()
    {
        return _weight;
    }
    public void SetCost(string cost)
    {
        _cost = cost;
    }
    public string GetCost()
    {
        return _cost;
    }
}