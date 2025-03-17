using WebSimple.API.Endpoints;
using WebSimple.API.Startup;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.AddDependencies();

WebApplication app = builder.Build();

app.UseOpenApi();
app.UseHttpsRedirection();
app.AddRootEndpoints();

app.Run();