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
    public class NewsCategoryConfiguration : IEntityTypeConfiguration<NewsCategory>
    {
        public void Configure(EntityTypeBuilder<NewsCategory> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.NewsId, x.CategoryId }).IsUnique();
            builder.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x=>x.UpdateDate).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.IsActive).HasDefaultValue(false);
            builder.HasOne(x => x.News).WithMany(x => x.NewsCategories).HasForeignKey(x => x.NewsId);
            builder.HasOne(x => x.Category).WithMany(x => x.NewsCategories).HasForeignKey(x => x.CategoryId);
        }
    }
}
