using HotChocolate.Checker.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotChocolate.Checker.Persistence.Configurations;

public class GenreBookConnectionConfiguration : IEntityTypeConfiguration<GenreBooksConnectionEntity>
{
    public void Configure(EntityTypeBuilder<GenreBooksConnectionEntity> builder)
    {
        builder.HasKey(static k => k.Id);
    }
}