using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new {x.Title,x.Id});
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.UpdateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.IsActive).HasDefaultValue(false);
            builder.Property(x => x.Title).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.Content).HasMaxLength(int.MaxValue);
            builder.Property(x => x.Image).HasMaxLength(250).IsRequired(false);
            builder.Property(x => x.SeoKeyword).HasMaxLength(180).IsRequired(false);
            builder.Property(x => x.SeoUrl).HasMaxLength(180).IsRequired(false);
            builder.Property(x => x.SeoTitle).HasMaxLength(180).IsRequired(false);
            builder.Property(x => x.SeoDescription).HasMaxLength(180).IsRequired(false);
        }
    }
}
