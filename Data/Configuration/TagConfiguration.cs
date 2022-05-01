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
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);
            builder.HasOne(x => x.Language).WithMany(x => x.Tags).HasForeignKey(x => x.LanguageId);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x=>x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.UpdateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.IsActive).HasDefaultValue(false);
        }
    }
}
