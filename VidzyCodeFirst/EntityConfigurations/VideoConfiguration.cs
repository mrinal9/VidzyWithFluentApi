using System.Data.Entity.ModelConfiguration;
using VidzyCodeFirst.Models;

namespace VidzyCodeFirst.EntityConfigurations
{
    public class VideoConfiguration : EntityTypeConfiguration<Video>
    {
        public VideoConfiguration()
        {
            Property(v => v.Name)
                .IsRequired()
                .HasMaxLength(255);
            Property(v => v.Classification)
                .HasColumnType("tinyint");

            HasRequired(v => v.Genre)
                .WithMany(g => g.Movies)
                .HasForeignKey(v => v.GennreId)
                .WillCascadeOnDelete(false);

            HasMany(v => v.Tags)
                .WithMany(v => v.Videos)
                .Map(m =>
                {
                    m.ToTable("VideoTags");
                    m.MapLeftKey("VideoId");
                    m.MapRightKey("TagId");
                });


        }
    }
}
