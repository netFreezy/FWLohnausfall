using Lohnausfall.Components;
using Lohnausfall.Components.Interfaces;
using Lohnausfall.Components.Services;
using Lohnausfall.Core.Models;
using MudBlazor;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices(config =>
    {
        config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopCenter;
        config.SnackbarConfiguration.VisibleStateDuration = 3000;
    }
);

builder.Services.AddDbContext<ApplicationDBContext>();
builder.Services.AddScoped<IMembersService, MembersService>();
builder.Services.AddScoped<IResidencesInterface, ResidencesService>();

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
