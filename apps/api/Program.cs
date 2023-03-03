using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Init.Api.postgresContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/inventory", async (Init.Api.postgresContext db) =>
    await db.InventoryItems.ToListAsync()
);

app.MapPost("/inventory", async (Init.Api.Models.InventoryItem item, Init.Api.postgresContext db) =>
{
    if(item.Id == null ) {
        item.Id = Guid.NewGuid();
    }
    db.InventoryItems.Add(item);
    await db.SaveChangesAsync();

    return Results.Created($"/inventory/{item.Id}", item);
});

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
