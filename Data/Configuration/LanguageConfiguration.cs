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
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id).IsUnique();
            builder.Property(x=>x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
        }
    }
}
