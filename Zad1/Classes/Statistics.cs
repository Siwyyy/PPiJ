namespace Zad1.Classes;

using Zad1.Enums;

public class Statistics
{
    public int Strength;
    public int Dexterity;
    public int Intelligence;

    /// <summary>
    /// Set custom values
    /// </summary>
    public Statistics(int strength, int dexterity, int intelligence)
    {
        Strength = strength;
        Dexterity = dexterity;
        Intelligence = intelligence;
    }

    /// <summary>
    /// Set default values for specified class
    /// </summary>
    public Statistics(CharacterClassEnum characterClass)
    {
        switch (characterClass)
        {
            case CharacterClassEnum.Warrior:
                Strength = 8;
                Dexterity = 5;
                Intelligence = 3;
                break;
            case CharacterClassEnum.Rogue:
                Strength = 4;
                Dexterity = 7;
                Intelligence = 5;
                break;
            case CharacterClassEnum.Mage:
                Strength = 2;
                Dexterity = 4;
                Intelligence = 10;
                break;
            default:
                throw new Exception("Undefined character class, cannot initialize statistics");
        }
    }

    public void DisplayStatistics()
    {
        Console.WriteLine($"STR:{Strength} | DEX:{Dexterity} | INT:{Intelligence}");
    }
}