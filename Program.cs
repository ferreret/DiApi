using DiApi.Data;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddScoped<IDataRepo, NoSqlDataRepo>();
builder.Services.AddScoped<IDataRepo, SqlDataRepo>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/getdata", (IDataRepo repo) =>
{
    repo.ReturnData();

    return Results.Ok();
});

app.Run();

