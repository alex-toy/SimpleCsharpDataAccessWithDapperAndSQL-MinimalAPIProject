using DataAccess.Data.Articles;
using DataAccess.Repositories;
using MinimalAPIDemo;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ISqlDataAccess, SqlDataAccess>();

builder.Services.AddSingleton<IUserData, UserData>();
builder.Services.AddSingleton<IArticleData, ArticleData>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.ConfigureHTTPRequestPipeline();

app.ConfigureAPI();


app.Run();

