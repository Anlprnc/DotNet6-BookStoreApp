using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book { Id = 1, CategoryId = 1, Title = "Foundation", Price = 100 },
                new Book { Id = 2, CategoryId = 2, Title = "Dune", Price = 90 },
                new Book { Id = 3, CategoryId = 1, Title = "LOTR", Price = 85 }
            );
        }
    }
}