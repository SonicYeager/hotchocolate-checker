using AutoMapper;
using HotChocolate.Checker.GraphQL.Types;
using HotChocolate.Checker.Persistence.Entities;

namespace HotChocolate.Checker.AutoMapper;

public sealed class AutoMapperConfig : Profile
{
    public AutoMapperConfig()
    {
        CreateMap<UserEntity, User>();
            //.ForAllMembers(static o => o.ExplicitExpansion());
            CreateMap<BookEntity, Book>()
                .ForMember(
                    static dst => dst.FirstGenre,
                    static opt => opt.MapFrom(
                        static src => src.Genre.FirstOrDefault(x => x.Id == src.Id)));
            //.ForAllMembers(static o => o.ExplicitExpansion());
            CreateMap<GenreEntity, Genre>();
            //.ForAllMembers(static o => o.ExplicitExpansion());
    }
}