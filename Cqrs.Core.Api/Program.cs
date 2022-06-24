using Cqrs.Core.Api.Data;
using FluentValidation;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddDbContextPool<BookContext>(options =>
{
    options.UseMySql(builder.Configuration.GetConnectionString("BookStoreDb"), ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("BookStoreDb")));
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
