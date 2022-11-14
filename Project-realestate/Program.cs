using Microsoft.EntityFrameworkCore;
using realestate_DAL;
using Realstate_BL;
using Realstate_DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.KD
#region services
#region Defaults

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion

#endregion

#region Database
var ConnectionString = builder.Configuration.GetConnectionString("Realstate");
builder.Services.AddDbContext<RealstateContext>(options => options.UseSqlServer(ConnectionString));

#endregion

#region Repos
builder.Services.AddScoped<IAdvertisementsRepo,AdvertisementsRepo>();
#endregion

#region AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
#endregion

#region Managers
builder.Services.AddScoped<IAdvManager, AdvManager>();
#endregion
var app = builder.Build();

// Configure the HTTP request pipeline.
#region Middlewares

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion
