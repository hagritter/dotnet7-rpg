﻿namespace dotnet_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
    private static List<Character> characters = new List<Character>
    {
        new Character(),
        new Character { Id = 1, Name = "Sam" }
    };
    
    public async Task<List<Character>> GetAllCharacters()
    {
        return characters;
    }

    public async Task<Character> GetCharacterById(int id)
    {
        var character = characters.FirstOrDefault(c => c.Id == id);
        if (character != null)
        {
            return character;
        }

        throw new Exception("Character not found");
    }

    public async Task<List<Character>> AddCharacter(Character newCharacter)
    {
        characters.Add(newCharacter);
        return characters;
    }
}
