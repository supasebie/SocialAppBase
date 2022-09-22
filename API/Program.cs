var builder = WebApplication.CreateBuilder(args);

var MyOrigins = "_myOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyOrigins,
                        policy =>
                        {
                            policy.WithOrigins("https://localhost:4200")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                        });
});

// Add services to the container. Equivalent to startup
// builder.Services.AddIdentityService(builder.configuration)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataContext>(options =>
{
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

app.UseCors(MyOrigins);

app.UseAuthorization();

app.MapControllers();

// Configure seed here


app.Run(); // Change to async?
