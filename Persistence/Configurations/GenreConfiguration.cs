using Bogus;
using HotChocolate.Checker.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotChocolate.Checker.Persistence.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<GenreEntity>
{
    public void Configure(EntityTypeBuilder<GenreEntity> builder)
    {
        builder.HasKey(static k => k.Id);

        builder.HasMany<BookEntity>()
            .WithMany(static p => p.Genre);

        var genre = new List<GenreEntity>();
        for (var i = 1; i < 100; i++)
        {
            var faker = new Faker();
            genre.Add(new()
            {
                Id = i,
                Name = faker.Music.Genre(),
            });
        }

        builder.HasData(genre);
    }
}