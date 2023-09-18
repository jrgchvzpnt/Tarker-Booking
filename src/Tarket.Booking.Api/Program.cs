
using Tarker.Booking.Application;
using Tarker.Booking.Persistence;
using Tarket.Booking.Api;
using Tarker.Booking.Common;
using Tarker.Booking.External;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);


var app = builder.Build();

app.Run();

