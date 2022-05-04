using Core.Repository;
using Core.Service;
using Core.UnitOfWork;
using Data;
using Data.Repository;
using Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Service.IService;
using Service.Mapping;
using Service.Service;
using System.Reflection;

namespace Service
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(MapProfiles));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<Context>(x =>
                x.UseSqlServer(configuration.GetConnectionString("SqlConnection"), options =>
                {
                    options.MigrationsAssembly(Assembly.GetAssembly(typeof(Context)).GetName().Name);
                })
            );

            //Repository Katmanı
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IConstantSeoRepository,ConstantSeoRepository>();
            services.AddScoped<INewsCategoryRepository,NewsCategoryRepository>();
            services.AddScoped<INewsRepository,NewsRepository>();
            services.AddScoped<INewsTagRepository,NewsTagRepository>();
            //service Katmanı
            services.AddScoped(typeof(IService<>), typeof(Service<>));
            services.AddScoped<ITagService, TagService>();
            services.AddScoped<ICategoryService,CategoryService>();
            services.AddScoped<IConstantSeoService,ConstantSeoService>();
            services.AddScoped<INewsService,NewsService>();
            services.AddScoped<INewsTagService,NewsTagService>();
            services.AddScoped<INewsCategoryService,NewsCategoryService>();

        }
    }
}
