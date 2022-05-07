using API.Filters;
using Cache;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Service;
using Service.IService;
using Service.Service;
using Service.Validator;


var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;

builder.Services.AddDependencies(configuration);
builder.Services.AddMemoryCache();
//FluentValidation  
builder.Services.AddControllers(options=>options.Filters.Add(new ValidateFilter()))
    .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<TagValidator>())
    .AddNewtonsoftJson(x=>x.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore);
//Cache
builder.Services.AddScoped<ITagService, TagServiceCaching>();
builder.Services.AddScoped<ICategoryService, CategoryServiceCache>();

builder.Services.Configure<ApiBehaviorOptions>(x =>
{
    x.SuppressModelStateInvalidFilter = true;
});
builder.Services.AddEndpointsApiExplorer();
// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.Run();