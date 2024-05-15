using buyticketforbus.Data;
using buyticketforbus.Repositories.Abstract;
using buyticketforbus.Repositories.Concreate.EfCore;
using buyticketforbus.Repositories.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CombinedContext>(options=>{
    var conString = builder.Configuration.GetConnectionString("mysql");
    options.UseMySql(conString,ServerVersion.AutoDetect(conString));
});

builder.Services.AddDbContext<IdentityContext>(options=>{
    var conString = builder.Configuration.GetConnectionString("mysql");
    options.UseMySql(conString,ServerVersion.AutoDetect(conString));
});
builder.Services.AddIdentity<AppUser, IdentityRole>()
    .AddEntityFrameworkStores<CombinedContext>()
    .AddDefaultTokenProviders();
    
builder.Services.AddScoped<IMailService,EfEmailService>(i=>new EfEmailService(
    builder.Configuration["EmailSender:Host"],
    builder.Configuration.GetValue<int>("EmailSender:Port"),
    builder.Configuration.GetValue<bool>("EmailSender:EnableSSL"),
    builder.Configuration["EmailSender:username"],
    builder.Configuration["EmailSender:password"]

));
builder.Services.AddScoped<IPersonelService,EfPersonelService>();
builder.Services.AddScoped<IUserService,EfUserService>();
builder.Services.AddScoped<ITourService,EfTourService>();
builder.Services.AddScoped<IPassengerService,EfPassengerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
