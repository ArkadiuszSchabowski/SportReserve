using SportReserve_ApiGateway.Helpers;
using SportReserve_ApiGateway.Validators;
using SportReserve_Shared.Interfaces;
using SportReserve_Shared.Middleware;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });

var isDocker = Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") == "true";
if (isDocker)
{
    builder.WebHost.UseUrls("http://*:5000");

    builder.Services.AddHttpClient("UserService", client =>
    {
        client.BaseAddress = new Uri("http://user:5001/api/user/");
    });

    builder.Services.AddHttpClient("RaceService", client =>
    {
        client.BaseAddress = new Uri("http://race:5002/api/race/");
    });

    builder.Services.AddHttpClient("RaceTraceService", client =>
    {
        client.BaseAddress = new Uri("http://race:5002/api/racetrace/");
    });

    builder.Services.AddHttpClient("EmailService", client =>
    {
        client.BaseAddress = new Uri("http://email:5003/api/email/");
    });
}
else
{
    builder.Services.AddHttpClient("UserService", client =>
    {
        client.BaseAddress = new Uri("http://localhost:5001/api/user/");
    });

    builder.Services.AddHttpClient("RaceService", client =>
    {
        client.BaseAddress = new Uri("http://localhost:5002/api/race/");
    });

    builder.Services.AddHttpClient("RaceTraceService", client =>
    {
        client.BaseAddress = new Uri("http://localhost:5002/api/racetrace/");
    });

    builder.Services.AddHttpClient("EmailService", client =>
    {
        client.BaseAddress = new Uri("http://localhost:5003/api/email/");
    });
}

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("ApiGatewayPolicy", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddScoped<IHttpResponseValidator, HttpResponseValidator>();
builder.Services.AddScoped<IHttpResponseHelper, HttpResponseHelper>();

builder.Services.AddScoped<ErrorHandlingMiddleware>();

var app = builder.Build();

app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseCors("ApiGatewayPolicy");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
