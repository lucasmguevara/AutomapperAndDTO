using AutoMapper;

namespace AutomapperAndDTO
{
    public class autoMapperProfile : Profile
    {
        public autoMapperProfile()
        {
            CreateMap<SuperHero, SuperHeroDto>();
            CreateMap<SuperHeroDto, SuperHero>();
        }
    }
}
