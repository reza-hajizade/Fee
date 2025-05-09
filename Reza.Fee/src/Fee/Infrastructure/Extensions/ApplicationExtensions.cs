using System.Reflection;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using Fee.Application.Interfaces;
using Fee.Application.FeeStrategies;

namespace Fee.Infrastructure.Extensions;

public static class ApplicationExtensions
    {
        public static void AddApplicationServices(this IHostApplicationBuilder builder)
        {
            builder.Services.AddDbContext<FeeDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("SvcDbContext")));


        builder.Services.AddScoped<IFeeCalculator, CarBuyStrategy>();
        builder.Services.AddScoped<IFeeCalculator, CarSellStrategy>();
        builder.Services.AddScoped<IFeeCalculator, BusBuyStrategy>();
        builder.Services.AddScoped<IFeeCalculator, BusSellStrategy>();
        builder.Services.AddScoped<IFeeCalculator, TruckBuyStrategy>();
        builder.Services.AddScoped<IFeeCalculator, TruckSellStrategy>();
        builder.Services.AddScoped<FeeContext>();


        builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());


    }

}


