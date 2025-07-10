using System.Text.Json.Serialization;
using eCommerce.API.Middleware;
using eCommerce.Core;
using eCommerce.Core.Mappers;
using eCommerce.Infrastructure;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastruction();
builder.Services.AddCore();



builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});
// bir dene mapping profilini bu sekilde qeyd etmek kifayet edirki digerlerinin de yeri mueyyenlessin
builder.Services.AddAutoMapper(typeof(ApplicationUserMappingProfile).Assembly);


//services.addfluentvalidation isletmek olar lakin diger butun validation profilelerin yerini gostermek ucun asagidaki method kifayetdir
builder.Services.AddFluentValidationAutoValidation();

//API explorer service
builder.Services.AddEndpointsApiExplorer();

//Add swagger generation service to create swagger spesification
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder => {
        builder.WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
app.UseExceptionHandlingMiddleware();

app.UseRouting();

app.UseSwagger();
app.UseSwaggerUI();
//app.UseHttpsRedirection();

app.UseCors();

app.UseAuthentication();
app.UseAuthentication();

app.MapControllers();

app.Run();
