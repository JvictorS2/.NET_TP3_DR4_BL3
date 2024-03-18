using Microsoft.EntityFrameworkCore;
using TP3_.NET.Context;

// Cria a um constructor de aplicação usando o webapplication
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// adiciona os serviços de controller e view
builder.Services.AddControllersWithViews();

// Configuração do banco de dados sqlite
builder.Services.AddDbContext<InfnetDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DbContext"));
}
);

// constrói a aplicação utilizando o constructor criado anteriomente 
var app = builder.Build();

// Configure the HTTP request pipeline.
// habilita o http strict transport secuity em ambiente de produção
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Defini a rota padrão 
app.MapGet("/", context => {
    context.Response.Redirect("/Computadors");
    return Task.CompletedTask;
});


app.UseHttpsRedirection(); // Configuração de middlewares
app.UseStaticFiles();      // Habilita arquivos de html, css, javascript
app.UseRouting();
app.UseAuthorization();

// Mapeia a rota padrão para controladores
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Exercuta a aplicação
app.Run();
