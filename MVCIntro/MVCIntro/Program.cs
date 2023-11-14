
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

//app.MapControllerRoute(
//    name:"default",
//    pattern:"{controller}/{action=detail}/{id?}"
//    );
//app.MapControllerRoute(
//    "Corporative",
//    pattern: "korporativ-satishlar",
//    defaults: new { Controller = "CorporativeSales", Action = "Index" }
//    );
app.MapControllerRoute(

               name: "default",
               pattern: "{controller=home}/{action=index}/{id?}"
               );

app.Run();