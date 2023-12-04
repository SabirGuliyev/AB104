using Microsoft.EntityFrameworkCore;
using ProniaAB104.DAL;
using ProniaAB104.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
   opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"))
);

builder.Services.AddScoped<LayoutService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddSession(options =>
options.IdleTimeout = TimeSpan.FromSeconds(50)
) ;
var app = builder.Build();

app.UseSession();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    "default",
    "{area:exists}/{controller=home}/{action=index}/{id?}"

    );

app.MapControllerRoute(
    "default",
    "{controller=home}/{action=index}/{id?}"

    );

app.Run();
