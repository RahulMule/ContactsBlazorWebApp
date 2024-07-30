using ContactsBlazorWebApp.Components;
using ContactsBlazorWebApp.DataContext;
using ContactsBlazorWebApp.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContext<ContactsContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQL"));
});
//builder.Services.AddScoped<IContactsRepository>();
builder.Services.AddScoped<ContactsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
