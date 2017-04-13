using System.Data.Entity.ModelConfiguration;
using VidzyCodeFirst.Models;

namespace VidzyCodeFirst.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
