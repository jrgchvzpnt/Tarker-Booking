using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;
using Tarker.Booking.Persistence.DataBase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseServices>(options => options.UseSqlServer(builder.Configuration["SqlConnectionString"]));

builder.Services.AddScoped<IDataBaseServices, DataBaseServices>();

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.MapPost("/createTest", async (IDataBaseServices _databaseService) =>
// {
//     var entity = new Tarker.Booking.Domain.Entities.User.UserEntity
//     {
//         FirstName = "Jorge ",
//         LastName = " puente",
//         UserName = "jrgerne",
//         Password = "CR&/%$#23"
//     };
//     await _databaseService.User.AddAsync(entity);
//     await _databaseService.SaveAsync();

//     return "Create OK";

// });

//app.MapGet("/testGet", async (IDataBaseServices _databaseService) =>
//{
//    var resultado = await _databaseService.User.ToListAsync();
//    return resultado;

//});


app.Run();

