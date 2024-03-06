namespace dotnet_rpg;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // Map a Character object into a DTO:
        CreateMap<Character, GetCharacterDto>();
        CreateMap<AddCharacterDto, Character>();
        
        //alternative Character update version by using Automapper:
        // CreateMap<UpdateCharacterDto, Character>();
    }
}