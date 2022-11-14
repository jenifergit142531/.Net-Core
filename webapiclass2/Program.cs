using Microsoft.EntityFrameworkCore;
using webapiclass2.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//DI services
builder.Services.AddScoped<IPlayer, AllPlayer>();
builder.Services.AddScoped<IPlayer, PlayerPersonalDetails>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//
//builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<GameContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("GameConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   // app.UseSwagger();
    //app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
