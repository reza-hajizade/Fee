using System.Net;
using System.Text.Json.Serialization;
using Fee;
using Fee.Endpoints;
using Fee.Endpoints.Contracts;
using Fee.Infrastructure.Extensions;
using FluentValidation;
using Microsoft.AspNetCore.Http.Json;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.AddApplicationServices();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGroup("/api/v1/Vehicle")
    .WithTags("VehicleFee")
    .MapVehicleFeeEndpoints();

app.Run();
