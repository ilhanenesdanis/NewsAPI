using API.Filters;
using Cache;
using Core.Repository;
using Core.Service;
using Core.UnitOfWork;
using Data;
using Data.Repository;
using Data.UnitOfWork;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Service;
using Service.IService;
using Service.Mapping;
using Service.Service;
using Service.Validator;
using System.Reflection;


var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
IWebHostEnvironment environment = builder.Environment;

builder.Services.AddDependencies(configuration);
builder.Services.AddMemoryCache();
//FluentValidation  
builder.Services.AddControllers(options=>options.Filters.Add(new ValidateFilter()))
    .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<TagValidator>())
    .AddNewtonsoftJson(x=>x.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddScoped<ITagService, TagServiceCaching>();
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