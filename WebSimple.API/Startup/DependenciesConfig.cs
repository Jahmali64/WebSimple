﻿namespace WebSimple.API.Startup;

public static class DependenciesConfig {
    public static void AddDependencies(this WebApplicationBuilder builder) {
        builder.Services.AddOpenApiServices();
    }
}
