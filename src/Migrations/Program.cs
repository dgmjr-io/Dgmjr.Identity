using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DgmjrId.IdentityDbContext>(
    options =>
    options
    .UseSqlServer(
        builder.Configuration.GetConnectionString("IdentityDb"),
        builder => builder.MigrationsAssembly(typeof(Program).Assembly.GetName().Name)
    )
    .EnableSensitiveDataLogging(false)
    .EnableDetailedErrors(false)
    .EnableThreadSafetyChecks(false)
    .EnableServiceProviderCaching(false),
    ServiceLifetime.Transient,
    ServiceLifetime.Transient
);

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.Run();
