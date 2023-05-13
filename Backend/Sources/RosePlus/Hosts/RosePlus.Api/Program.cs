using Microsoft.EntityFrameworkCore;
using RosePlus.AppServices.LoggerDb;
using RosePlus.DataAccess.Context;
using RosePlus.Infrastructure.Middleware;
using RosePlus.Migrations;
using RosePlus.Migrations.Factories;
using RosePlus.Registrar;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Logging.AddDatabase();
builder.Logging.AddConsole();
builder.RegisterServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//Init migrations
using (var scope = app.Services.CreateScope())
{
    var context = new MigrationContextFactory().CreateDbContext(null);
    
    if (context.Database.GetPendingMigrations().Any())
    {
        context.Database.Migrate();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseMiddleware<ExceptionHandlingMiddleware>();
app.MapControllers();

app.Run();