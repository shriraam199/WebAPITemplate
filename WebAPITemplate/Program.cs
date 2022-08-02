using System;
using Steeltoe.Management.Endpoint;

var builder = WebApplication.CreateBuilder(args).AddInfoActuator().AddHealthActuator().AddLoggersActuator();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Event Handlers

AppDomain.CurrentDomain.ProcessExit += (objectData, eventArgs) => 
{
    Console.WriteLine("Received SIGTERM");
};

Console.CancelKeyPress += (objectData, eventArgs) =>
{
    Console.WriteLine("Received SIGINT");
};

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();

app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();

app.Run();
