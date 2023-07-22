using HotChocolate.Checker.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotChocolate.Checker.Persistence.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<GenreEntity>
{
    public void Configure(EntityTypeBuilder<GenreEntity> builder)
    {
        builder.HasKey(static k => k.Id);

        builder.HasMany(static p => p.Book)
            .WithMany(static p => p.Genre);
    }
}