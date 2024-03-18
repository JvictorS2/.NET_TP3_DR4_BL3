using Microsoft.EntityFrameworkCore;
using TP3_.NET.Context;

// Cria a um constructor de aplica��o usando o webapplication
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// adiciona os servi�os de controller e view
builder.Services.AddControllersWithViews();

// Configura��o do banco de dados sqlite
builder.Services.AddDbContext<InfnetDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DbContext"));
}
);

// constr�i a aplica��o utilizando o constructor criado anteriomente 
var app = builder.Build();

// Configure the HTTP request pipeline.
// habilita o http strict transport secuity em ambiente de produ��o
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Defini a rota padr�o 
app.MapGet("/", context => {
    context.Response.Redirect("/Computadors");
    return Task.CompletedTask;
});


app.UseHttpsRedirection(); // Configura��o de middlewares
app.UseStaticFiles();      // Habilita arquivos de html, css, javascript
app.UseRouting();
app.UseAuthorization();

// Mapeia a rota padr�o para controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Exercuta a aplica��o
app.Run();
