using GameStore.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<GameDto> games=[];

app.MapGet("/", () => "Hello World!");

app.Run();
