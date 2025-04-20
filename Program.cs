using Microsoft.OpenApi.Models;
using SPAL.App.Infrastructure;
using SPAL.App.Routes;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSqlServices();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "1.0",
        Version = "SPAL API",
        Description = "Operations for SPAL entities",
        Contact = new OpenApiContact
        {
            Name = "Team SPAL",
            Email = "SPAL@donotreply.com"
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.DisplayOperationId();
    });
}

app.MapUser();

app.Run();
