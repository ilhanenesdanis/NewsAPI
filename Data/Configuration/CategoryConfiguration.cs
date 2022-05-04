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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.UpdateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.IsActive).HasDefaultValue(false);
            builder.HasOne(x => x.Language).WithMany(x => x.Categories).HasForeignKey(x => x.LanguageId).IsRequired();

        }
    }
}
