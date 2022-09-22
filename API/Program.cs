var builder = WebApplication.CreateBuilder(args);

// Add services to the container. Equivalent to startup
// builder.Services.AddIdentityService(builder.configuration)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options => {
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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

// Configure seed here


app.Run(); // Change to async?
