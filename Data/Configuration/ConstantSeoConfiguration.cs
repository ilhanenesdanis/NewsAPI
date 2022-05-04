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
    public class ConstantSeoConfiguration : IEntityTypeConfiguration<ConstantSeo>
    {
        public void Configure(EntityTypeBuilder<ConstantSeo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Keyword).HasMaxLength(180).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(180).IsRequired();
            builder.Property(x => x.Title).HasMaxLength(180).IsRequired();
            builder.Property(x=>x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.UpdateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.IsActive).HasDefaultValue(true);
            builder.HasOne(x => x.Language).WithMany(x => x.ConstantSeos).HasForeignKey(x => x.LanguageId).IsRequired();
        }
    }
}
