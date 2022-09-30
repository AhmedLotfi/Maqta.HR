global using FastEndpoints;
using FastEndpoints.Swagger;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddFastEndpoints();
builder.Services.AddSwaggerDoc(settings =>
{
    settings.Title = "Maqta.HR.API";
    settings.Version = "v1";
});


WebApplication app = builder.Build();

app.UseHttpsRedirection();
app.UseFastEndpoints();
app.UseOpenApi();
app.UseSwaggerUi3(s => s.ConfigureDefaults());
app.Run();