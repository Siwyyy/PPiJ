using System.ComponentModel;
using System.Text.Json;
using Zad1.Classes;
using Zad1.Enums;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            characters.Add(new Character("Butcher", CharacterClassEnum.Warrior, GenderEnum.Male));
            characters.Add(new Character("Mazekeen", CharacterClassEnum.Rogue, GenderEnum.Female));
            characters.Add(new Character("Gandalf", CharacterClassEnum.Mage, GenderEnum.Male));
            characters.Add(new Character("ShadowWalker", CharacterClassEnum.Rogue, GenderEnum.Male, 3000, new Statistics(15, 41, 23)));
            characters.Add(new Character("FireQueen", CharacterClassEnum.Mage, GenderEnum.Female, 10000, new Statistics(11, 27, 64)));

            foreach (var character in characters)
            {
                character.DisplayFullInfo();
            }

            string jsonString = JsonSerializer.Serialize(characters);
            File.WriteAllText("new_characters.json", jsonString);
        }
    }
}