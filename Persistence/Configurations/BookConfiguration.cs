using HotChocolate.Checker.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotChocolate.Checker.Persistence.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<BookEntity>
{
    public void Configure(EntityTypeBuilder<BookEntity> builder)
    {
        builder.HasKey(static k => k.Id);

        builder.HasOne(static p => p.Author)
            .WithMany();

        builder.HasMany(static p => p.Genre)
            .WithMany(static p => p.Book)
            .UsingEntity<GenreBooksConnectionEntity>();

        builder.Navigation(static e => e.Genre); //.AutoInclude(); //NOTE: workaround for "IsProjected" on complex objects e.g.: navigations
    }
}