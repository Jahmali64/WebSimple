﻿using Scalar.AspNetCore;

namespace WebSimple.API.Startup;

public static class OpenApiConfig {
    public static void AddOpenApiServices(this IServiceCollection services) {
        services.AddOpenApi();
    }

    public static void UseOpenApi(this WebApplication app) {
        if (app.Environment.IsDevelopment()) {
            app.MapOpenApi();
            app.MapScalarApiReference(options => {
                options.Title = "Web Simple API";
                options.Theme = ScalarTheme.Saturn;
                options.Layout = ScalarLayout.Modern;
                options.HideClientButton = true;
            });
        }
    }
}
