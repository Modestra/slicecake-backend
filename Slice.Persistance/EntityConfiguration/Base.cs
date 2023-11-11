using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Note.Domain;
namespace Slice.Persistance;

public class Base : IEntityTypeConfiguration<Notes>
{
    /// <summary>
    /// Параметры для таблица в базе данных
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<Notes> builder)
    {
        
    }
}