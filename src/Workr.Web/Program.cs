using Marten;
using MediatR;
using Microsoft.OpenApi.Models;
using Workr.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .AddApplicationPart(AssemblyReference.Assembly)
    .AddControllersAsServices();

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

// Configure Swagger
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Workout Tracker API",
        Description = "Provides a RESTful API for workout tracker applications"
    });

    var xmlFilename = $"{AssemblyReference.Assembly.GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

builder.Services
    .AddMediatR(Workr.Application.AssemblyReference.Assembly);

builder.Services.AddMarten(options =>
{
    options.Connection(builder.Configuration.GetConnectionString("Postgres")!);
});

builder.Services.AddCors(options =>
{
    options.AddPolicy(builder.Configuration.GetValue<string>("CorsPolicy:Name"), corsPolicyBuilder => corsPolicyBuilder
        .WithOrigins(builder.Configuration.GetValue<string>("CorsPolicy:Origin"))
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder.Configuration.GetValue<string>("CorsPolicy:Name"));

app.UseHttpsRedirection();

app.MapControllers();

app.Run();