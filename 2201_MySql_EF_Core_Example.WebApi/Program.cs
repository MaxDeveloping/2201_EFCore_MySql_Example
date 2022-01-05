using _2201_MySql_EF_Core_Example.Storage.Contexts;
using _2201_MySql_EF_Core_Example.WebApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


if (builder.Environment.IsDevelopment())
{
    var connectionStringId = "LocalTestDb";
    var connectionString = builder.Configuration.GetConnectionString(connectionStringId);

    var serverVersion = MySqlServerVersion.AutoDetect(connectionString);
    //builder.Services.AddDbContext<StorageContext>(options => options.UseMySql(connectionString, serverVersion));

    builder.Services.AddDbContext<StorageContext>(options => options.UseMySql(connectionString, serverVersion,
    options => options.MigrationsAssembly(Constants.MySqlDatabaseAssemblyName)));
}

var app = builder.Build();

using (var serviceScope = app.Services.CreateScope())
{
    var provider = serviceScope.ServiceProvider;

    var storageContext = provider.GetRequiredService<StorageContext>();
    //storageContext.Database.EnsureCreated();
    storageContext.Database.Migrate();
}


// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
