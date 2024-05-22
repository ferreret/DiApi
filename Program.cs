using DiApi.Data;
using DiApi.DataServices;
using DiApi.Middleware;
using DiApi.Utility;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddScoped<IDataRepo, SqlDataRepo>();
builder.Services.AddSingleton<IDataRepo, NoSqlDataRepo>();
builder.Services.AddScoped<IDataService, HttpDataService>();

builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();

var app = builder.Build();

app.UseCustomMiddleware();

app.UseHttpsRedirection();

app.MapGet("/getdata", (IOperationTransient transient, IOperationScoped scoped, IOperationSingleton singleton) =>
{
    // repo.ReturnData();

    // return Results.Ok();

    Console.WriteLine($"Endpoint; TransientId {transient.OperationId} ScopeId {scoped.OperationId} SingletonId {singleton.OperationId}");
    return Results.Ok();
});

app.Run();

