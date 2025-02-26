using Microsoft.EntityFrameworkCore;
using Model_OuterrimSpaceship.Repos;
using Web_OuterrimSpaceship.AmelieAmKoche;
using Web_OuterrimSpaceship.Components;
using Web_OuterrimSpaceship.Components.Pages;
using Web_OuterrimSpaceship.DB;
using Web_OuterrimSpaceship.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<AircraftContext>(options =>
    options.UseSqlite("Data Source=./DB/aircraft.db"));

builder.Services.AddScoped<IRepositoryAsync<Aircrafts>, ARepositoryAsync<Aircrafts>>();
builder.Services.AddScoped<AircraftService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();