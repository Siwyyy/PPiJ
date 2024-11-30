using System.Numerics;
using System.Runtime.InteropServices.ComTypes;
using Zad1.Enums;

namespace Zad1.Classes;

class Character
{
    public string Name { get; set; }
    public CharacterClassEnum CharacterClass { get; set; }
    public GenderEnum Gender { get; set; }
    public int Level { get; set; }
    public int Experience { get; set; }
    public Statistics Statistics { get; set; }

    /// <summary>
    /// Create fresh new character
    /// </summary>
    public Character(string name, CharacterClassEnum characterClass, GenderEnum gender)
    {
        Name = name;
        CharacterClass = characterClass;
        Gender = gender;
        Level = 1;
        Experience = 0;
        Statistics = new Statistics(characterClass);
    }

    /// <summary>
    /// Create character with custom experience and statistics
    /// </summary>
    public Character(string name, CharacterClassEnum characterClass, GenderEnum gender, int experience, Statistics statistics)
        : this(name, characterClass, gender)
    {
        Name = name;
        CharacterClass = characterClass;
        Gender = gender;

        Level = 1;
        Experience = 0;
        GainExp(experience);

        Statistics = statistics;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine($"Name: {Name}\n" +
                          $"Class: {CharacterClass}\n" +
                          $"Gender: {Gender}");
    }

    public void DisplayExpInfo()
    {
        Console.WriteLine($"Level: {Level} | Exp: {Experience}/{Experience + ExpRequiredToLevelUp()}");
    }

    public void DisplayFullInfo()
    {
        DisplayBasicInfo();
        DisplayExpInfo();
        Statistics.DisplayStatistics();
        Console.WriteLine('\n');
    }


    public bool IntelligenceCheck(int requiredIntelligence)
    {
        return Statistics.Intelligence >= requiredIntelligence;
    }

    public bool StrengthCheck(int requiredStrength)
    {
        return Statistics.Strength >= requiredStrength;
    }

    public bool DexterityCheck(int requiredDexterity)
    {
        return Statistics.Dexterity >= requiredDexterity;
    }

    public void GainExp(int exp)
    {
        while (exp >= ExpRequiredToLevelUp())
        {
            exp -= ExpRequiredToLevelUp();
            Level++;
        }

        Experience += exp;
    }

    public int ExpRequiredToLevelUp()
    {
        return 100 + (int)Math.Pow(Level, 2);
    }
}