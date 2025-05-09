using System.Net;
using System.Runtime.CompilerServices;
using Azure.Core;
using Fee.Application.FeeStrategies;
using Fee.Endpoints.Contracts;
using Fee.Infrastructure;
using FluentValidation;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Fee.Endpoints
{
    public static class VehicleFeeEndpoints
    {
        public static IEndpointRouteBuilder MapVehicleFeeEndpoints(this IEndpointRouteBuilder app)
        {

            app.MapPost("/fee", (
                CalculateVehicleRequest request,
                FeeContext context,
                IValidator<CalculateVehicleRequest> validator
                  ) =>
            {

                var validate = validator.Validate(request);
                if (!validate.IsValid)
                {
                    var errors = validate.Errors.Select(e => e.ErrorMessage).ToList();
                    return Results.BadRequest(errors);
                }

                var fee = context.CalculateFee(request);

                return Results.Ok(new
                {
                    Fee = fee
                });

            });
            return app;

        }

    }
}

