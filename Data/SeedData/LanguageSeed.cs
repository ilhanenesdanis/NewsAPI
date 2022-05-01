using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.SeedData
{
    public class LanguageSeed : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
                new Language { Id = 1, IsActive = true, CreateDate = DateTime.Now, Name = "Türkçe", UpdateDate = DateTime.Now },
                new Language { Id = 2, IsActive = true, CreateDate = DateTime.Now, Name = "İngilizce", UpdateDate = DateTime.Now }
                );
        }
    }
}
