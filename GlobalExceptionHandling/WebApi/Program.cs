using WebApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
 
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
 
// ***** Uncomment the line below only if you are using second approach *****
// builder.Services.AddTransient<ExceptionMiddleware>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

// This line is common for both approaches
app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();
