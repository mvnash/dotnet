using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

// GET /tva.
app.MapGet("/tva", (HttpContext context) =>
{

    var prixStr = context.Request.Query["prix"];
    var codePays = context.Request.Query["codePays"];

    if (codePays != "BE" && codePays != "FR")
    {
        return BadRequestResult("Code de pays non valide. Utilisez 'BE' ou 'FR'.");
    }

    if (!decimal.TryParse(prixStr, out decimal prix))
    {
        return Results.BadRequest("Le paramètre 'prix' n'est pas un nombre valide.");
    }

    decimal tva = codePays switch
    {
        "BE" => prix * 0.21m,
        "FR" => prix * 0.20m,
        _ => 0,
    };

    return $"Montant de la TVA ({codePays}): {tva:C}";
});


app.Run();