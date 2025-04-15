using Microsoft.EntityFrameworkCore;
using SmartCityDashboard.Data; // Your EF Core DbContext
using SmartCityDashboard.Components; // Your Razor App component

var builder = WebApplication.CreateBuilder(args);

// 🔧 Add services
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents(); // This is the .NET 8 equivalent of AddServerSideBlazor
builder.Services.AddScoped<TrafficService>();
builder.Services.AddHttpClient();

// 🔗 Register EF Core DbContext with SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// 🌐 Middleware pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode(); // Required for interactivity in .NET 8 Blazor Server

app.Run();
