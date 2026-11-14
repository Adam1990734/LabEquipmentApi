using LabEquipmentApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi(opt => opt.OpenApiVersion = Microsoft.OpenApi.OpenApiSpecVersion.OpenApi3_0);

builder.Services.AddDbContext<LabDbContext>(opt =>
    opt.UseNpgsql(
        builder.Configuration.GetConnectionString("LabEquipmentDB")
    )
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(opt => opt.SwaggerEndpoint("/openapi/v1.json", "V1"));
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
