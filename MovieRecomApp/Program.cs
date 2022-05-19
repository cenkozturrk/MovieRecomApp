using Microsoft.EntityFrameworkCore;
using MovieRecomApp.Core.Repositories.Abstract;
using MovieRecommApp.Business;
using MovieRecommApp.DataAccess;
using MovieRecommendation.Core;
using MovieRecommendation.Core.Services;

var builder = WebApplication.CreateBuilder(args);
string connString = builder.Configuration.GetConnectionString("DefaultConnection");
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplication();

string cs = "server=ceku; database=MovieDb; trusted_connection=true";
builder.Services.AddDbContext<EntityContext>(options => options.UseSqlServer(cs));

builder.Services.AddTransient<IMovieRepository, IMovieRepository>();
//builder.Services.AddTransient<IRepository, EntityRepository();



//builder.Services.AddDbContext<MovieContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

//});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
